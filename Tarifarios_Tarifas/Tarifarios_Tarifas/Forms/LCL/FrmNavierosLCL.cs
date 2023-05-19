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
    public partial class FrmNavierosLCL : Form
    {
        private List<NavieroLCL> mNaviero;
        private NavieroLCLConsultas mNavieroConsultas;
        public FrmNavierosLCL()
        {
            InitializeComponent();
            mNaviero = new List<NavieroLCL>();
            mNavieroConsultas = new NavieroLCLConsultas();

            if (DatosTarifarioLCL.naviero != null)
            {
                cbxNaviero.Text = DatosTarifarioLCL.naviero;
                txtTHC.Text = DatosTarifarioLCL.thc;
                txtDocFee.Text = DatosTarifarioLCL.doc_fee;
                txtSecurity.Text = DatosTarifarioLCL.security;
                txtImpresionBL.Text = DatosTarifarioLCL.impresion_bl;
                txtPortFacility.Text = DatosTarifarioLCL.port_facility;
                txtCanalFee.Text = DatosTarifarioLCL.canal_fee;
                txtVAC.Text = DatosTarifarioLCL.vac;
                txtImpdo.Text = DatosTarifarioLCL.impdoc;
                txtMerchant.Text = DatosTarifarioLCL.merchant;
                txtCargaPeligrosa.Text = DatosTarifarioLCL.carga_peli;
                txtTotalCostos.Text = DatosTarifarioLCL.total_cargos_destino;
                txtFlete.Text = DatosTarifarioLCL.flete;
                txtFleteMinimo.Text = DatosTarifarioLCL.flete2;
                txtTotalFlete.Text = DatosTarifarioLCL.total_flete;
                txtTotalCostosMinimos.Text = DatosTarifarioLCL.total_flete2;

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
            mNaviero = mNavieroConsultas.GetNaviero(DatosTarifarioLCL.origen, DatosTarifarioLCL.via);
            for (int i = 0; i < mNaviero.Count; i++)
            {
                cbxNaviero.Items.Add(mNaviero[i].Proveedor);
            }
        }

        private void cbxNaviero_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTHC.Text = mNaviero[cbxNaviero.SelectedIndex].Thc_d_minimo.ToString();
            txtDocFee.Text = mNaviero[cbxNaviero.SelectedIndex].Thc_d_cbm.ToString();
            txtSecurity.Text = mNaviero[cbxNaviero.SelectedIndex].Vgm_minimo.ToString();
            txtImpresionBL.Text = mNaviero[cbxNaviero.SelectedIndex].Bunker_minimo.ToString();
            txtPortFacility.Text = mNaviero[cbxNaviero.SelectedIndex].Bunker_cbm.ToString();
            txtCanalFee.Text = mNaviero[cbxNaviero.SelectedIndex].Sed_minimo.ToString();
            txtVAC.Text = mNaviero[cbxNaviero.SelectedIndex].Tica_minimo.ToString();
            txtImpdo.Text = mNaviero[cbxNaviero.SelectedIndex].Forwarding_minimo.ToString();
            txtMerchant.Text = mNaviero[cbxNaviero.SelectedIndex].Manejos_minimo.ToString();
            txtCargaPeligrosa.Text = mNaviero[cbxNaviero.SelectedIndex].Carga_peligrosa_minimo.ToString();
            var costos_cbm = float.Parse(txtDocFee.Text)+float.Parse(txtPortFacility.Text);
            var costos_minimos = float.Parse(txtTHC.Text) + float.Parse(txtImpresionBL.Text);
            var costos_flat = float.Parse(txtSecurity.Text) + float.Parse(txtCanalFee.Text) + float.Parse(txtVAC.Text) + float.Parse(txtImpdo.Text) + float.Parse(txtMerchant.Text);
            txtTotalCostos.Text = costos_cbm.ToString();
            txtTotalCostosMinimos.Text = costos_minimos.ToString();
            txtTotalFlete.Text = costos_flat.ToString();
            DatosTarifarioLCL.id_naviero = mNaviero[cbxNaviero.SelectedIndex].Id;
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            DatosTarifarioLCL.naviero = cbxNaviero.Text;
            DatosTarifarioLCL.thc = txtTHC.Text; // THC/D MINIMO
            DatosTarifarioLCL.doc_fee = txtDocFee.Text; // THC/D CBM
            DatosTarifarioLCL.security = txtSecurity.Text; // VGM MINIMO
            DatosTarifarioLCL.impresion_bl = txtImpresionBL.Text; // BUNKER MINIMO
            DatosTarifarioLCL.port_facility = txtPortFacility.Text; // BUNKER CBM
            DatosTarifarioLCL.canal_fee = txtCanalFee.Text; // SED MINIMO
            DatosTarifarioLCL.vac = txtVAC.Text; // TICA MINIMO
            DatosTarifarioLCL.impdoc = txtImpdo.Text; // FORWARDING MINIMO
            DatosTarifarioLCL.merchant = txtMerchant.Text; // MANEJOS
            DatosTarifarioLCL.carga_peli = txtCargaPeligrosa.Text; // MANEJOS
            DatosTarifarioLCL.flete = txtFlete.Text; // FLETE INTERNACIONAL CBM
            DatosTarifarioLCL.flete2 = txtFleteMinimo.Text; // FLETE INTERNACIONAL MINIMO
            DatosTarifarioLCL.total_flete = txtTotalFlete.Text; // TOTAL OTROS COSTOS FLAT
            DatosTarifarioLCL.total_cargos_destino = txtTotalCostos.Text; // TOTAL OTROS COSTOS CBM
            DatosTarifarioLCL.total_flete2 = txtTotalCostosMinimos.Text; // TOTAL OTROS COSTOS MINIMOS
        }
    }
}
