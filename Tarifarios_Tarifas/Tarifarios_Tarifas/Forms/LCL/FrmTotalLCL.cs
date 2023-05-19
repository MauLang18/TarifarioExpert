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

namespace Tarifarios_Tarifas.Forms.LCL
{
    public partial class FrmTotalLCL : Form
    {
        private LCLtarifarios mTarifarios;
        private LCLConsultas mTarifariosConsulta;
        public FrmTotalLCL()
        {
            InitializeComponent();
            mTarifarios = new LCLtarifarios();
            mTarifariosConsulta = new LCLConsultas();
            if (DatosTarifarioLCL.total != null)
            {
                var totalFleteCBM = float.Parse(DatosTarifarioLCL.flete) + float.Parse(DatosTarifarioLCL.transbordo_total) + float.Parse(DatosTarifarioLCL.flete_cargo_destino);
                var totalFleteMinimo = float.Parse(DatosTarifarioLCL.flete2);
                var totalOtrosCostosCBM = float.Parse(DatosTarifarioLCL.total_cargos_destino);
                var totalOtrosCostosMinimos = float.Parse(DatosTarifarioLCL.total_flete2);
                var totalOtrosCostosFLAT = float.Parse(DatosTarifarioLCL.total) + float.Parse(DatosTarifarioLCL.total_flete) + float.Parse(DatosTarifarioLCL.otras_categorias_total);
                txtTotalFleteCBM.Text = totalFleteCBM.ToString();
                txtTotalFleteMinimo.Text = totalFleteMinimo.ToString();
                txtTotalOtrosCostosCBM.Text = totalOtrosCostosCBM.ToString();
                txtTotalOtrosCostosMinimo.Text = totalOtrosCostosMinimos.ToString();
                txtTotalOtrosCostosFlat1.Text = totalOtrosCostosFLAT.ToString();
                txtTotalOtrosCostosFlat2.Text = totalOtrosCostosFLAT.ToString();
            }
            else
            {
                var totalFleteCBM = float.Parse(DatosTarifarioLCL.flete) + float.Parse(DatosTarifarioLCL.transbordo_total) + float.Parse(DatosTarifarioLCL.flete_cargo_destino);
                var totalFleteMinimo = float.Parse(DatosTarifarioLCL.flete2);
                var totalOtrosCostosCBM = float.Parse(DatosTarifarioLCL.total_cargos_destino);
                var totalOtrosCostosMinimos = float.Parse(DatosTarifarioLCL.total_flete2);
                var totalOtrosCostosFLAT = float.Parse(DatosTarifarioLCL.total) + float.Parse(DatosTarifarioLCL.total_flete) + float.Parse(DatosTarifarioLCL.otras_categorias_total);
                txtTotalFleteCBM.Text = totalFleteCBM.ToString();
                txtTotalFleteMinimo.Text = totalFleteMinimo.ToString();
                txtTotalOtrosCostosCBM.Text = totalOtrosCostosCBM.ToString();
                txtTotalOtrosCostosMinimo.Text = totalOtrosCostosMinimos.ToString();
                txtTotalOtrosCostosFlat1.Text = totalOtrosCostosFLAT.ToString();
                txtTotalOtrosCostosFlat2.Text = totalOtrosCostosFLAT.ToString();
            }
        }
        private void cargarDatosGuardados()
        {
            var totalFleteCBM = float.Parse(DatosTarifarioLCL.flete) + float.Parse(DatosTarifarioLCL.transbordo_total) + float.Parse(DatosTarifarioLCL.flete_cargo_destino);
            var totalFleteMinimo = float.Parse(DatosTarifarioLCL.flete2);
            var totalOtrosCostosCBM = float.Parse(DatosTarifarioLCL.total_cargos_destino);
            var totalOtrosCostosMinimos = float.Parse(DatosTarifarioLCL.total_flete2);
            var totalOtrosCostosFLAT = float.Parse(DatosTarifarioLCL.total) + float.Parse(DatosTarifarioLCL.total_flete) + float.Parse(DatosTarifarioLCL.otras_categorias_total);
            mTarifarios.Id_Agente_Origen = DatosTarifarioLCL.id_agente_origen;
            mTarifarios.Id_Naviero = DatosTarifarioLCL.id_naviero;
            mTarifarios.Id_Gastos_Portuarios = DatosTarifarioLCL.id_cargos_en_destino;
            mTarifarios.Id_Movimiento_Puerto_Bodega = DatosTarifarioLCL.id_movimiento_bodega;
            mTarifarios.Id_Otras_Categorias1 = DatosTarifarioLCL.id_otras_categorias1;
            mTarifarios.Id_Otras_Categorias2 = DatosTarifarioLCL.id_otras_categorias2;
            mTarifarios.Id_Otras_Categorias3 = DatosTarifarioLCL.id_otras_categorias3;
            mTarifarios.Id_Cargos_Destino1 = DatosTarifarioLCL.id_cargos_destino1;
            mTarifarios.Id_Cargos_Destino2 = DatosTarifarioLCL.id_cargos_destino2;
            mTarifarios.Id_Cargos_Destino3 = DatosTarifarioLCL.id_cargos_destino3;
            mTarifarios.Id_Equipo = DatosTarifarioLCL.id_equipo;
            mTarifarios.Id_Modalidad = DatosTarifarioLCL.id_modalidad;
            mTarifarios.Desde = DatosTarifarioLCL.desde;
            mTarifarios.Hasta = DatosTarifarioLCL.hasta;
            mTarifarios.Ruta = DatosTarifarioLCL.ruta;
            mTarifarios.Total_Flete_Cbm = float.Parse(totalFleteCBM.ToString());
            mTarifarios.Total_Otros_Costos_Cbm = float.Parse(totalOtrosCostosCBM.ToString());
            mTarifarios.Total_Flete_Minimo = float.Parse(totalFleteMinimo.ToString());
            mTarifarios.Total_Otros_Costos_Minimos = float.Parse(totalOtrosCostosMinimos.ToString());
            mTarifarios.Total_Otros_Costos_Flat = float.Parse(totalOtrosCostosFLAT.ToString());
        }

