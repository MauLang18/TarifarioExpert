using Microsoft.IdentityModel.Clients.ActiveDirectory;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Tarifarios_Tarifas.Globales;
using Tarifarios_Tarifas.Models.Atributos;
using Tarifarios_Tarifas.Models.Metodos;

namespace Tarifarios_Tarifas.Forms.Tarifarios
{
    public partial class FrmCargosDestino : Form
    {
        private List<CargosDestino> mCargosDestino;
        private COMPETIDORES mTarifarios;
        private CargosDestinoConsultas mCargosDestinoConsultas;
        private CompetidoresConsultas mTarifariosConsulta;
        string montov = "";
        string montov2 = "";
        string montov4 = "";
        float montoguardado = 0;
        float montoguardado2 = 0;
        float montoguardado4 = 0;
        public FrmCargosDestino()
        {
            InitializeComponent();
            mCargosDestino = new List<CargosDestino>();
            mCargosDestinoConsultas = new CargosDestinoConsultas();
            mTarifarios = new COMPETIDORES();
            mTarifariosConsulta = new CompetidoresConsultas();

            var heightField = typeof(CheckedListBox).GetField("scaledListItemBordersHeight", BindingFlags.NonPublic | BindingFlags.Instance);

            var addedHeight = 30; // Some appropriate value, greater than the field's default of 2

            heightField.SetValue(clbCargosDestino, addedHeight);

            if (DatosTarifario.TotalTarifario != null && DatosTarifario.flete_cargo_destino != null)
            {
                txtCargosD.Text = DatosTarifario.flete_cargo_destino;
                montoguardado = float.Parse(DatosTarifario.flete_cargo_destino);
                txtTotalTarifario.Text = DatosTarifario.TotalTarifario;
                cargarCargosDestino(); 
            }
            else if (DatosTarifario.TotalTarifario != null && DatosTarifario.flete_cargo_destino == null)
            {
                txtTotalTarifario.Text = DatosTarifario.TotalTarifario;
                cargarCargosDestino();
            }
            else
            {
                cargarCargosDestino();
            }
        }
        private void cargarCargosDestino()
        {
            clbCargosDestino.Items.Clear();
            clbCargosDestino.Refresh();
            mCargosDestino.Clear();
            mCargosDestino = mCargosDestinoConsultas.getCargosDestino(DatosTarifario.destino, DatosTarifario.via);
            for (int i = 0; i < mCargosDestino.Count; i++)
            {
                if (DatosTarifario.flete_cargo_destino != null)
                {
                    if (mCargosDestino[i].Proveedor == DatosTarifario.proveedor_cargos_destino1 || mCargosDestino[i].Proveedor == DatosTarifario.proveedor_cargos_destino2 || mCargosDestino[i].Proveedor == DatosTarifario.proveedor_cargos_destino3)
                    {
                        clbCargosDestino.Items.Add(mCargosDestino[i].Proveedor, true);
                    }
                    else
                    {
                        clbCargosDestino.Items.Add(mCargosDestino[i].Proveedor);
                    }
                }
                else
                {
                    clbCargosDestino.Items.Add(mCargosDestino[i].Proveedor);
                }
            }
        }
        private void cargarDatosGuardados()
        {
            mTarifarios.Agente_Origen_Total = float.Parse(DatosTarifario.total);
            mTarifarios.Flete_Internacional_Total = float.Parse(DatosTarifario.flete);
            mTarifarios.Flete_Internacional_Destino = float.Parse(DatosTarifario.total_cargos_destino);
            mTarifarios.Gastos_Portuarios_Total = float.Parse(DatosTarifario.gastos_portuarios);
            mTarifarios.Movimiento_Puerto_Bodega_Total = float.Parse(DatosTarifario.movimiento_puerto_bodega);
            mTarifarios.Otras_Categorias_Total = float.Parse(DatosTarifario.otras_categorias_total);
            mTarifarios.Otros_Servicios_Total = float.Parse(DatosTarifario.otros_servicios_total);
            mTarifarios.Cargos_Detino_Total = float.Parse(DatosTarifario.flete_cargo_destino);
            mTarifarios.Desde = DatosTarifario.desde;
            mTarifarios.Hasta = DatosTarifario.hasta;
            mTarifarios.Total = float.Parse(DatosTarifario.TotalTarifario);
            mTarifarios.Id_Agente_Origen = DatosTarifario.id_agente_origen;
            mTarifarios.Id_Naviero = DatosTarifario.id_naviero;
            mTarifarios.Id_Gastos_Portuarios = DatosTarifario.id_gastos_portuarios;
            mTarifarios.Id_Movimiento_Puerto_Bodega = DatosTarifario.id_movimiento_puerto_bodega;
            mTarifarios.Id_Otras_Categorias1 = DatosTarifario.id_otras_categorias1;
            mTarifarios.Id_Otras_Categorias2 = DatosTarifario.id_otras_categorias2;
            mTarifarios.Id_Otras_Categorias3 = DatosTarifario.id_otras_categorias3;
            mTarifarios.Id_Otros_Servicios1 = DatosTarifario.id_otros_servicios1;
            mTarifarios.Id_Otros_Servicios2 = DatosTarifario.id_otros_servicios2;
            mTarifarios.Id_Otros_Servicios3 = DatosTarifario.id_otros_servicios3;
            mTarifarios.Id_Cargos_Destino1 = DatosTarifario.id_cargos_destino1;
            mTarifarios.Id_Cargos_Destino2 = DatosTarifario.id_cargos_destino2;
            mTarifarios.Id_Cargos_Destino3 = DatosTarifario.id_cargos_destino3;
            mTarifarios.Id_Equipo = DatosTarifario.id_equipo;
            mTarifarios.Id_Modalidad = DatosTarifario.id_modalidad;
            mTarifarios.Ruta = DatosTarifario.ruta;
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (clbCargosDestino.SelectedIndex == -1)
            {
                if (DatosTarifario.proveedor_cargos_destino1 == null || DatosTarifario.proveedor_cargos_destino1 == "")
                {
                    DatosTarifario.proveedor_cargos_destino1 = clbCargosDestino.Text;
                    DatosTarifario.id_cargos_destino1 = 1;
                }
                if (DatosTarifario.proveedor_cargos_destino2 == null || DatosTarifario.proveedor_cargos_destino2 == "")
                {
                    DatosTarifario.proveedor_cargos_destino2 = clbCargosDestino.Text;
                    DatosTarifario.id_cargos_destino2 = 1;
                }
                else if (DatosTarifario.proveedor_cargos_destino3 == null || DatosTarifario.proveedor_cargos_destino3 == "")
                {
                    DatosTarifario.proveedor_cargos_destino3 = clbCargosDestino.Text;
                    DatosTarifario.id_cargos_destino3 = 1;
                }
            }
            else
            {
                if (clbCargosDestino.GetItemCheckState(clbCargosDestino.SelectedIndex) == CheckState.Checked)
                {
                    if ((DatosTarifario.proveedor_cargos_destino1 == null || DatosTarifario.proveedor_cargos_destino1 == "") && (DatosTarifario.proveedor_cargos_destino1 != clbCargosDestino.Text && DatosTarifario.proveedor_cargos_destino2 != clbCargosDestino.Text && DatosTarifario.proveedor_cargos_destino3 != clbCargosDestino.Text))
                    {
                        DatosTarifario.proveedor_cargos_destino1 = clbCargosDestino.Text;
                        DatosTarifario.id_cargos_destino1 = mCargosDestino[clbCargosDestino.SelectedIndex].Id;
                    }
                    else if ((DatosTarifario.proveedor_cargos_destino2 == null || DatosTarifario.proveedor_cargos_destino2 == "") && (DatosTarifario.proveedor_cargos_destino1 != clbCargosDestino.Text && DatosTarifario.proveedor_cargos_destino2 != clbCargosDestino.Text && DatosTarifario.proveedor_cargos_destino3 != clbCargosDestino.Text))
                    {
                        DatosTarifario.proveedor_cargos_destino2 = clbCargosDestino.Text;
                        DatosTarifario.id_cargos_destino2 = mCargosDestino[clbCargosDestino.SelectedIndex].Id;
                    }
                    else if ((DatosTarifario.proveedor_cargos_destino3 == null || DatosTarifario.proveedor_cargos_destino3 == "") && (DatosTarifario.proveedor_cargos_destino1 != clbCargosDestino.Text && DatosTarifario.proveedor_cargos_destino2 != clbCargosDestino.Text && DatosTarifario.proveedor_cargos_destino3 != clbCargosDestino.Text))
                    {
                        DatosTarifario.proveedor_cargos_destino3 = clbCargosDestino.Text;
                        DatosTarifario.id_cargos_destino3 = mCargosDestino[clbCargosDestino.SelectedIndex].Id;
                    }
                }
                else
                {
                    if ((DatosTarifario.proveedor_cargos_destino1 != null || DatosTarifario.proveedor_cargos_destino1 != "") && DatosTarifario.proveedor_cargos_destino1 == clbCargosDestino.Text)
                    {
                        DatosTarifario.otras_categorias_producto1 = "";
                        DatosTarifario.id_cargos_destino1 = 1;
                    }
                    else if ((DatosTarifario.proveedor_cargos_destino2 != null || DatosTarifario.proveedor_cargos_destino2 != "") && DatosTarifario.proveedor_cargos_destino2 == clbCargosDestino.Text)
                    {
                        DatosTarifario.proveedor_cargos_destino2 = "";
                        DatosTarifario.id_cargos_destino2 = 1;
                    }
                    else if ((DatosTarifario.proveedor_cargos_destino3 != null || DatosTarifario.proveedor_cargos_destino3 != "") && DatosTarifario.proveedor_cargos_destino3 == clbCargosDestino.Text)
                    {
                        DatosTarifario.proveedor_cargos_destino3 = "";
                        DatosTarifario.id_cargos_destino3 = 1;
                    }
                }
            }   

            DatosTarifario.flete_cargo_destino = txtCargosD.Text;
            DatosTarifario.TotalTarifario = txtTotalTarifario.Text;

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
                content.name = DatosTarifario.ruta;
                content["transactioncurrencyid@odata.bind"] = "/transactioncurrencies(b3a963da-2eda-e611-80f2-fc15b42826a0)";
                content.new_modalidad1 = DatosTarifario.modalidad;
                content.new_equipo1 = DatosTarifario.equipo;
                content.new_desde = DatosTarifario.desde;
                content.new_hasta = DatosTarifario.hasta;
                content.new_pol1 = DatosTarifario.pol;
                content.new_pod1 = DatosTarifario.pod;
                content.new_origen1 = DatosTarifario.origen;
                content.new_destino1 = DatosTarifario.destino;
                content.new_via = DatosTarifario.via;
                content.new_proveedoragenteorigen = DatosTarifario.proveedor;
                content.new_totalagenteorigen = float.Parse(DatosTarifario.total);
                content.new_proveedorfleteinternacional = DatosTarifario.naviero;
                content.new_fleteinternacional = float.Parse(DatosTarifario.flete);
                content.new_cargoseneldestino = float.Parse(DatosTarifario.total_cargos_destino);
                content.new_totalfleteinternacional = float.Parse(DatosTarifario.total_flete);
                content.new_gastosportuarios = DatosTarifario.gastos_portuarios_proveedor;
                content.new_transportepuertobodega = DatosTarifario.movimiento_puerto_bodega_proveedor;
                content.new_otrascategorias = DatosTarifario.otras_categorias_producto1 + " // " + DatosTarifario.otras_categorias_producto2 + " // " + DatosTarifario.otras_categorias_producto3;
                content.new_otrosservicios = DatosTarifario.otros_servicios_producto1 + " // " + DatosTarifario.otros_servicios_producto2 + " // " + DatosTarifario.otros_servicios_producto3;
                content.new_totaltransbordo = float.Parse(DatosTarifario.transbordo_total);
                content.new_proveedorcargosdestino = DatosTarifario.proveedor_cargos_destino1 + " // " + DatosTarifario.proveedor_cargos_destino2 + " // " + DatosTarifario.proveedor_cargos_destino3;
                content.new_totalcargosdestino = float.Parse(DatosTarifario.flete_cargo_destino);
                HttpContent httpContent = new StringContent(content.ToString(), UnicodeEncoding.UTF8, "application/json");
                HttpResponseMessage httpResponseMessage = await httpClient.PostAsync($"api/data/v9.2/{entityName}", httpContent);
                var response = httpResponseMessage.EnsureSuccessStatusCode();

                response2 = response.ToString();

                Console.WriteLine(response);
            }

