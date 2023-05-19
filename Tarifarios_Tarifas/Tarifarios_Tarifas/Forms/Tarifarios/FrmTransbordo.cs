using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tarifarios_Tarifas.Globales;
using Tarifarios_Tarifas.Models.Atributos;
using Tarifarios_Tarifas.Models.Metodos;

namespace Tarifarios_Tarifas.Forms.Tarifarios
{
    public partial class FrmTransbordo : Form
    {
        private List<GastosPortuarios> mGastosPortuarios;
        private GastosPortariosConsultas mGastosPortuariosoConsultas;
        private List<MovimientoPuertoBodega> mMovimientoPuertoAlmacen;
        private MovimientoPuertoBodegaConsultas mMovimientoPuertoAlmacenConsultas;
        private List<OtrasCategorias> mOtrasCategorias;
        private OtrasCategoriasConsultas mOtrasCategoriasConsultas;
        private List<OtroServicios> mOtrosServicios;
        private OtrosServiciosConsultas mOtrosServiciosConsultas;
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
        public FrmTransbordo()
        {
            InitializeComponent();
            mGastosPortuarios = new List<GastosPortuarios>();
            mGastosPortuariosoConsultas = new GastosPortariosConsultas();
            mMovimientoPuertoAlmacen = new List<MovimientoPuertoBodega>();
            mMovimientoPuertoAlmacenConsultas = new MovimientoPuertoBodegaConsultas();
            mOtrasCategorias = new List<OtrasCategorias>();
            mOtrasCategoriasConsultas = new OtrasCategoriasConsultas();
            mOtrosServicios = new List<OtroServicios>();
            mOtrosServiciosConsultas = new OtrosServiciosConsultas();

            var heightField = typeof(CheckedListBox).GetField("scaledListItemBordersHeight",BindingFlags.NonPublic | BindingFlags.Instance);

            var addedHeight = 30; // Some appropriate value, greater than the field's default of 2

            heightField.SetValue(clbOtrasCategorias, addedHeight);
            heightField.SetValue(clbOtrosServicios, addedHeight);

            if (DatosTarifario.gastos_portuarios_proveedor != null)
            {
                cbxGastosPortuariosProveedor.Text = DatosTarifario.gastos_portuarios_proveedor;
                txtGastosPortuarios.Text = DatosTarifario.gastos_portuarios;
                cbxMovimientoPuertoBodegaProveedor.Text = DatosTarifario.movimiento_puerto_bodega_proveedor;
                txtMovimientoPuertoBodega.Text = DatosTarifario.movimiento_puerto_bodega;
                txtOtrasCategorias.Text = DatosTarifario.otras_categorias_total;
                txtOtrosServicios.Text = DatosTarifario.otros_servicios_total;
                txtTotalTransbordo.Text = DatosTarifario.transbordo_total;
                montoguardado4 = float.Parse(DatosTarifario.transbordo_total);
                cargarGastosPortuarios();
                cargarMovimientoPuertoBodega();
                cargarOtrasCategorias();
                cargarOtrosServicios();
            }
            else
            {
                cargarGastosPortuarios();
                cargarMovimientoPuertoBodega();
                cargarOtrasCategorias();
                cargarOtrosServicios();
            }
        }
        private void cargarGastosPortuarios()
        {
            cbxGastosPortuariosProveedor.Items.Clear();
            cbxGastosPortuariosProveedor.Refresh();
            mGastosPortuarios.Clear();
            mGastosPortuarios = mGastosPortuariosoConsultas.getGastosPortuarios(DatosTarifario.via);
            for (int i = 0; i < mGastosPortuarios.Count; i++)
            {
                cbxGastosPortuariosProveedor.Items.Add(mGastosPortuarios[i].Proveedor);
            }
        }
        private void cargarMovimientoPuertoBodega()
        {
            cbxMovimientoPuertoBodegaProveedor.Items.Clear();
            cbxMovimientoPuertoBodegaProveedor.Refresh();
            mMovimientoPuertoAlmacen.Clear();
            mMovimientoPuertoAlmacen = mMovimientoPuertoAlmacenConsultas.getMovimientoPuertoBodega(DatosTarifario.via);
            for (int i = 0; i < mMovimientoPuertoAlmacen.Count; i++)
            {
                cbxMovimientoPuertoBodegaProveedor.Items.Add(mMovimientoPuertoAlmacen[i].Proveedor);
            }
        }
        private void cargarOtrasCategorias()
        {
            clbOtrasCategorias.Items.Clear();
            clbOtrasCategorias.Refresh();
            mOtrasCategorias.Clear();
            mOtrasCategorias = mOtrasCategoriasConsultas.getOtrasCategorias(DatosTarifario.via);
            for (int i = 0; i < mOtrasCategorias.Count; i++)
            {
                if (DatosTarifario.gastos_portuarios != null)
                {
                    if (mOtrasCategorias[i].Producto + " / " + mOtrasCategorias[i].Proveedor == DatosTarifario.otras_categorias_producto1 || mOtrasCategorias[i].Producto + " / " + mOtrasCategorias[i].Proveedor == DatosTarifario.otras_categorias_producto2 || mOtrasCategorias[i].Producto + " / " + mOtrasCategorias[i].Proveedor == DatosTarifario.otras_categorias_producto3)
                    {
                        clbOtrasCategorias.Items.Add(mOtrasCategorias[i].Producto + " / " + mOtrasCategorias[i].Proveedor, true);
                    }
                    else
                    {
                        clbOtrasCategorias.Items.Add(mOtrasCategorias[i].Producto + " / " + mOtrasCategorias[i].Proveedor);
                    }
                }
                else
                {
                    clbOtrasCategorias.Items.Add(mOtrasCategorias[i].Producto + " / " + mOtrasCategorias[i].Proveedor);
                }
            }
        }
        private void cargarOtrosServicios()
        {
            clbOtrosServicios.Items.Clear();
            clbOtrosServicios.Refresh();
            mOtrosServicios.Clear();
            mOtrosServicios = mOtrosServiciosConsultas.getOtrosServicios(DatosTarifario.via);
            for (int i = 0; i < mOtrosServicios.Count; i++)
            {
                if (DatosTarifario.gastos_portuarios != null)
                {
                    if (mOtrosServicios[i].Producto + " / " + mOtrosServicios[i].Proveedor == DatosTarifario.otros_servicios_producto1 || mOtrosServicios[i].Producto + " / " + mOtrosServicios[i].Proveedor == DatosTarifario.otros_servicios_producto2 || mOtrosServicios[i].Producto + " / " + mOtrosServicios[i].Proveedor == DatosTarifario.otros_servicios_producto3)
                    {
                        clbOtrosServicios.Items.Add(mOtrosServicios[i].Producto + " / " + mOtrosServicios[i].Proveedor, true);
                    }
                    else
                    {
                        clbOtrosServicios.Items.Add(mOtrosServicios[i].Producto + " / " + mOtrosServicios[i].Proveedor);
                    }
                }
                else
                {
                    clbOtrosServicios.Items.Add(mOtrosServicios[i].Producto + " / " + mOtrosServicios[i].Proveedor);
                }
            }
        }

