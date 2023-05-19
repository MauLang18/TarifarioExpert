using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tarifarios_Tarifas.Globales;
using Tarifarios_Tarifas.Models.Atributos;
using Tarifarios_Tarifas.Models.Metodos;

namespace Tarifarios_Tarifas.Forms.Tarifarios
{
    public partial class FrmAgenteOrigen : Form
    {
        private List<AgenteOrigen> mAgente;
        private AgenteOrigenConsultas mAgenteConsultas;
        string montov = "";
        float montoguardado;
        public FrmAgenteOrigen()
        {
            InitializeComponent();
            mAgente = new List<AgenteOrigen>();
            mAgenteConsultas = new AgenteOrigenConsultas();
            
            if(DatosTarifario.proveedor != null)
            {
                cbxProveedor.Text = DatosTarifario.proveedor;
                txtManejos.Text = DatosTarifario.manejos;
                txtHbl.Text = DatosTarifario.hbl;
                txtTotal.Text = DatosTarifario.total;
                montoguardado = float.Parse(DatosTarifario.total);
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
            mAgente = mAgenteConsultas.getAgenteOrigen(DatosTarifario.origen);
            for (int i = 0; i < mAgente.Count; i++)
            {
                cbxProveedor.Items.Add(mAgente[i].Proveedor);
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            DatosTarifario.proveedor = cbxProveedor.Text;
            DatosTarifario.manejos = txtManejos.Text;
            DatosTarifario.hbl = txtHbl.Text;
            DatosTarifario.total = txtTotal.Text;

            if (!montov.Equals("0"))
            {
                if (!txtTotal.Text.Equals(montov))
                {
                    float monto = float.Parse(DatosTarifario.TotalTarifario);
                    float monto1 = float.Parse(txtTotal.Text);
                    float monto2 = (monto - montoguardado) + monto1;
                    DatosTarifario.TotalTarifario= (monto2).ToString();
                    montoguardado = float.Parse(txtTotal.Text);
                }
            }
            else
            {
                float monto = float.Parse(DatosTarifario.TotalTarifario);
                float monto1 = float.Parse(txtTotal.Text);
                montoguardado = float.Parse(txtTotal.Text);
                DatosTarifario.TotalTarifario = (monto + monto1).ToString();
            }
        }

        private void cbxProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            montov = txtTotal.Text;
            txtManejos.Text = mAgente[cbxProveedor.SelectedIndex].Manejos.ToString();
            txtHbl.Text = mAgente[cbxProveedor.SelectedIndex].Hbl.ToString();
            txtTotal.Text = (float.Parse(txtManejos.Text) + float.Parse(txtHbl.Text)).ToString();
            DatosTarifario.id_agente_origen = mAgente[cbxProveedor.SelectedIndex].Id;
        }
    }
}