            return response2;
        }

        private void clbCargosDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (clbCargosDestino.GetItemCheckState(clbCargosDestino.SelectedIndex) == CheckState.Checked)
            {
                if (!txtCargosD.Text.Equals(""))
                {
                    float monto = float.Parse(txtCargosD.Text);
                    float montonuevo = mCargosDestino[clbCargosDestino.SelectedIndex].Flete;
                    txtCargosD.Text = (monto + montonuevo).ToString();
                }
                else
                {
                    txtCargosD.Text = mCargosDestino[clbCargosDestino.SelectedIndex].Flete.ToString();
                }
            }
            else
            {
                if (!txtCargosD.Text.Equals("0") || !txtCargosD.Text.Equals(""))
                {
                    float monto = float.Parse(txtCargosD.Text);
                    float montonuevo = mCargosDestino[clbCargosDestino.SelectedIndex].Flete;
                    txtCargosD.Text = (monto - montonuevo).ToString();
                }
                else if (txtCargosD.Text.Equals("0"))
                {
                    txtCargosD.Text = "";
                }
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            cargarDatosGuardados();
            
            //Console.WriteLine(CreateAsync());
            if (mTarifariosConsulta.agregarTarifario(mTarifarios))
            {
                CreateAsync();
                MessageBox.Show("TARIFARIO CREADO");
            }
        }

        private void txtCargosD_TextChanged(object sender, EventArgs e)
        {
            if (!montov2.Equals("0"))
            {
                if (!txtCargosD.Text.Equals(montov2))
                {
                    float monto = float.Parse(txtTotalTarifario.Text);
                    float monto1 = float.Parse(txtCargosD.Text);
                    float monto2 = (monto - montoguardado2) + monto1;
                    txtTotalTarifario.Text = (monto2).ToString();
                    montoguardado2 = float.Parse(txtCargosD.Text);
                }
            }
            else
            {
                float monto = float.Parse(txtTotalTarifario.Text);
                float monto1 = float.Parse(txtCargosD.Text);
                montoguardado2 = float.Parse(txtCargosD.Text);
                txtTotalTarifario.Text = (monto + monto1).ToString();
            }
        }
    }
}
