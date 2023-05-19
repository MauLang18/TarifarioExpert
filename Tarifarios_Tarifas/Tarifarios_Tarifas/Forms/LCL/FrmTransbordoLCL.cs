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

namespace Tarifarios_Tarifas.Forms.LCL
{
    public partial class FrmTransbordoLCL : Form
    {
        private List<GastosPortuariosLCL> mGastosPortuarios;
        private GastosPortariosLCLConsultas mGastosPortuariosoConsultas;
        private List<MovimientoPuertoBodegaLCL> mMovimientoPuertoAlmacen;
        private MovimientoPuertoBodegaLCLConsultas mMovimientoPuertoAlmacenConsultas;
        private List<OtrasCategoriasLCL> mOtrasCategorias;
        private OtrasCategoriasLCLConsultas mOtrasCategoriasConsultas;
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
        public FrmTransbordoLCL()
        {
            InitializeComponent();
            mGastosPortuarios = new List<GastosPortuariosLCL>();
            mGastosPortuariosoConsultas = new GastosPortariosLCLConsultas();
            mMovimientoPuertoAlmacen = new List<MovimientoPuertoBodegaLCL>();
            mMovimientoPuertoAlmacenConsultas = new MovimientoPuertoBodegaLCLConsultas();
            mOtrasCategorias = new List<OtrasCategoriasLCL>();
            mOtrasCategoriasConsultas = new OtrasCategoriasLCLConsultas();

            var heightField = typeof(CheckedListBox).GetField("scaledListItemBordersHeight", BindingFlags.NonPublic | BindingFlags.Instance);

            var addedHeight = 30; // Some appropriate value, greater than the field's default of 2

            heightField.SetValue(clbOtrasCategorias, addedHeight);

            if (DatosTarifarioLCL.cargos_en_destino_proveedor != null)
            {
                cbxGastosPortuariosProveedor.Text = DatosTarifarioLCL.cargos_en_destino_proveedor;
                txtGastosPortuarios.Text = DatosTarifarioLCL.cargos_en_destino;
                cbxMovimientoPuertoBodegaProveedor.Text = DatosTarifarioLCL.movimiento_bodega_proveedor;
                txtMovimientoPuertoBodega.Text = DatosTarifarioLCL.movimiento_bodega;
                txtOtrasCategorias.Text = DatosTarifarioLCL.otras_categorias_total;
                txtTotalTransbordo.Text = DatosTarifarioLCL.transbordo_total;
                montoguardado4 = float.Parse(DatosTarifarioLCL.transbordo_total);
                cargarGastosPortuarios();
                cargarMovimientoPuertoBodega();
                cargarOtrasCategorias();
            }
            else
            {
                cargarGastosPortuarios();
                cargarMovimientoPuertoBodega();
                cargarOtrasCategorias();
            }
        }
        private void cargarGastosPortuarios()
        {
            cbxGastosPortuariosProveedor.Items.Clear();
            cbxGastosPortuariosProveedor.Refresh();
            mGastosPortuarios.Clear();
            mGastosPortuarios = mGastosPortuariosoConsultas.getGastosPortuarios(DatosTarifarioLCL.via);
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
            mMovimientoPuertoAlmacen = mMovimientoPuertoAlmacenConsultas.getMovimientoPuertoBodega(DatosTarifarioLCL.via);
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
            mOtrasCategorias = mOtrasCategoriasConsultas.getOtrasCategorias(DatosTarifarioLCL.via);
            for (int i = 0; i < mOtrasCategorias.Count; i++)
            {
                if (DatosTarifarioLCL.cargos_en_destino != null)
                {
                    if (mOtrasCategorias[i].Producto + " / " + mOtrasCategorias[i].Proveedor == DatosTarifarioLCL.otras_categorias_producto1 || mOtrasCategorias[i].Producto + " / " + mOtrasCategorias[i].Proveedor == DatosTarifarioLCL.otras_categorias_producto2 || mOtrasCategorias[i].Producto + " / " + mOtrasCategorias[i].Proveedor == DatosTarifarioLCL.otras_categorias_producto3)
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

        private void clbOtrasCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (clbOtrasCategorias.GetItemCheckState(clbOtrasCategorias.SelectedIndex) == CheckState.Checked)
            {
                if (!txtOtrasCategorias.Text.Equals(""))
                {
                    float monto = float.Parse(txtOtrasCategorias.Text);
                    float montonuevo = mOtrasCategorias[clbOtrasCategorias.SelectedIndex].Costo;
                    txtOtrasCategorias.Text = (monto + montonuevo).ToString();
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
                else if (txtOtrasCategorias.Text.Equals("0"))
                {
                    txtOtrasCategorias.Text = "";
                }
            }
        }

        private void cbxGastosPortuariosProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            montov = txtGastosPortuarios.Text;
            txtGastosPortuarios.Text = mGastosPortuarios[cbxGastosPortuariosProveedor.SelectedIndex].Cargos.ToString();
            DatosTarifarioLCL.id_cargos_en_destino = mGastosPortuarios[cbxGastosPortuariosProveedor.SelectedIndex].Id;
        }

        private void cbxMovimientoPuertoBodegaProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            montov1 = txtMovimientoPuertoBodega.Text;
            txtMovimientoPuertoBodega.Text = mMovimientoPuertoAlmacen[cbxMovimientoPuertoBodegaProveedor.SelectedIndex].Transporte_bodega.ToString();
            DatosTarifarioLCL.id_movimiento_bodega = mMovimientoPuertoAlmacen[cbxMovimientoPuertoBodegaProveedor.SelectedIndex].Id;
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

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (clbOtrasCategorias.SelectedIndex == -1)
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

            if (!montov3.Equals("0"))
            {
                if (!txtOtrasCategorias.Text.Equals(montov3))
                {
                    float monto = float.Parse(DatosTarifarioLCL.total_otros_costos_flat);
                    float monto1 = float.Parse(txtOtrasCategorias.Text);
                    float monto2 = (monto - montoguardado3) + monto1;
                    DatosTarifarioLCL.total_otros_costos_flat = (monto2).ToString();
                    montoguardado3 = float.Parse(txtOtrasCategorias.Text);
                }
            }
            else
            {
                float monto = float.Parse(DatosTarifarioLCL.total_otros_costos_flat);
                float monto1 = float.Parse(txtOtrasCategorias.Text);
                montoguardado3 = float.Parse(txtOtrasCategorias.Text);
                DatosTarifarioLCL.total_otros_costos_flat = (monto + monto1).ToString();
            }

            if (!montov4.Equals("0"))
            {
                if (!txtTotalTransbordo.Text.Equals(montov4))
                {
                    float monto = float.Parse(DatosTarifarioLCL.total_flete_cbm);
                    float monto1 = float.Parse(txtTotalTransbordo.Text);
                    float monto2 = (monto - montoguardado4) + monto1;
                    DatosTarifarioLCL.total_flete_cbm = (monto2).ToString();
                    montoguardado4 = float.Parse(txtTotalTransbordo.Text);
                }
            }
            else
            {
                float monto = float.Parse(DatosTarifarioLCL.total_flete_cbm);
                float monto1 = float.Parse(txtTotalTransbordo.Text);
                montoguardado4 = float.Parse(txtTotalTransbordo.Text);
                DatosTarifarioLCL.total_flete_cbm = (monto + monto1).ToString();
            }

            DatosTarifarioLCL.cargos_en_destino_proveedor = cbxGastosPortuariosProveedor.Text;
            DatosTarifarioLCL.cargos_en_destino = txtGastosPortuarios.Text;
            DatosTarifarioLCL.movimiento_bodega_proveedor = cbxMovimientoPuertoBodegaProveedor.Text;
            DatosTarifarioLCL.movimiento_bodega = txtMovimientoPuertoBodega.Text;
            DatosTarifarioLCL.otras_categorias_total = txtOtrasCategorias.Text;
            DatosTarifarioLCL.transbordo_total = txtTotalTransbordo.Text;
        }
    }
}
