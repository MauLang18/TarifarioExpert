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

namespace Tarifarios_Tarifas.Forms
{
    public partial class FrmLCL : Form
    {
        private Form currentChildForm;
        private Button currentBtn;
        private Panel leftBorderBtn;
        private List<POL> mPol;
        private PolConsultas mPolConsultas;
        private List<POD> mPod;
        private PodConsultas mPodConsultas;
        private List<PAIS> mPais;
        private PaisConsultas mPaisConsultas;
        private List<VIA> mVia;
        private ViaConsultas mViaConsultas;
        private List<ORIGEN> mOrigen;
        private OrigenConsultas mOrigenConsultas;
        private List<Equipo> mEquipo;
        private EquipoConsultas mEquipoConsultas;
        private List<Modalidad> mModalidad;
        private ModalidadConsultas mModalidadConsultas;
        public FrmLCL()
        {
            InitializeComponent();
            btnTransbordo.Enabled = false;
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);

            mPol = new List<POL>();
            mPolConsultas = new PolConsultas();
            mPod = new List<POD>();
            mPodConsultas = new PodConsultas();
            mPais = new List<PAIS>();
            mPaisConsultas = new PaisConsultas();
            mVia = new List<VIA>();
            mViaConsultas = new ViaConsultas();
            mOrigen = new List<ORIGEN>();
            mOrigenConsultas = new OrigenConsultas();
            mEquipo = new List<Equipo>();
            mEquipoConsultas = new EquipoConsultas();
            mModalidad = new List<Modalidad>();
            mModalidadConsultas = new ModalidadConsultas();

            if (DatosTarifario.origen != null)
            {
                cbxORIGEN.Text = DatosTarifarioLCL.origen;
                cbxPOL.Text = DatosTarifarioLCL.pol;
                cbxPOE.Text = DatosTarifarioLCL.pod;
                cbxVIA.Text = DatosTarifarioLCL.via;
                cbxPAIS.Text = DatosTarifarioLCL.destino;
                cbxModalidad.Text = DatosTarifarioLCL.modalidad;
                cbxEquipo.Text = DatosTarifarioLCL.equipo;
                dtpDesde.Text = DatosTarifarioLCL.desde;
                dtpHasta.Text = DatosTarifarioLCL.hasta;
                cargarPOL();
                cargarPOD();
                cargarPAIS();
                cargarVIA();
                cargarORIGEN();
                cargarEquipo();
                cargarModalidad();
                if (cbxVIA.Text == "BALBOA" || cbxVIA.Text == "RODMAN" || cbxVIA.Text == "CRISTOBAL" || cbxVIA.Text == "MANZANILLO")
                {
                    btnTransbordo.Enabled = true;
                }
                else
                {
                    btnTransbordo.Enabled = false;
                    DatosTarifarioLCL.id_cargos_en_destino = 1;
                    DatosTarifarioLCL.id_movimiento_bodega = 1;
                    DatosTarifarioLCL.id_otras_categorias1 = 1;
                    DatosTarifarioLCL.id_otras_categorias2 = 1;
                    DatosTarifarioLCL.id_otras_categorias3 = 1;
                    DatosTarifarioLCL.cargos_en_destino_proveedor = "0";
                    DatosTarifarioLCL.cargos_en_destino = "0";
                    DatosTarifarioLCL.movimiento_bodega_proveedor = "0";
                    DatosTarifarioLCL.movimiento_bodega = "0";
                    DatosTarifarioLCL.otras_categorias_producto1 = "0";
                    DatosTarifarioLCL.otras_categorias_producto2 = "0";
                    DatosTarifarioLCL.otras_categorias_producto3 = "0";
                    DatosTarifarioLCL.otras_categorias_total = "0";
                    DatosTarifarioLCL.transbordo_total = "0";
                }

            }
            else
            {
                cargarPOL();
                cargarPOD();
                cargarPAIS();
                cargarVIA();
                cargarORIGEN();
                cargarEquipo();
                cargarModalidad();
            }
        }

