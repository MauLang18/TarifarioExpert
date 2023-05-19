using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tarifarios_Tarifas.Models.Atributos;
using Tarifarios_Tarifas.Models.Metodos;

namespace Tarifarios_Tarifas
{
    public partial class Form1 : Form
    {
        private Form currentChildForm;
        private Button currentBtn;
        private Panel leftBorderBtn;
        string id;

        private List<COMPETIDORES> mTarifarios;
        private CompetidoresConsultas mTarifariosConsulta;
        private COMPETIDORES mTarifarios1;

        private List<COMPETENCIA> mCompetencia;
        private CompetenciaConsultas mCompetenciaConsulta;
        private COMPETENCIA mCompetencia1;

        private List<LCLtarifarios> mLCL;
        private LCLConsultas mLCLConsulta;
        private LCLtarifarios mLCL1;
        public Form1()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            mTarifarios = new List<COMPETIDORES>();
            mTarifariosConsulta = new CompetidoresConsultas();
            mTarifarios1 = new COMPETIDORES();
            mCompetencia = new List<COMPETENCIA>();
            mCompetenciaConsulta = new CompetenciaConsultas();
            mCompetencia1 = new COMPETENCIA();
            mLCL = new List<LCLtarifarios>();
            mLCLConsulta = new LCLConsultas();
            mLCL1 = new LCLtarifarios();

            cargarTarifarios();
            cargarCompetencia();
            cargarLCL();
        }

