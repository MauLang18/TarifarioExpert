using Microsoft.IdentityModel.Clients.ActiveDirectory;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tarifarios_Tarifas.Globales;
using Tarifarios_Tarifas.Models.Atributos;
using Tarifarios_Tarifas.Models.Metodos;
using System.Threading;

namespace Tarifarios_Tarifas.Forms.Competencia
{
    public partial class FrmCostos : Form
    {
        private COMPETENCIA mCompetidores;
        private CompetenciaConsultas mCompetidoresConsulta;
        string montov = "";
        string montov1 = "";
        string montov2 = "";
        string montov3 = "";
        float montoguardado = 0;
        float montoguardado1 = 0;
        float montoguardado2 = 0;
        float montoguardado3 = 0;
        string montov4 = "";
        float montoguardado4;
        public FrmCostos()
        {
            InitializeComponent();
            mCompetidores = new COMPETENCIA();
            mCompetidoresConsulta = new CompetenciaConsultas();
        }

        private void cargarDatosGuardados()
        {
            mCompetidores.Nombre = DatosTarifarioC.nombre;
            mCompetidores.Flete = float.Parse(DatosTarifarioC.flete);
            mCompetidores.Cargos_Destino = float.Parse(DatosTarifarioC.cargos_destino);
            mCompetidores.Otros_Cargos = float.Parse(DatosTarifarioC.otros_costos);
            mCompetidores.IVA = float.Parse(DatosTarifarioC.iva);
            mCompetidores.Desde = DatosTarifarioC.desde;
            mCompetidores.Hasta = DatosTarifarioC.hasta;
            mCompetidores.Total = float.Parse(DatosTarifarioC.TotalTarifario);
            mCompetidores.Id_Equipo = DatosTarifarioC.id_equipo;
            mCompetidores.Id_Modalidad = DatosTarifarioC.id_modalidad;
            mCompetidores.Ruta = DatosTarifarioC.ruta;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DatosTarifarioC.flete = txtFlete.Text;
            DatosTarifarioC.cargos_destino = txtCargosDestino.Text;
            DatosTarifarioC.otros_costos = txtOtrosCostos.Text;
            DatosTarifarioC.iva = txtIva.Text;
            DatosTarifarioC.TotalTarifario = txtTotal.Text;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            cargarDatosGuardados();

            //Console.WriteLine(CreateAsync());
            if (mCompetidoresConsulta.agregarCompetencia(mCompetidores))
            {
                CreateAsync();
                MessageBox.Show("TARIFARIO CREADO");
            }
        }

        public async Task<string> CreateAsync()
        {
            //id de la api web
            string clientId = "04f616d1-fb10-4c4f-ba02-45d2562fa9a8";
            //clave secreta de la api web
            string clientSecrets = "1cn8Q~reOm4kQQ5fuaMUbR_X.cmtbQwyxv22IaVH";
            //login
            string authority = "https://login.microsoftonline.com/48f7ad87-a406-4c72-98f5-d1c996e7e6f2";
            //direccion url
            string crmUrl = "https://sibaja07.crm.dynamics.com/";
            string response2 = "";

            string accessToken = string.Empty;

            ClientCredential credentials = new ClientCredential(clientId, clientSecrets);
            var authContext = new AuthenticationContext(authority);
            var result = await authContext.AcquireTokenAsync(crmUrl, credentials);
            accessToken = result.AccessToken;
            Console.WriteLine(accessToken);

            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(crmUrl);
                httpClient.Timeout = new TimeSpan(0, 2, 0);
                httpClient.DefaultRequestHeaders.Add("OData-MaxVersion", "4.0");
                httpClient.DefaultRequestHeaders.Add("OData-Version", "4.0");
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

                string entityName = "salesorders";

                dynamic content = new JObject();
                content.new_nombrecompetidor = DatosTarifarioC.nombre;
                content.name = DatosTarifarioC.ruta;
                content["transactioncurrencyid@odata.bind"] = "/transactioncurrencies(b3a963da-2eda-e611-80f2-fc15b42826a0)";
                content.new_modalidad1 = DatosTarifarioC.modalidad;
                content.new_equipo1 = DatosTarifarioC.equipo;
                content.new_desde = DatosTarifarioC.desde;
                content.new_hasta = DatosTarifarioC.hasta;
                content.new_pol1 = DatosTarifarioC.pol;
                content.new_pod1 = DatosTarifarioC.pod;
                content.new_origen1 = DatosTarifarioC.origen;
                content.new_destino1 = DatosTarifarioC.destino;
                content.new_via = DatosTarifarioC.via;
                content.new_proveedoragenteorigen = "IVA";
                content.new_totalagenteorigen = float.Parse(DatosTarifarioC.iva);
                content.new_totalfleteinternacional = float.Parse(DatosTarifarioC.flete);
                content.new_totaltransbordo = float.Parse(DatosTarifarioC.otros_costos);
                content.new_totalcargosdestino = float.Parse(DatosTarifarioC.cargos_destino);
                HttpContent httpContent = new StringContent(content.ToString(), UnicodeEncoding.UTF8, "application/json");
                HttpResponseMessage httpResponseMessage = await httpClient.PostAsync($"api/data/v9.2/{entityName}", httpContent);
                var response = httpResponseMessage.EnsureSuccessStatusCode();

                response2 = response.ToString();

                Console.WriteLine(response);
            }

