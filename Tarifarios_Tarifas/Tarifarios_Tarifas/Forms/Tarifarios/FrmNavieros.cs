using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tarifarios_Tarifas.Globales;
using Tarifarios_Tarifas.Models.Atributos;
using Tarifarios_Tarifas.Models.Metodos;

namespace Tarifarios_Tarifas.Forms.Tarifarios
{
    public partial class FrmNavieros : Form
    {
        private List<Naviero> mNaviero;
        private NavieroConsultas mNavieroConsultas;
        string montov = "";
        float montoguardado;
        string montov1 = "";
        float montoguardado1;
        string montov2 = "";
        float montoguardado2;
        public FrmNavieros()
        {
            InitializeComponent();
            mNaviero = new List<Naviero>();
            mNavieroConsultas = new NavieroConsultas();

            if(DatosTarifario.naviero != null)
            {
                cbxNaviero.Text = DatosTarifario.naviero;
                txtTHC.Text = DatosTarifario.thc;
                cbxNaviero.Text = DatosTarifario.naviero;
                txtTHC.Text = DatosTarifario.thc;
                txtDocFee.Text = DatosTarifario.doc_fee;
                txtSecurity.Text = DatosTarifario.security;
                txtImpresionBL.Text = DatosTarifario.impresion_bl;
                txtPortFacility.Text = DatosTarifario.port_facility;
                txtCanalFee.Text = DatosTarifario.canal_fee;
                txtVAC.Text = DatosTarifario.vac;
                txtImpdo.Text = DatosTarifario.impdoc;
                txtMerchant.Text = DatosTarifario.merchant;
                txtTotalCostos.Text = DatosTarifario.total_cargos_destino;
                txtFlete.Text = DatosTarifario.flete;
                txtTotalFlete.Text = DatosTarifario.total_flete;
                montoguardado = float.Parse(DatosTarifario.total_flete);
                if (DatosTarifario.flete != null || DatosTarifario.flete != "0")
                {
                    montoguardado1 = float.Parse(DatosTarifario.flete);
                }
                else
                {
                    montoguardado1 = 0;
                }
                if (DatosTarifario.total_cargos_destino != null || DatosTarifario.total_cargos_destino != "0")
                {
                    montoguardado2 = float.Parse(DatosTarifario.total_cargos_destino);
                }
                else
                {
                    montoguardado2 = 0;
                }
                
                cargarNaviero();
            }
            else
            {
                cargarNaviero();
            }
        }
        private void cargarNaviero()
        {
            cbxNaviero.Items.Clear();
            cbxNaviero.Refresh();
            mNaviero.Clear();
            mNaviero = mNavieroConsultas.GetNaviero(DatosTarifario.origen, DatosTarifario.via);
            for (int i = 0; i < mNaviero.Count; i++)
            {
                cbxNaviero.Items.Add(mNaviero[i].Proveedor);
            }
        }