        private void cargarTarifarios(string filtro = "", string filtro2 = "")
        {
            dgvTarifarios.Rows.Clear();
            dgvTarifarios.Refresh();
            mTarifarios.Clear();
            mTarifarios = mTarifariosConsulta.getTarifarios(filtro, filtro2);
            for (int i = 0; i < mTarifarios.Count; i++)
            {
                dgvTarifarios.RowTemplate.Height = 50;
                dgvTarifarios.Rows.Add(
                    mTarifarios[i].Id,
                    mTarifarios[i].Ruta,
                    mTarifarios[i].Proveedor_Agente_Origen,
                    mTarifarios[i].Manejos_Agente_Origen.ToString("C", new System.Globalization.CultureInfo("en-US")),
                    mTarifarios[i].Hbl_Agente_Origen.ToString("C", new System.Globalization.CultureInfo("en-US")),
                    mTarifarios[i].Agente_Origen_Total.ToString("C", new System.Globalization.CultureInfo("en-US")),
                    mTarifarios[i].Proveedor_Flete_Internacional,
                    mTarifarios[i].Thc_Flete_Internacional.ToString("C", new System.Globalization.CultureInfo("en-US")),
                    mTarifarios[i].Doc_Fee_Flete_Internacional.ToString("C", new System.Globalization.CultureInfo("en-US")),
                    mTarifarios[i].Security_Flete_Internacional.ToString("C", new System.Globalization.CultureInfo("en-US")),
                    mTarifarios[i].Impresion_Bl_Flete_Internacional.ToString("C", new System.Globalization.CultureInfo("en-US")),
                    mTarifarios[i].Port_Facility_Flete_Internacional.ToString("C", new System.Globalization.CultureInfo("en-US")),
                    mTarifarios[i].Canal_Fee_Flete_Internacional.ToString("C", new System.Globalization.CultureInfo("en-US")),
                    mTarifarios[i].Vac_Flete_Internacional.ToString("C", new System.Globalization.CultureInfo("en-US")),
                    mTarifarios[i].Impdo_Flete_Internacional.ToString("C", new System.Globalization.CultureInfo("en-US")),
                    mTarifarios[i].Merchant_Flete_Internacional.ToString("C", new System.Globalization.CultureInfo("en-US")),
                    mTarifarios[i].Flete_Internacional_Total.ToString("C", new System.Globalization.CultureInfo("en-US")),
                    mTarifarios[i].Flete_Internacional_Destino.ToString("C", new System.Globalization.CultureInfo("en-US")),
                    mTarifarios[i].Proveedor_Gastos_Portuarios,
                    mTarifarios[i].Manejos_Puerto_Gastos_Portuarios.ToString("C", new System.Globalization.CultureInfo("en-US")),
                    mTarifarios[i].Gastos_Portuarios_Total.ToString("C", new System.Globalization.CultureInfo("en-US")),
                    mTarifarios[i].Proveedor_Movimiento_Puerto_Bodega,
                    mTarifarios[i].Transporte_Puerto_Movimiento_Puerto_Bodega.ToString("C", new System.Globalization.CultureInfo("en-US")),
                    mTarifarios[i].Movimiento_Puerto_Bodega_Total.ToString("C", new System.Globalization.CultureInfo("en-US")),
                    mTarifarios[i].Proveedor_Otras_Categorias1,
                    mTarifarios[i].Producto_Otras_Categorias1,
                    mTarifarios[i].Costos_Otras_Categorias1.ToString("C", new System.Globalization.CultureInfo("en-US")),
                    mTarifarios[i].Proveedor_Otras_Categorias2,
                    mTarifarios[i].Producto_Otras_Categorias2,
                    mTarifarios[i].Costos_Otras_Categorias2.ToString("C", new System.Globalization.CultureInfo("en-US")),
                    mTarifarios[i].Proveedor_Otras_Categorias3,
                    mTarifarios[i].Producto_Otras_Categorias3,
                    mTarifarios[i].Costos_Otras_Categorias3.ToString("C", new System.Globalization.CultureInfo("en-US")),
                    mTarifarios[i].Otras_Categorias_Total.ToString("C", new System.Globalization.CultureInfo("en-US")),
                    mTarifarios[i].Proveedor_Otros_Servicios1,
                    mTarifarios[i].Producto_Otros_Servicios1,
                    mTarifarios[i].Costos_Otros_Servicios1.ToString("C", new System.Globalization.CultureInfo("en-US")),
                    mTarifarios[i].Proveedor_Otros_Servicios2,
                    mTarifarios[i].Producto_Otros_Servicios2,
                    mTarifarios[i].Costos_Otros_Servicios2.ToString("C", new System.Globalization.CultureInfo("en-US")),
                    mTarifarios[i].Proveedor_Otros_Servicios3,
                    mTarifarios[i].Producto_Otros_Servicios3,
                    mTarifarios[i].Costos_Otros_Servicios3.ToString("C", new System.Globalization.CultureInfo("en-US")),
                    mTarifarios[i].Otros_Servicios_Total.ToString("C", new System.Globalization.CultureInfo("en-US")),
                    mTarifarios[i].Proveedor_Cargos_Destino1,
                    mTarifarios[i].Costo_Cargos_Destino1.ToString("C", new System.Globalization.CultureInfo("en-US")),
                    mTarifarios[i].Proveedor_Cargos_Destino2,
                    mTarifarios[i].Costo_Cargos_Destino2.ToString("C", new System.Globalization.CultureInfo("en-US")),
                    mTarifarios[i].Proveedor_Cargos_Destino3,
                    mTarifarios[i].Costo_Cargos_Destino3.ToString("C", new System.Globalization.CultureInfo("en-US")),
                    mTarifarios[i].Cargos_Detino_Total.ToString("C", new System.Globalization.CultureInfo("en-US")),
                    mTarifarios[i].Modalidad,
                    mTarifarios[i].Equipo,
                    mTarifarios[i].Desde    ,
                    mTarifarios[i].Hasta,
                    mTarifarios[i].Total.ToString("C", new System.Globalization.CultureInfo("en-US")));
            }
        }
        private void cargarCompetencia(string filtro = "", string filtro2 = "")
        {
            dgvCompetencia.Rows.Clear();
            dgvCompetencia.Refresh();
            mCompetencia.Clear();
            mCompetencia = mCompetenciaConsulta.getCompetencia(filtro, filtro2);
            for (int i = 0; i < mCompetencia.Count; i++)
            {
                dgvCompetencia.RowTemplate.Height = 50;
                dgvCompetencia.Rows.Add(
                    mCompetencia[i].Id,
                    mCompetencia[i].Nombre,
                    mCompetencia[i].Ruta,
                    mCompetencia[i].Flete.ToString("C", new System.Globalization.CultureInfo("en-US")),
                    mCompetencia[i].Cargos_Destino.ToString("C", new System.Globalization.CultureInfo("en-US")),
                    mCompetencia[i].Otros_Cargos.ToString("C", new System.Globalization.CultureInfo("en-US")),
                    mCompetencia[i].IVA.ToString("C", new System.Globalization.CultureInfo("en-US")),
                    mCompetencia[i].Modalidad,
                    mCompetencia[i].Equipo,
                    mCompetencia[i].Desde,
                    mCompetencia[i].Hasta,
                    mCompetencia[i].Total.ToString("C", new System.Globalization.CultureInfo("en-US")));
            }
        }
        private void cargarLCL(string filtro = "", string filtro2 = "")
        {
            dgvLCL.Rows.Clear();
            dgvLCL.Refresh();
            mLCL.Clear();
            mLCL = mLCLConsulta.getLCL(filtro, filtro2);
            for (int i = 0; i < mLCL.Count; i++)
            {
                dgvLCL.RowTemplate.Height = 50;
                dgvLCL.Rows.Add(
                    mLCL[i].Id,
                    mLCL[i].Ruta,
                    mLCL[i].Proveedor_Agente_Origen,
                    mLCL[i].Manejos_Agente_Origen.ToString("C", new System.Globalization.CultureInfo("en-US")),
                    mLCL[i].Hbl_Agente_Origen.ToString("C", new System.Globalization.CultureInfo("en-US")),
                    mLCL[i].Proveedor_Flete_Internacional,
                    mLCL[i].Thc_Cbm_Flete_Internacional.ToString("C", new System.Globalization.CultureInfo("en-US")),
                    mLCL[i].Thc_Minimo_Flete_Internacional.ToString("C", new System.Globalization.CultureInfo("en-US")),
                    mLCL[i].Vgm_Minimo_Flete_Internacional.ToString("C", new System.Globalization.CultureInfo("en-US")),
                    mLCL[i].Bunker_Cbm_Flete_Internacional.ToString("C", new System.Globalization.CultureInfo("en-US")),
                    mLCL[i].Bunker_Minimo_Flete_Internacional.ToString("C", new System.Globalization.CultureInfo("en-US")),
                    mLCL[i].Sed_Minimo_Flete_Internacional.ToString("C", new System.Globalization.CultureInfo("en-US")),
                    mLCL[i].Tica_Minimo_Flete_Internacional.ToString("C", new System.Globalization.CultureInfo("en-US")),
                    mLCL[i].Forwarding_Minimo_Flete_Internacional.ToString("C", new System.Globalization.CultureInfo("en-US")),
                    mLCL[i].Manejos_Minimo_Flete_Internacional.ToString("C", new System.Globalization.CultureInfo("en-US")),
                    mLCL[i].Carga_Peligrosa_Flete_Internacional.ToString("C", new System.Globalization.CultureInfo("en-US")),
                    mLCL[i].Proveedor_Cargos_En_Destino,
                    mLCL[i].Costos_Cargos_En_Destino.ToString("C", new System.Globalization.CultureInfo("en-US")),
                    mLCL[i].Proveedor_Movimiento_Bodega,
                    mLCL[i].Transporte_Bodega_Movimiento_Bodega.ToString("C", new System.Globalization.CultureInfo("en-US")),
                    mLCL[i].Proveedor_Otras_Categorias1,
                    mLCL[i].Producto_Otras_Categorias1,
                    mLCL[i].Costos_Otras_Categorias1.ToString("C", new System.Globalization.CultureInfo("en-US")),
                    mLCL[i].Proveedor_Otras_Categorias2,
                    mLCL[i].Producto_Otras_Categorias2,
                    mLCL[i].Costos_Otras_Categorias2.ToString("C", new System.Globalization.CultureInfo("en-US")),
                    mLCL[i].Proveedor_Otras_Categorias3,
                    mLCL[i].Producto_Otras_Categorias3,
                    mLCL[i].Costos_Otras_Categorias3.ToString("C", new System.Globalization.CultureInfo("en-US")),
                    mLCL[i].Proveedor_Cargos_Destino1,
                    mLCL[i].Costo_Cargos_Destino1.ToString("C", new System.Globalization.CultureInfo("en-US")),
                    mLCL[i].Proveedor_Cargos_Destino2,
                    mLCL[i].Costo_Cargos_Destino2.ToString("C", new System.Globalization.CultureInfo("en-US")),
                    mLCL[i].Proveedor_Cargos_Destino3,
                    mLCL[i].Costo_Cargos_Destino3.ToString("C", new System.Globalization.CultureInfo("en-US")),
                    mLCL[i].Modalidad,
                    mLCL[i].Equipo,
                    mLCL[i].Desde,
                    mLCL[i].Hasta,
                    mLCL[i].Total_Flete_Cbm.ToString("C", new System.Globalization.CultureInfo("en-US")),
                    mLCL[i].Total_Flete_Minimo.ToString("C", new System.Globalization.CultureInfo("en-US")),
                    mLCL[i].Total_Otros_Costos_Cbm.ToString("C", new System.Globalization.CultureInfo("en-US")),
                    mLCL[i].Total_Otros_Costos_Minimos.ToString("C", new System.Globalization.CultureInfo("en-US")),
                    mLCL[i].Total_Otros_Costos_Flat.ToString("C", new System.Globalization.CultureInfo("en-US")));
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
                currentBtn.BackColor = Color.MidnightBlue;
                currentBtn.ForeColor = Color.Gainsboro;
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

        private int getIdTarifarioIfExist()
        {
            if (!id.Trim().Equals(""))
            {
                if (int.TryParse(id.Trim(), out int folio))
                {
                    return folio;
                }
                else return -1;
            }
            else return -1;
        }

        private void cargarDatosGuardadosT()
        {
            mTarifarios1.Id = getIdTarifarioIfExist();
        }

        private int getIdCompetenciaIfExist()
        {
            if (!id.Trim().Equals(""))
            {
                if (int.TryParse(id.Trim(), out int folio))
                {
                    return folio;
                }
                else return -1;
            }
            else return -1;
        }

        private void cargarDatosGuardadosC()
        {
            mCompetencia1.Id = getIdCompetenciaIfExist();
        }

        private int getIdLCLIfExist()
        {
            if (!id.Trim().Equals(""))
            {
                if (int.TryParse(id.Trim(), out int folio))
                {
                    return folio;
                }
                else return -1;
            }
            else return -1;
        }

        private void cargarDatosGuardadosLCL()
        {
            mLCL1.Id = getIdLCLIfExist();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void button6_Click(object sender, EventArgs e)
        {
            ActiveBtn(sender, RGBColors.color1);
            OpenChilForm(new Forms.FrmTarifarios());
        }

        private void label1_Click(object sender, EventArgs e)
        {
            currentChildForm.Close();
            Reset();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ActiveBtn(sender, RGBColors.color3);
            OpenChilForm(new Forms.FrmAgregarDatos());
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            cargarTarifarios();
            currentChildForm.Close();
            Reset();
        }

        private void btnTarifas_Click(object sender, EventArgs e)
        {
            ActiveBtn(sender, RGBColors.color2);
            OpenChilForm(new Forms.FrmLCL());
        }

        private void txtBuscar_TextChanged_1(object sender, EventArgs e)
        {
            cargarTarifarios(txtBuscar.Text.Trim().ToUpper());
        }

        private void dtpDesde_ValueChanged(object sender, EventArgs e)
        {
            cargarTarifarios(dtpDesde.Text, dtpHasta.Text);
        }

        private void dtpHasta_ValueChanged(object sender, EventArgs e)
        {
            cargarTarifarios(dtpDesde.Text, dtpHasta.Text);
        }

        private void btnCompetencia_Click(object sender, EventArgs e)
        {
            ActiveBtn(sender, RGBColors.color4);
            OpenChilForm(new Forms.FrmCompetencia());
        }

        private void dgvTarifarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dgvTarifarios.Rows[e.RowIndex];
            id = Convert.ToString(fila.Cells["idTarifario"].Value);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (getIdTarifarioIfExist() == -1)
            {
                return;
            }

            if (MessageBox.Show("¿DESEAS ELIMINAR EL TARIFARIO?", "ELIMINAR TARIFARIO", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                cargarDatosGuardadosT();

                if (mTarifariosConsulta.eliminarTarifario(mTarifarios1))
                {
                    MessageBox.Show("TARIFARIO ELIMINADO");
                    cargarTarifarios();
                    id = "";
                }
            }
        }

        private void btnEliminarTodo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿DESEAS ELIMINAR TODOS LOS TARIFARIOS?", "ELIMINAR TODOS LOS TARIFARIOS", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (mTarifariosConsulta.eliminarTodoTarifario())
                {
                    MessageBox.Show("TODOS LOS TARIFARIOS ELIMINADOS");
                    cargarTarifarios();
                }
            }
        }

        private void dgvCompetencia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dgvCompetencia.Rows[e.RowIndex];
            id = Convert.ToString(fila.Cells["idCompetencia"].Value);
        }