        private void cargarPOL()
        {
            cbxPOL.Items.Clear();
            cbxPOL.Refresh();
            mPol.Clear();
            mPol = mPolConsultas.getPol();
            for (int i = 0; i < mPol.Count; i++)
            {
                cbxPOL.Items.Add(mPol[i].Pol);
            }
        }
        private void cargarPOD()
        {
            cbxPOE.Items.Clear();
            cbxPOE.Refresh();
            mPod.Clear();
            mPod = mPodConsultas.getPod();
            for (int i = 0; i < mPod.Count; i++)
            {
                cbxPOE.Items.Add(mPod[i].Pod);
            }
        }
        private void cargarPAIS()
        {
            cbxPAIS.Items.Clear();
            cbxPAIS.Refresh();
            mPais.Clear();
            mPais = mPaisConsultas.getPais();
            for (int i = 0; i < mPais.Count; i++)
            {
                cbxPAIS.Items.Add(mPais[i].Pais);
            }
        }
        private void cargarVIA()
        {
            cbxVIA.Items.Clear();
            cbxVIA.Refresh();
            mVia.Clear();
            mVia = mViaConsultas.getVia();
            for (int i = 0; i < mVia.Count; i++)
            {
                cbxVIA.Items.Add(mVia[i].Via);
            }
        }
        private void cargarORIGEN()
        {
            cbxORIGEN.Items.Clear();
            cbxORIGEN.Refresh();
            mOrigen.Clear();
            mOrigen = mOrigenConsultas.getOrigen();
            for (int i = 0; i < mOrigen.Count; i++)
            {
                cbxORIGEN.Items.Add(mOrigen[i].Origen);
            }
        }
        private void cargarEquipo()
        {
            cbxEquipo.Items.Clear();
            cbxEquipo.Refresh();
            mEquipo.Clear();
            mEquipo = mEquipoConsultas.getEquipo();
            for (int i = 0; i < mEquipo.Count; i++)
            {
                cbxEquipo.Items.Add(mEquipo[i].Equipos);
            }
        }
        private void cargarModalidad()
        {
            cbxModalidad.Items.Clear();
            cbxModalidad.Refresh();
            mModalidad.Clear();
            mModalidad = mModalidadConsultas.getModalidad();
            for (int i = 0; i < mModalidad.Count; i++)
            {
                cbxModalidad.Items.Add(mModalidad[i].Modalidades);
            }
        }

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(203, 50, 52);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 151);
        }

        private void ActiveBtn(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableBtn();
                currentBtn = (Button)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                //currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //iconCurrent.IconChar = currentBtn.IconChar;
                //iconCurrent.IconColor = color;
            }
        }

        private void DisableBtn()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.White;
                currentBtn.ForeColor = Color.Black;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                //currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenChilForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlDesktop.Controls.Add(childForm);
            pnlDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            //lblHome.Text = childForm.Text;
        }

        private void Reset()
        {
            DisableBtn();
            leftBorderBtn.Visible = false;
            //iconCurrent.IconChar = IconChar.Home;
            //iconCurrent.IconColor = Color.Gainsboro;
            //lblHome.Text = "Home";
        }

        private void cbxModalidad_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            DatosTarifarioLCL.id_modalidad = mModalidad[cbxModalidad.SelectedIndex].Id;
        }

        private void cbxEquipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            DatosTarifarioLCL.id_equipo = mEquipo[cbxEquipo.SelectedIndex].Id;
        }

        private void cbxVIA_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxVIA.Text == "BALBOA" || cbxVIA.Text == "RODMAN" || cbxVIA.Text == "CRISTOBAL" || cbxVIA.Text == "MANZANILLO")
            {
                btnTransbordo.Enabled = true;
            }
            else
            {
                btnTransbordo.Enabled = false;
                DatosTarifarioLCL.id_cargos_en_destino = 1;
                DatosTarifarioLCL.id_movimiento_bodega = 1;
                DatosTarifarioLCL.id_otras_categorias1 = 1;
                DatosTarifarioLCL.id_otras_categorias2 = 1;
                DatosTarifarioLCL.id_otras_categorias3 = 1;
                DatosTarifarioLCL.cargos_en_destino_proveedor = "0";
                DatosTarifarioLCL.cargos_en_destino = "0";
                DatosTarifarioLCL.movimiento_bodega_proveedor = "0";
                DatosTarifarioLCL.movimiento_bodega = "0";
                DatosTarifarioLCL.otras_categorias_producto1 = "0";
                DatosTarifarioLCL.otras_categorias_producto2 = "0";
                DatosTarifarioLCL.otras_categorias_producto3 = "0";
                DatosTarifarioLCL.otras_categorias_total = "0";
                DatosTarifarioLCL.transbordo_total = "0";
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            DatosTarifarioLCL.ruta = cbxORIGEN.Text + ", " + cbxPOL.Text + " TO " + cbxPOE.Text + " VIA " + cbxVIA.Text + ", " + cbxPAIS.Text;
            DatosTarifarioLCL.origen = cbxORIGEN.Text;
            DatosTarifarioLCL.pol = cbxPOL.Text;
            DatosTarifarioLCL.pod = cbxPOE.Text;
            DatosTarifarioLCL.via = cbxVIA.Text;
            DatosTarifarioLCL.destino = cbxPAIS.Text;
            DatosTarifarioLCL.modalidad = cbxModalidad.Text;
            DatosTarifarioLCL.equipo = cbxEquipo.Text;
            DatosTarifarioLCL.desde = dtpDesde.Text;
            DatosTarifarioLCL.hasta = dtpHasta.Text;
        }

        private void btnAgenteOrigen_Click(object sender, EventArgs e)
        {
            ActiveBtn(sender, RGBColors.color1);
            OpenChilForm(new LCL.FrmAgenteOrigenLCL());
        }

        private void btnNaviero_Click(object sender, EventArgs e)
        {
            ActiveBtn(sender, RGBColors.color1);
            OpenChilForm(new LCL.FrmNavierosLCL());
        }

        private void btnTransbordo_Click(object sender, EventArgs e)
        {
            ActiveBtn(sender, RGBColors.color1);
            OpenChilForm(new LCL.FrmTransbordoLCL());
        }

        private void btnCargosDestino_Click(object sender, EventArgs e)
        {
            ActiveBtn(sender, RGBColors.color1);
            OpenChilForm(new LCL.FrmCargosDestinoLCL());
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            ActiveBtn(sender, RGBColors.color1);
            OpenChilForm(new LCL.FrmTotalLCL());
        }
    }
}