        private void cbxNaviero_SelectedIndexChanged(object sender, EventArgs e)
        {
            montov2 = txtTotalCostos.Text;
            txtTHC.Text = mNaviero[cbxNaviero.SelectedIndex].Thc.ToString();
            txtDocFee.Text = mNaviero[cbxNaviero.SelectedIndex].Doc_fee.ToString();
            txtSecurity.Text = mNaviero[cbxNaviero.SelectedIndex].Security.ToString();
            txtImpresionBL.Text = mNaviero[cbxNaviero.SelectedIndex].Impresion_bl.ToString();
            txtPortFacility.Text = mNaviero[cbxNaviero.SelectedIndex].Port_facility.ToString();
            txtCanalFee.Text = mNaviero[cbxNaviero.SelectedIndex].Canal_fee.ToString();
            txtVAC.Text = mNaviero[cbxNaviero.SelectedIndex].Vac.ToString();
            txtImpdo.Text = mNaviero[cbxNaviero.SelectedIndex].Impdo.ToString();
            txtMerchant.Text = mNaviero[cbxNaviero.SelectedIndex].Merchant.ToString();
            var a = (float.Parse(txtTHC.Text) + float.Parse(txtDocFee.Text) + float.Parse(txtSecurity.Text) + float.Parse(txtImpresionBL.Text) + float.Parse(txtPortFacility.Text) + float.Parse(txtCanalFee.Text) + float.Parse(txtVAC.Text) + float.Parse(txtImpdo.Text) + float.Parse(txtMerchant.Text));
            txtTotalCostos.Text = a.ToString();
            DatosTarifario.id_naviero = mNaviero[cbxNaviero.SelectedIndex].Id;
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            DatosTarifario.naviero = cbxNaviero.Text;
            DatosTarifario.thc = txtTHC.Text;
            DatosTarifario.naviero = cbxNaviero.Text;
            DatosTarifario.thc = txtTHC.Text;
            DatosTarifario.doc_fee = txtDocFee.Text;
            DatosTarifario.security = txtSecurity.Text;
            DatosTarifario.impresion_bl = txtImpresionBL.Text;
            DatosTarifario.port_facility = txtPortFacility.Text;
            DatosTarifario.canal_fee = txtCanalFee.Text;
            DatosTarifario.vac = txtVAC.Text;
            DatosTarifario.impdoc = txtImpdo.Text;
            DatosTarifario.merchant = txtMerchant.Text;
            DatosTarifario.total_cargos_destino = txtTotalCostos.Text;
            DatosTarifario.flete = txtFlete.Text;
            DatosTarifario.total_flete = txtTotalFlete.Text;

            if (!montov.Equals("0"))
            {
                if (!txtTotalFlete.Text.Equals(montov))
                {
                    float monto = float.Parse(DatosTarifario.TotalTarifario);
                    float monto1 = float.Parse(txtTotalFlete.Text);
                    float monto2 = (monto - montoguardado) + monto1;
                    DatosTarifario.TotalTarifario = (monto2).ToString();
                    montoguardado = float.Parse(txtTotalFlete.Text);
                }
            }
            else
            {
                float monto = float.Parse(DatosTarifario.TotalTarifario);
                float monto1 = float.Parse(txtTotalFlete.Text);
                montoguardado = float.Parse(txtTotalFlete.Text);
                DatosTarifario.TotalTarifario = (monto + monto1).ToString();
            }
        }

        private void txtFlete_TextChanged(object sender, EventArgs e)
        {
            if (!montov1.Equals("0"))
            {
                if (!txtFlete.Text.Equals(montov1))
                {
                    float monto = float.Parse(txtTotalFlete.Text);
                    float monto1 = float.Parse(txtFlete.Text);
                    float monto2 = (monto - montoguardado1) + monto1;
                    txtTotalFlete.Text = (monto2).ToString();
                    montoguardado1 = float.Parse(txtFlete.Text);
                }
            }
            else
            {
                float monto = float.Parse(txtTotalFlete.Text);
                float monto1 = float.Parse(txtFlete.Text);
                montoguardado1 = float.Parse(txtFlete.Text);
                txtTotalFlete.Text = (monto + monto1).ToString();
            }
        }

        private void txtTotalCostos_TextChanged(object sender, EventArgs e)
        {
            if (!montov2.Equals("0"))
            {
                if (!txtFlete.Text.Equals(montov2))
                {
                    float monto = float.Parse(txtTotalFlete.Text);
                    float monto1 = float.Parse(txtTotalCostos.Text);
                    float monto2 = (monto - montoguardado2) + monto1;
                    txtTotalFlete.Text = (monto2).ToString();
                    montoguardado2 = float.Parse(txtTotalCostos.Text);
                }
            }
            else
            {
                float monto = float.Parse(txtTotalFlete.Text);
                float monto1 = float.Parse(txtTotalCostos.Text);
                montoguardado2 = float.Parse(txtTotalCostos.Text);
                txtTotalFlete.Text = (monto + monto1).ToString();
            }
        }
    }
}