        private void clbOtrosServicios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (clbOtrosServicios.GetItemCheckState(clbOtrosServicios.SelectedIndex) == CheckState.Checked)
            {
                if (!txtOtrasCategorias.Text.Equals(""))
                {
                    float monto = float.Parse(txtOtrosServicios.Text);
                    float montonuevo = mOtrosServicios[clbOtrosServicios.SelectedIndex].Costo;
                    txtOtrosServicios.Text = (monto + montonuevo).ToString();
                }
                else
                {
                    txtOtrosServicios.Text = mOtrosServicios[clbOtrosServicios.SelectedIndex].Costo.ToString();
                }
            }
            else
            {
                if (!txtOtrosServicios.Text.Equals("0") || !txtOtrosServicios.Text.Equals(""))
                {
                    float monto = float.Parse(txtOtrosServicios.Text);
                    float montonuevo = mOtrosServicios[clbOtrosServicios.SelectedIndex].Costo;
                    txtOtrosServicios.Text = (monto - montonuevo).ToString();
                }
                else if (txtOtrosServicios.Text.Equals("0"))
                {
                    txtOtrosServicios.Text = "";
                }
            }
        }

        private void clbOtrasCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (clbOtrasCategorias.GetItemCheckState(clbOtrasCategorias.SelectedIndex) == CheckState.Checked)
            {
                if (!txtOtrasCategorias.Text.Equals(""))
                {
                    float monto = float.Parse(txtOtrasCategorias.Text);
                    float montonuevo = mOtrasCategorias[clbOtrasCategorias.SelectedIndex].Costo;
                    txtOtrasCategorias.Text = (monto+montonuevo).ToString();
                }
                else
                {
                    txtOtrasCategorias.Text = mOtrasCategorias[clbOtrasCategorias.SelectedIndex].Costo.ToString();
                }
            }
            else
            {
                if (!txtOtrasCategorias.Text.Equals("0") || !txtOtrasCategorias.Text.Equals(""))
                {
                    float monto = float.Parse(txtOtrasCategorias.Text);
                    float montonuevo = mOtrasCategorias[clbOtrasCategorias.SelectedIndex].Costo;
                    txtOtrasCategorias.Text = (monto - montonuevo).ToString();
                }
                else if(txtOtrasCategorias.Text.Equals("0"))
                {
                    txtOtrasCategorias.Text = "";
                }
            }
        }

        private void cbxGastosPortuariosProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            montov = txtGastosPortuarios.Text;
            txtGastosPortuarios.Text = mGastosPortuarios[cbxGastosPortuariosProveedor.SelectedIndex].Manejos_pueto.ToString();
            DatosTarifario.id_gastos_portuarios = mGastosPortuarios[cbxGastosPortuariosProveedor.SelectedIndex].Id;
        }

        private void cbxMovimientoPuertoBodegaProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            montov1 = txtMovimientoPuertoBodega.Text;
            txtMovimientoPuertoBodega.Text = mMovimientoPuertoAlmacen[cbxMovimientoPuertoBodegaProveedor.SelectedIndex].Transporte_puerto.ToString();
            DatosTarifario.id_movimiento_puerto_bodega = mMovimientoPuertoAlmacen[cbxMovimientoPuertoBodegaProveedor.SelectedIndex].Id;
        }

        private void txtGastosPortuarios_TextChanged(object sender, EventArgs e)
        {
            if (!montov.Equals("0"))
            {
                if (!txtGastosPortuarios.Text.Equals(montov))
                {
                    float monto = float.Parse(txtTotalTransbordo.Text);
                    float monto1 = float.Parse(txtGastosPortuarios.Text);
                    float monto2 = (monto - montoguardado) + monto1;
                    txtTotalTransbordo.Text = (monto2).ToString();
                    montoguardado = float.Parse(txtGastosPortuarios.Text);
                }
            }
            else
            {
                float monto = float.Parse(txtTotalTransbordo.Text);
                float monto1 = float.Parse(txtGastosPortuarios.Text);
                montoguardado = float.Parse(txtGastosPortuarios.Text);
                txtTotalTransbordo.Text = (monto + monto1).ToString();
            }
        }

        private void txtMovimientoPuertoBodega_TextChanged(object sender, EventArgs e)
        {
            if (!montov1.Equals("0"))
            {
                if (!txtMovimientoPuertoBodega.Text.Equals(montov1))
                {
                    float monto = float.Parse(txtTotalTransbordo.Text);
                    float monto1 = float.Parse(txtMovimientoPuertoBodega.Text);
                    float monto2 = (monto - montoguardado1) + monto1;
                    txtTotalTransbordo.Text = (monto2).ToString();
                    montoguardado1 = float.Parse(txtMovimientoPuertoBodega.Text);
                }
            }
            else
            {
                float monto = float.Parse(txtTotalTransbordo.Text);
                float monto1 = float.Parse(txtMovimientoPuertoBodega.Text);
                montoguardado1 = float.Parse(txtMovimientoPuertoBodega.Text);
                txtTotalTransbordo.Text = (monto + monto1).ToString();
            }
        }

        private void txtOtrasCategorias_TextChanged(object sender, EventArgs e)
        {
            if (!montov2.Equals("0"))
            {
                if (!txtOtrasCategorias.Text.Equals(montov2))
                {
                    float monto = float.Parse(txtTotalTransbordo.Text);
                    float monto1 = float.Parse(txtOtrasCategorias.Text);
                    float monto2 = (monto - montoguardado2) + monto1;
                    txtTotalTransbordo.Text = (monto2).ToString();
                    montoguardado2 = float.Parse(txtOtrasCategorias.Text);
                }
            }
            else
            {
                float monto = float.Parse(txtTotalTransbordo.Text);
                float monto1 = float.Parse(txtOtrasCategorias.Text);
                montoguardado2 = float.Parse(txtOtrasCategorias.Text);
                txtTotalTransbordo.Text = (monto + monto1).ToString();
            }
        }

        private void txtOtrosServicios_TextChanged(object sender, EventArgs e)
        {
            if (!montov3.Equals("0"))
            {
                if (!txtOtrosServicios.Text.Equals(montov3))
                {
                    float monto = float.Parse(txtTotalTransbordo.Text);
                    float monto1 = float.Parse(txtOtrosServicios.Text);
                    float monto2 = (monto - montoguardado3) + monto1;
                    txtTotalTransbordo.Text = (monto2).ToString();
                    montoguardado3 = float.Parse(txtOtrosServicios.Text);
                }
            }
            else
            {
                float monto = float.Parse(txtTotalTransbordo.Text);
                float monto1 = float.Parse(txtOtrosServicios.Text);
                montoguardado3 = float.Parse(txtOtrosServicios.Text);
                txtTotalTransbordo.Text = (monto + monto1).ToString();
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {

            if(clbOtrasCategorias.SelectedIndex == -1)
            {
                if (DatosTarifario.otras_categorias_producto1 == null || DatosTarifario.otras_categorias_producto1 == "")
                {
                    DatosTarifario.otras_categorias_producto1 = clbOtrasCategorias.Text;
                    DatosTarifario.id_otras_categorias1 = 1;
                }
                else if (DatosTarifario.otras_categorias_producto2 == null || DatosTarifario.otras_categorias_producto2 == "")
                {
                    DatosTarifario.otras_categorias_producto2 = clbOtrasCategorias.Text;
                    DatosTarifario.id_otras_categorias2 = 1;
                }
                else if (DatosTarifario.otras_categorias_producto3 == null || DatosTarifario.otras_categorias_producto3 == "")
                {
                    DatosTarifario.otras_categorias_producto3 = clbOtrasCategorias.Text;
                    DatosTarifario.id_otras_categorias3 = 1;
                }
            }
            else
            {
                if (clbOtrasCategorias.GetItemCheckState(clbOtrasCategorias.SelectedIndex) == CheckState.Checked)
                {
                    if ((DatosTarifario.otras_categorias_producto1 == null || DatosTarifario.otras_categorias_producto1 == "") && (DatosTarifario.otras_categorias_producto1 != clbOtrasCategorias.Text && DatosTarifario.otras_categorias_producto2 != clbOtrasCategorias.Text && DatosTarifario.otras_categorias_producto3 != clbOtrasCategorias.Text))
                    {
                        DatosTarifario.otras_categorias_producto1 = clbOtrasCategorias.Text;
                        DatosTarifario.id_otras_categorias1 = mOtrasCategorias[clbOtrasCategorias.SelectedIndex].Id;
                    }
                    else if ((DatosTarifario.otras_categorias_producto2 == null || DatosTarifario.otras_categorias_producto2 == "") && (DatosTarifario.otras_categorias_producto1 != clbOtrasCategorias.Text && DatosTarifario.otras_categorias_producto2 != clbOtrasCategorias.Text && DatosTarifario.otras_categorias_producto3 != clbOtrasCategorias.Text))
                    {
                        DatosTarifario.otras_categorias_producto2 = clbOtrasCategorias.Text;
                        DatosTarifario.id_otras_categorias2 = mOtrasCategorias[clbOtrasCategorias.SelectedIndex].Id;
                    }
                    else if ((DatosTarifario.otras_categorias_producto3 == null || DatosTarifario.otras_categorias_producto3 == "") && (DatosTarifario.otras_categorias_producto1 != clbOtrasCategorias.Text && DatosTarifario.otras_categorias_producto2 != clbOtrasCategorias.Text && DatosTarifario.otras_categorias_producto3 != clbOtrasCategorias.Text))
                    {
                        DatosTarifario.otras_categorias_producto3 = clbOtrasCategorias.Text;
                        DatosTarifario.id_otras_categorias3 = mOtrasCategorias[clbOtrasCategorias.SelectedIndex].Id;
                    }
                }
                else
                {
                    if ((DatosTarifario.otras_categorias_producto1 != null || DatosTarifario.otras_categorias_producto1 != "") && DatosTarifario.otras_categorias_producto1 == clbOtrasCategorias.Text)
                    {
                        DatosTarifario.otras_categorias_producto1 = "";
                        DatosTarifario.id_otras_categorias1 = 1;
                    }
                    else if ((DatosTarifario.otras_categorias_producto2 != null || DatosTarifario.otras_categorias_producto2 != "") && DatosTarifario.otras_categorias_producto2 == clbOtrasCategorias.Text)
                    {
                        DatosTarifario.otras_categorias_producto2 = "";
                        DatosTarifario.id_otras_categorias2 = 1;
                    }
                    else if ((DatosTarifario.otras_categorias_producto3 != null || DatosTarifario.otras_categorias_producto3 != "") && DatosTarifario.otras_categorias_producto3 == clbOtrasCategorias.Text)
                    {
                        DatosTarifario.otras_categorias_producto3 = "";
                        DatosTarifario.id_otras_categorias3 = 1;
                    }
                }
            }

            if (clbOtrosServicios.SelectedIndex == -1)
            {
                if (DatosTarifario.otros_servicios_producto1 == null || DatosTarifario.otros_servicios_producto1 == "")
                {
                    DatosTarifario.otros_servicios_producto1 = clbOtrosServicios.Text;
                    DatosTarifario.id_otros_servicios1 = 1;
                }
                else if (DatosTarifario.otros_servicios_producto2 == null || DatosTarifario.otros_servicios_producto2 == "")
                {
                    DatosTarifario.otros_servicios_producto2 = clbOtrosServicios.Text;
                    DatosTarifario.id_otros_servicios2 = 1;
                }
                else if (DatosTarifario.otros_servicios_producto3 == null || DatosTarifario.otros_servicios_producto3 == "")
                {
                    DatosTarifario.otros_servicios_producto3 = clbOtrosServicios.Text;
                    DatosTarifario.id_otros_servicios3 = 1;
                }
            }
            else
            {
                if (clbOtrosServicios.GetItemCheckState(clbOtrosServicios.SelectedIndex) == CheckState.Checked)
                {
                    if ((DatosTarifario.otros_servicios_producto1 == null || DatosTarifario.otros_servicios_producto1 == "") && (DatosTarifario.otros_servicios_producto1 != clbOtrosServicios.Text && DatosTarifario.otros_servicios_producto2 != clbOtrosServicios.Text && DatosTarifario.otros_servicios_producto3 != clbOtrosServicios.Text))
                    {
                        DatosTarifario.otros_servicios_producto1 = clbOtrosServicios.Text;
                        DatosTarifario.id_otros_servicios1 = mOtrosServicios[clbOtrosServicios.SelectedIndex].Id;
                    }
                    else if ((DatosTarifario.otros_servicios_producto2 == null || DatosTarifario.otros_servicios_producto2 == "") && (DatosTarifario.otros_servicios_producto1 != clbOtrosServicios.Text && DatosTarifario.otros_servicios_producto2 != clbOtrosServicios.Text && DatosTarifario.otros_servicios_producto3 != clbOtrosServicios.Text))
                    {
                        DatosTarifario.otros_servicios_producto2 = clbOtrosServicios.Text;
                        DatosTarifario.id_otros_servicios2 = mOtrosServicios[clbOtrosServicios.SelectedIndex].Id;
                    }
                    else if ((DatosTarifario.otros_servicios_producto3 == null || DatosTarifario.otros_servicios_producto3 == "") && (DatosTarifario.otros_servicios_producto1 != clbOtrosServicios.Text && DatosTarifario.otros_servicios_producto2 != clbOtrosServicios.Text && DatosTarifario.otros_servicios_producto3 != clbOtrosServicios.Text))
                    {
                        DatosTarifario.otros_servicios_producto3 = clbOtrosServicios.Text;
                        DatosTarifario.id_otros_servicios3 = mOtrosServicios[clbOtrosServicios.SelectedIndex].Id;
                    }
                }
                else
                {
                    if ((DatosTarifario.otros_servicios_producto1 != null || DatosTarifario.otros_servicios_producto1 != "") && DatosTarifario.otros_servicios_producto1 == clbOtrosServicios.Text)
                    {
                        DatosTarifario.otros_servicios_producto1 = "";
                        DatosTarifario.id_otros_servicios1 = 1;
                    }
                    else if ((DatosTarifario.otros_servicios_producto2 != null || DatosTarifario.otros_servicios_producto2 != "") && DatosTarifario.otros_servicios_producto2 == clbOtrosServicios.Text)
                    {
                        DatosTarifario.otros_servicios_producto2 = "";
                        DatosTarifario.id_otros_servicios2 = 1;
                    }
                    else if ((DatosTarifario.otros_servicios_producto3 != null || DatosTarifario.otros_servicios_producto3 != "") && DatosTarifario.otros_servicios_producto3 == clbOtrosServicios.Text)
                    {
                        DatosTarifario.otros_servicios_producto3 = "";
                        DatosTarifario.id_otros_servicios3 = 1;
                    }
                }
            }

            if (!montov4.Equals("0"))
            {
                if (!txtTotalTransbordo.Text.Equals(montov4))
                {
                    float monto = float.Parse(DatosTarifario.TotalTarifario);
                    float monto1 = float.Parse(txtTotalTransbordo.Text);
                    float monto2 = (monto - montoguardado4) + monto1;
                    DatosTarifario.TotalTarifario = (monto2).ToString();
                    montoguardado4 = float.Parse(txtTotalTransbordo.Text);
                }
            }
            else
            {
                float monto = float.Parse(DatosTarifario.TotalTarifario);
                float monto1 = float.Parse(txtTotalTransbordo.Text);
                montoguardado4 = float.Parse(txtTotalTransbordo.Text);
                DatosTarifario.TotalTarifario = (monto + monto1).ToString();
            }

            DatosTarifario.gastos_portuarios_proveedor = cbxGastosPortuariosProveedor.Text;
            DatosTarifario.gastos_portuarios = txtGastosPortuarios.Text;
            DatosTarifario.movimiento_puerto_bodega_proveedor = cbxMovimientoPuertoBodegaProveedor.Text;
            DatosTarifario.movimiento_puerto_bodega = txtMovimientoPuertoBodega.Text;
            DatosTarifario.otras_categorias_total = txtOtrasCategorias.Text;
            DatosTarifario.otros_servicios_total = txtOtrosServicios.Text;
            DatosTarifario.transbordo_total = txtTotalTransbordo.Text;
        }
    }
}