            return response2;
        }

        private void txtFlete_TextChanged(object sender, EventArgs e)
        {
            if (!montov.Equals("0"))
            {
                if (!txtFlete.Text.Equals(montov))
                {
                    float monto = float.Parse(txtTotal.Text);
                    float monto1 = float.Parse(txtFlete.Text);
                    float monto2 = (monto - montoguardado) + monto1;
                    txtTotal.Text = (monto2).ToString();
                    montoguardado = float.Parse(txtFlete.Text);
                }
            }
            else
            {
                float monto = float.Parse(txtTotal.Text);
                float monto1 = float.Parse(txtFlete.Text);
                montoguardado = float.Parse(txtFlete.Text);
                txtTotal.Text = (monto + monto1).ToString();
            }
        }

        private void txtCargosDestino_TextChanged(object sender, EventArgs e)
        {
            if (!montov1.Equals("0"))
            {
                if (!txtCargosDestino.Text.Equals(montov1))
                {
                    float monto = float.Parse(txtTotal.Text);
                    float monto1 = float.Parse(txtCargosDestino.Text);
                    float monto2 = (monto - montoguardado1) + monto1;
                    txtTotal.Text = (monto2).ToString();
                    montoguardado1 = float.Parse(txtCargosDestino.Text);
                }
            }
            else
            {
                float monto = float.Parse(txtTotal.Text);
                float monto1 = float.Parse(txtCargosDestino.Text);
                montoguardado1 = float.Parse(txtCargosDestino.Text);
                txtTotal.Text = (monto + monto1).ToString();
            }
        }

        private void txtOtrosCostos_TextChanged(object sender, EventArgs e)
        {
            if (!montov2.Equals("0"))
            {
                if (!txtOtrosCostos.Text.Equals(montov2))
                {
                    float monto = float.Parse(txtTotal.Text);
                    float monto1 = float.Parse(txtOtrosCostos.Text);
                    float monto2 = (monto - montoguardado2) + monto1;
                    txtTotal.Text = (monto2).ToString();
                    montoguardado2 = float.Parse(txtOtrosCostos.Text);
                }
            }
            else
            {
                float monto = float.Parse(txtTotal.Text);
                float monto1 = float.Parse(txtOtrosCostos.Text);
                montoguardado2 = float.Parse(txtOtrosCostos.Text);
                txtTotal.Text = (monto + monto1).ToString();
            }
        }

        private void txtIva_TextChanged(object sender, EventArgs e)
        {
            if (!montov3.Equals("0"))
            {
                if (!txtIva.Text.Equals(montov3))
                {
                    float monto = float.Parse(txtTotal.Text);
                    float monto1 = float.Parse(txtIva.Text);
                    float monto2 = (monto - montoguardado3) + monto1;
                    txtTotal.Text = (monto2).ToString();
                    montoguardado3 = float.Parse(txtIva.Text);
                }
            }
            else
            {
                float monto = float.Parse(txtTotal.Text);
                float monto1 = float.Parse(txtIva.Text);
                montoguardado3 = float.Parse(txtIva.Text);
                txtTotal.Text = (monto + monto1).ToString();
            }
        }
    }
}