        public async Task<string> CreateAsync()
        {
            var totalFleteCBM = float.Parse(DatosTarifarioLCL.flete) + float.Parse(DatosTarifarioLCL.transbordo_total) + float.Parse(DatosTarifarioLCL.flete_cargo_destino);
            var totalFleteMinimo = float.Parse(DatosTarifarioLCL.flete2);
            var totalOtrosCostosCBM = float.Parse(DatosTarifarioLCL.total_cargos_destino);
            var totalOtrosCostosMinimos = float.Parse(DatosTarifarioLCL.total_flete2);
            var totalOtrosCostosFLAT = float.Parse(DatosTarifarioLCL.total) + float.Parse(DatosTarifarioLCL.total_flete) + float.Parse(DatosTarifarioLCL.otras_categorias_total);
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
                content.name = DatosTarifarioLCL.ruta;
                content["transactioncurrencyid@odata.bind"] = "/transactioncurrencies(b3a963da-2eda-e611-80f2-fc15b42826a0)";
                content.new_modalidad1 = DatosTarifarioLCL.modalidad;
                content.new_equipo1 = DatosTarifarioLCL.equipo;
                content.new_desde = DatosTarifarioLCL.desde;
                content.new_hasta = DatosTarifarioLCL.hasta;
                content.new_pol1 = DatosTarifarioLCL.pol;
                content.new_pod1 = DatosTarifarioLCL.pod;
                content.new_origen1 = DatosTarifarioLCL.origen;
                content.new_destino1 = DatosTarifarioLCL.destino;
                content.new_via = DatosTarifarioLCL.via;
                content.new_proveedoragenteorigen = DatosTarifarioLCL.proveedor;
                content.new_totalagenteorigen = float.Parse("0");
                content.new_proveedorfleteinternacional = DatosTarifarioLCL.naviero;
                content.new_fleteinternacional = float.Parse("0");
                content.new_cargoseneldestino = float.Parse("0");
                content.new_totalfleteinternacional = float.Parse("0");
                content.new_gastosportuarios = DatosTarifarioLCL.cargos_en_destino_proveedor;
                content.new_transportepuertobodega = DatosTarifarioLCL.movimiento_bodega_proveedor;
                content.new_otrascategorias = DatosTarifario.otras_categorias_producto1 + " // " + DatosTarifario.otras_categorias_producto2 + " // " + DatosTarifario.otras_categorias_producto3;
                content.new_totaltransbordo = float.Parse("0");
                content.new_proveedorcargosdestino = DatosTarifarioLCL.proveedor_cargos_destino1 + " // " + DatosTarifario.proveedor_cargos_destino2 + " // " + DatosTarifario.proveedor_cargos_destino3;
                content.new_totalcargosdestino = float.Parse("0");
                content.new_totalfletexcbm = float.Parse(totalFleteCBM.ToString());
                content.new_totalfleteminimo = float.Parse(totalFleteMinimo.ToString());
                content.new_totaldeotroscostosxcbm = float.Parse(totalOtrosCostosCBM.ToString());
                content.new_totaldeotroscostosminimos = float.Parse(totalOtrosCostosMinimos.ToString());
                content.new_totaldeotroscostosflat = float.Parse(totalOtrosCostosFLAT.ToString());
                HttpContent httpContent = new StringContent(content.ToString(), UnicodeEncoding.UTF8, "application/json");
                HttpResponseMessage httpResponseMessage = await httpClient.PostAsync($"api/data/v9.2/{entityName}", httpContent);
                var response = httpResponseMessage.EnsureSuccessStatusCode();

                response2 = response.ToString();

                Console.WriteLine(response);
            }

            return response2;
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            cargarDatosGuardados();

            //Console.WriteLine(CreateAsync());
            if (mTarifariosConsulta.agregarLCL(mTarifarios))
            {
                CreateAsync();
                MessageBox.Show("TARIFARIO CREADO");
            }
        }
    }
}
