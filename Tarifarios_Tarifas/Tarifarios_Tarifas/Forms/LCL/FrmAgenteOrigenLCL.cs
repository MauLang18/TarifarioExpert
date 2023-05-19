using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tarifarios_Tarifas.Globales;
using Tarifarios_Tarifas.Models.Atributos;
using Tarifarios_Tarifas.Models.Metodos;

namespace Tarifarios_Tarifas.Forms.LCL
{
    public partial class FrmAgenteOrigenLCL : Form
    {
        private List<AgenteOrigenLCL> mAgente;
        private AgenteOrigenLCLConsultas mAgenteConsultas;
        string montov = "";
        float montoguardado;
        public FrmAgenteOrigenLCL()
        {
            InitializeComponent();
            mAgente = new List<AgenteOrigenLCL>();
            mAgenteConsultas = new AgenteOrigenLCLConsultas();

            if (DatosTarifarioLCL.proveedor != null)
            {
                cbxProveedor.Text = DatosTarifarioLCL.proveedor;
                txtManejos.Text = DatosTarifarioLCL.manejos;
                txtHbl.Text = DatosTarifarioLCL.hbl;
                txtTotal.Text = DatosTarifarioLCL.total;
                montoguardado = float.Parse(DatosTarifarioLCL.total);
                cargarAgente();
            }
            else
            {
                cargarAgente();
            }
        }
        private void cargarAgente()
        {
            cbxProveedor.Items.Clear();
            cbxProveedor.Refresh();
            mAgente.Clear();
            mAgente = mAgenteConsultas.getAgenteOrigen(DatosTarifarioLCL.origen);
            for (int i = 0; i < mAgente.Count; i++)
            {
                cbxProveedor.Items.Add(mAgente[i].Proveedor);
            }
        }

        private void cbxProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            montov = txtTotal.Text;
            txtManejos.Text = mAgente[cbxProveedor.SelectedIndex].Manejos.ToString();
            txtHbl.Text = mAgente[cbxProveedor.SelectedIndex].Hbl.ToString();
            txtTotal.Text = (float.Parse(txtManejos.Text) + float.Parse(txtHbl.Text)).ToString();
            DatosTarifarioLCL.id_agente_origen = mAgente[cbxProveedor.SelectedIndex].Id;
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            DatosTarifarioLCL.proveedor = cbxProveedor.Text;
            DatosTarifarioLCL.manejos = txtManejos.Text;
            DatosTarifarioLCL.hbl = txtHbl.Text;
            DatosTarifarioLCL.total = txtTotal.Text;

            if (!montov.Equals("0"))
            {
                if (!txtTotal.Text.Equals(montov))
                {
                    float monto = float.Parse(DatosTarifarioLCL.total_otros_costos_flat);
                    float monto1 = float.Parse(txtTotal.Text);
                    float monto2 = (monto - montoguardado) + monto1;
                    DatosTarifarioLCL.total_otros_costos_flat = (monto2).ToString();
                    montoguardado = float.Parse(txtTotal.Text);
                }
            }
            else
            {
                float monto = float.Parse(DatosTarifarioLCL.total_otros_costos_flat);
                float monto1 = float.Parse(txtTotal.Text);
                montoguardado = float.Parse(txtTotal.Text);
                DatosTarifarioLCL.total_otros_costos_flat = (monto + monto1).ToString();
            }
        }
    }
}
