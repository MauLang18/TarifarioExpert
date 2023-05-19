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
    public partial class FrmCargosDestinoLCL : Form
    {
        private List<CargosDestinoLCL> mCargosDestino;
        //private COMPETIDORES mTarifarios;
        private CargosDestinoLCLConsultas mCargosDestinoConsultas;
        //private CompetidoresConsultas mTarifariosConsulta;
        string montov4 = "";
        float montoguardado4 = 0;
        public FrmCargosDestinoLCL()
        {
            InitializeComponent();
            mCargosDestino = new List<CargosDestinoLCL>();
            mCargosDestinoConsultas = new CargosDestinoLCLConsultas();
            //mTarifarios = new COMPETIDORES();
            //mTarifariosConsulta = new CompetidoresConsultas();

            var heightField = typeof(CheckedListBox).GetField("scaledListItemBordersHeight", BindingFlags.NonPublic | BindingFlags.Instance);

            var addedHeight = 30; // Some appropriate value, greater than the field's default of 2

            heightField.SetValue(clbCargosDestino, addedHeight);

            if (DatosTarifarioLCL.flete_cargo_destino != null)
            {
                txtCargosD.Text = DatosTarifarioLCL.flete_cargo_destino;
                montoguardado4 = float.Parse(DatosTarifarioLCL.flete_cargo_destino);
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
            mCargosDestino = mCargosDestinoConsultas.getCargosDestino(DatosTarifarioLCL.destino, DatosTarifarioLCL.via);
            for (int i = 0; i < mCargosDestino.Count; i++)
            {
                if (DatosTarifarioLCL.flete_cargo_destino != null)
                {
                    if (mCargosDestino[i].Proveedor == DatosTarifarioLCL.proveedor_cargos_destino1 || mCargosDestino[i].Proveedor == DatosTarifarioLCL.proveedor_cargos_destino2 || mCargosDestino[i].Proveedor == DatosTarifarioLCL.proveedor_cargos_destino3)
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (clbCargosDestino.SelectedIndex == -1)
            {
                if (DatosTarifarioLCL.proveedor_cargos_destino1 == null || DatosTarifarioLCL.proveedor_cargos_destino1 == "")
                {
                    DatosTarifarioLCL.proveedor_cargos_destino1 = clbCargosDestino.Text;
                    DatosTarifarioLCL.id_cargos_destino1 = 1;
                }
                if (DatosTarifarioLCL.proveedor_cargos_destino2 == null || DatosTarifarioLCL.proveedor_cargos_destino2 == "")
                {
                    DatosTarifarioLCL.proveedor_cargos_destino2 = clbCargosDestino.Text;
                    DatosTarifarioLCL.id_cargos_destino2 = 1;
                }
                else if (DatosTarifarioLCL.proveedor_cargos_destino3 == null || DatosTarifarioLCL.proveedor_cargos_destino3 == "")
                {
                    DatosTarifarioLCL.proveedor_cargos_destino3 = clbCargosDestino.Text;
                    DatosTarifarioLCL.id_cargos_destino3 = 1;
                }
            }
            else
            {
                if (clbCargosDestino.GetItemCheckState(clbCargosDestino.SelectedIndex) == CheckState.Checked)
                {
                    if ((DatosTarifarioLCL.proveedor_cargos_destino1 == null || DatosTarifarioLCL.proveedor_cargos_destino1 == "") && (DatosTarifarioLCL.proveedor_cargos_destino1 != clbCargosDestino.Text && DatosTarifarioLCL.proveedor_cargos_destino2 != clbCargosDestino.Text && DatosTarifarioLCL.proveedor_cargos_destino3 != clbCargosDestino.Text))
                    {
                        DatosTarifarioLCL.proveedor_cargos_destino1 = clbCargosDestino.Text;
                        DatosTarifarioLCL.id_cargos_destino1 = mCargosDestino[clbCargosDestino.SelectedIndex].Id;
                    }
                    else if ((DatosTarifarioLCL.proveedor_cargos_destino2 == null || DatosTarifarioLCL.proveedor_cargos_destino2 == "") && (DatosTarifarioLCL.proveedor_cargos_destino1 != clbCargosDestino.Text && DatosTarifarioLCL.proveedor_cargos_destino2 != clbCargosDestino.Text && DatosTarifarioLCL.proveedor_cargos_destino3 != clbCargosDestino.Text))
                    {
                        DatosTarifarioLCL.proveedor_cargos_destino2 = clbCargosDestino.Text;
                        DatosTarifarioLCL.id_cargos_destino2 = mCargosDestino[clbCargosDestino.SelectedIndex].Id;
                    }
                    else if ((DatosTarifarioLCL.proveedor_cargos_destino3 == null || DatosTarifarioLCL.proveedor_cargos_destino3 == "") && (DatosTarifarioLCL.proveedor_cargos_destino1 != clbCargosDestino.Text && DatosTarifarioLCL.proveedor_cargos_destino2 != clbCargosDestino.Text && DatosTarifarioLCL.proveedor_cargos_destino3 != clbCargosDestino.Text))
                    {
                        DatosTarifarioLCL.proveedor_cargos_destino3 = clbCargosDestino.Text;
                        DatosTarifarioLCL.id_cargos_destino3 = mCargosDestino[clbCargosDestino.SelectedIndex].Id;
                    }
                }
                else
                {
                    if ((DatosTarifarioLCL.proveedor_cargos_destino1 != null || DatosTarifarioLCL.proveedor_cargos_destino1 != "") && DatosTarifarioLCL.proveedor_cargos_destino1 == clbCargosDestino.Text)
                    {
                        DatosTarifarioLCL.otras_categorias_producto1 = "";
                        DatosTarifarioLCL.id_cargos_destino1 = 1;
                    }
                    else if ((DatosTarifarioLCL.proveedor_cargos_destino2 != null || DatosTarifarioLCL.proveedor_cargos_destino2 != "") && DatosTarifarioLCL.proveedor_cargos_destino2 == clbCargosDestino.Text)
                    {
                        DatosTarifarioLCL.proveedor_cargos_destino2 = "";
                        DatosTarifarioLCL.id_cargos_destino2 = 1;
                    }
                    else if ((DatosTarifarioLCL.proveedor_cargos_destino3 != null || DatosTarifarioLCL.proveedor_cargos_destino3 != "") && DatosTarifarioLCL.proveedor_cargos_destino3 == clbCargosDestino.Text)
                    {
                        DatosTarifarioLCL.proveedor_cargos_destino3 = "";
                        DatosTarifarioLCL.id_cargos_destino3 = 1;
                    }
                }
            }

            if (!montov4.Equals("0"))
            {
                if (!txtCargosD.Text.Equals(montov4))
                {
                    float monto = float.Parse(DatosTarifarioLCL.total_flete_cbm);
                    float monto1 = float.Parse(txtCargosD.Text);
                    float monto2 = (monto - montoguardado4) + monto1;
                    DatosTarifarioLCL.total_flete_cbm = (monto2).ToString();
                    montoguardado4 = float.Parse(txtCargosD.Text);
                }
            }
            else
            {
                float monto = float.Parse(DatosTarifarioLCL.total_flete_cbm);
                float monto1 = float.Parse(txtCargosD.Text);
                montoguardado4 = float.Parse(txtCargosD.Text);
                DatosTarifarioLCL.total_flete_cbm = (monto + monto1).ToString();
            }

            DatosTarifarioLCL.flete_cargo_destino = txtCargosD.Text;
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
    }
}