        private void btnEliminarCompetencia_Click(object sender, EventArgs e)
        {
            if (getIdCompetenciaIfExist() == -1)
            {
                return;
            }

            if (MessageBox.Show("¿DESEAS ELIMINAR EL TARIFARIO?", "ELIMINAR TARIFARIO", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                cargarDatosGuardadosC();

                if (mCompetenciaConsulta.eliminarCompetencia(mCompetencia1))
                {
                    MessageBox.Show("TARIFARIO ELIMINADO");
                    cargarCompetencia();
                    id = "";
                }
            }
        }

        private void btnEliminarTodoCompetencia_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿DESEAS ELIMINAR TODOS LOS TARIFARIOS?", "ELIMINAR TODOS LOS TARIFARIOS", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (mCompetenciaConsulta.eliminarTodoCompetencia())
                {
                    MessageBox.Show("TODOS LOS TARIFARIOS ELIMINADOS");
                    cargarCompetencia();
                }
            }
        }

        private void txtBuscarCompetencia_TextChanged(object sender, EventArgs e)
        {
            cargarCompetencia(txtBuscarCompetencia.Text.Trim().ToUpper());
        }

        private void dtpDesdeCompetencia_ValueChanged(object sender, EventArgs e)
        {
            cargarCompetencia(dtpDesdeCompetencia.Text, dtpHastaCompetencia.Text);
        }

        private void dtpHastaCompetencia_ValueChanged(object sender, EventArgs e)
        {
            cargarCompetencia(dtpDesdeCompetencia.Text, dtpHastaCompetencia.Text);
        }

        private void txtBuscarLCL_TextChanged(object sender, EventArgs e)
        {
            cargarLCL(txtBuscarLCL.Text.Trim().ToUpper());
        }

        private void dtpDesdeLCL_ValueChanged(object sender, EventArgs e)
        {
            cargarLCL(dtpDesdeLCL.Text, dtpHastaLCL.Text);
        }

        private void dtpHastaLCL_ValueChanged(object sender, EventArgs e)
        {
            cargarLCL(dtpDesdeLCL.Text, dtpHastaLCL.Text);
        }

        private void dgvLCL_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dgvLCL.Rows[e.RowIndex];
            id = Convert.ToString(fila.Cells["idLCL"].Value);
        }

        private void btnEliminarLCL_Click(object sender, EventArgs e)
        {
            if (getIdLCLIfExist() == -1)
            {
                return;
            }

            if (MessageBox.Show("¿DESEAS ELIMINAR EL TARIFARIO?", "ELIMINAR TARIFARIO", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                cargarDatosGuardadosLCL();

                if (mLCLConsulta.eliminarLCL(mLCL1))
                {
                    MessageBox.Show("TARIFARIO ELIMINADO");
                    cargarLCL();
                    id = "";
                }
            }
        }

        private void btnEliminarTodoLCL_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿DESEAS ELIMINAR TODOS LOS TARIFARIOS?", "ELIMINAR TODOS LOS TARIFARIOS", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (mLCLConsulta.eliminarTodoLCL())
                {
                    MessageBox.Show("TODOS LOS TARIFARIOS ELIMINADOS");
                    cargarLCL();
                }
            }
        }
    }
}
