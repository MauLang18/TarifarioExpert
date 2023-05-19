namespace Tarifarios_Tarifas
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.btnSalir = new FontAwesome.Sharp.IconButton();
            this.btnMinimizar = new FontAwesome.Sharp.IconButton();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnCompetencia = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAgregarDatos = new System.Windows.Forms.Button();
            this.btnLcl = new System.Windows.Forms.Button();
            this.btnTarifarios = new System.Windows.Forms.Button();
            this.pnlDesktop = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbpTarifarios = new System.Windows.Forms.TabPage();
            this.btnEliminarTodo = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.dgvTarifarios = new System.Windows.Forms.DataGridView();
            this.idTarifario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rutaTarifarios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proveedorAgenteOrigenTarifarios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manejosAgenteOrigenTarifarios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hblAgenteOrigenTarifarios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalAgenteOrigenTarifarios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proveedorFleteInternacionalTarifario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thcFleteInternacionalTarifarios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.docFeeFleteInternacionalTarifarios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.securityFleteInternacionalTarifarios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.impresionBlFleteInternacionalTarifarios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.portFacilityFleteInternacional = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.canalFeeFleteInternacionalTarifarios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vacFleteInternacionalTarifarios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.impdoFleteInternacionalTarifarios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.merchantFleteInternacionalTarifarios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fleteTotalFleteInternacionalTarifarios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalFleteInternacionalTarifarios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proveedorGastosPortuariosTarifarios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manejosPuertoGastosPortuariosTarifarios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalGastosPortuariosTarifarios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proveedorMovimientoPuertoBodegaTarifarios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transportePuertoMovimientoPuertoBodegaTarifarios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalMovimientoPuertoBodegaTarifarios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proveedorOC1Tarifarios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productoOC1Tarifarios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoOC1Tarifarios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proveedorOC2Tarifarios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productoOC2Tarifarios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoOC2Tarifarios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proveedorOC3Tarifarios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productoOC3Tarifarios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoOC3Tarifarios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalOCTarifarios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proveedorOS1Tarifarios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productoOS1Tarifarios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoOS1Tarifarios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proveedorOS2Tarifarios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productoOS2Tarifarios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoOS2Tarifarios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proveedorOS3Tarifarios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productoOS3Tarifarios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoOS3Tarifarios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalOSTarifarios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proveedorCargosDestino1Tarifarios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoCargoDestino1Tarifarios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proveedorCargoDestino2Tarifarios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoCargoDestino2Tarifarios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proveedorCargoDestino3Tarifarios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoCargoDestino3Tarifarios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalCargosDestinoTarifarios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modalidadTarifarios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipoTarifarios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desdeTarifarios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hastaTarifarios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalTarifarios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbpTarifas = new System.Windows.Forms.TabPage();
            this.tbpCompetencia = new System.Windows.Forms.TabPage();
            this.btnEliminarTodoCompetencia = new System.Windows.Forms.Button();
            this.btnEliminarCompetencia = new System.Windows.Forms.Button();
            this.txtBuscarCompetencia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpHastaCompetencia = new System.Windows.Forms.DateTimePicker();
            this.dtpDesdeCompetencia = new System.Windows.Forms.DateTimePicker();
            this.dgvCompetencia = new System.Windows.Forms.DataGridView();
            this.idCompetencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreCompetencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rutaCompetencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fleteCompetencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargosDestinoCompetencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otrosCostosCompetencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ivaCompetencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modalidadCompetencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipoCompetencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desdeCompetencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hastaCompetencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalCompetencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminarTodoLCL = new System.Windows.Forms.Button();
            this.btnEliminarLCL = new System.Windows.Forms.Button();
            this.txtBuscarLCL = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpHastaLCL = new System.Windows.Forms.DateTimePicker();
            this.dtpDesdeLCL = new System.Windows.Forms.DateTimePicker();
            this.dgvLCL = new System.Windows.Forms.DataGridView();
            this.idLCL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rutaLCL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proveedorAgenteOrigenLCL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manejosAgenteOrigenLCL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hblAgenteOrigenLCL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proveedorFleteInternacionalLCL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thcDCbmFleteInternacionalLCL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thcDMinimoFleteInternacionalLCL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vgmMinimoFleteInternacionalLCL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunkerCbmFleteInternacionalLCL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunkerMinimoFleteInternacionalLCL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sedMinimoFleteInternacionalLCL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcaMinimoFleteInternacionalLCL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.forwardingMinimoFleteInternacionalLCL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ManejosMinimoFleteInternacionalLCL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargaPeligrosaMinimoFleteInternacionalLCL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proveedorCargosEnDestinoLCL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargosCargosEnDestinoLCL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proveedorMovimientoBodegaLCL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transporteBodegaMovimientoBodegaLCL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proveedorOC1LCL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productoOC1LCL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoOC1LCL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proveedorOC2LCL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productoOC2LCL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoOC2LCL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proveedorOC3LCL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productoOC3LCL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoOC3LCL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proveedorCargoDestino1LCL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoCargoDestino1LCL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proveedorCargoDestino2LCL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoCargoDestino2LCL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proveedorCargoDestino23LCL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoCargoDestino3LCL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modalidadLCL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipoLCL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desdeLCL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hastaLCL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalFleteCbmLCL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalFleteMinimoLCL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalOtrosCostosCbmLCL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalOtrosCostosMinimosLCL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalOtrosCostosFlatCL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.pnlDesktop.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tbpTarifarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarifarios)).BeginInit();
            this.tbpTarifas.SuspendLayout();
            this.tbpCompetencia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompetencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLCL)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.btnMinimizar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2045, 281);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // btnHome
            // 
            this.btnHome.Image = global::Tarifarios_Tarifas.Properties.Resources.zyro_image;
            this.btnHome.Location = new System.Drawing.Point(26, 28);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(286, 225);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHome.TabIndex = 1;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.IconChar = FontAwesome.Sharp.IconChar.X;
            this.btnSalir.IconColor = System.Drawing.Color.Gainsboro;
            this.btnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSalir.IconSize = 35;
            this.btnSalir.Location = new System.Drawing.Point(1979, 3);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(63, 56);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.IconChar = FontAwesome.Sharp.IconChar.Subtract;
            this.btnMinimizar.IconColor = System.Drawing.Color.Gainsboro;
            this.btnMinimizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimizar.Location = new System.Drawing.Point(1910, 3);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(63, 56);
            this.btnMinimizar.TabIndex = 3;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.MidnightBlue;
            this.panelMenu.Controls.Add(this.btnCompetencia);
            this.panelMenu.Controls.Add(this.groupBox2);
            this.panelMenu.Controls.Add(this.btnAgregarDatos);
            this.panelMenu.Controls.Add(this.btnLcl);
            this.panelMenu.Controls.Add(this.btnTarifarios);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 281);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(336, 1162);
            this.panelMenu.TabIndex = 1;
            // 
            // btnCompetencia
            // 
            this.btnCompetencia.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCompetencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompetencia.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompetencia.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCompetencia.Location = new System.Drawing.Point(0, 294);
            this.btnCompetencia.Name = "btnCompetencia";
            this.btnCompetencia.Size = new System.Drawing.Size(336, 98);
            this.btnCompetencia.TabIndex = 3;
            this.btnCompetencia.Text = "COMPETENCIA";
            this.btnCompetencia.UseVisualStyleBackColor = true;
            this.btnCompetencia.Click += new System.EventHandler(this.btnCompetencia_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(336, 596);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1709, 586);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // btnAgregarDatos
            // 
            this.btnAgregarDatos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAgregarDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarDatos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarDatos.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAgregarDatos.Location = new System.Drawing.Point(0, 196);
            this.btnAgregarDatos.Name = "btnAgregarDatos";
            this.btnAgregarDatos.Size = new System.Drawing.Size(336, 98);
            this.btnAgregarDatos.TabIndex = 2;
            this.btnAgregarDatos.Text = "AGREGAR DATOS";
            this.btnAgregarDatos.UseVisualStyleBackColor = true;
            this.btnAgregarDatos.Click += new System.EventHandler(this.button8_Click);
            // 
            // btnLcl
            // 
            this.btnLcl.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLcl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLcl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLcl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnLcl.Location = new System.Drawing.Point(0, 98);
            this.btnLcl.Name = "btnLcl";
            this.btnLcl.Size = new System.Drawing.Size(336, 98);
            this.btnLcl.TabIndex = 1;
            this.btnLcl.Text = "LCL";
            this.btnLcl.UseVisualStyleBackColor = true;
            this.btnLcl.Click += new System.EventHandler(this.btnTarifas_Click);
            // 
            // btnTarifarios
            // 
            this.btnTarifarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTarifarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTarifarios.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTarifarios.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnTarifarios.Location = new System.Drawing.Point(0, 0);
            this.btnTarifarios.Name = "btnTarifarios";
            this.btnTarifarios.Size = new System.Drawing.Size(336, 98);
            this.btnTarifarios.TabIndex = 0;
            this.btnTarifarios.Text = "TARIFARIOS";
            this.btnTarifarios.UseVisualStyleBackColor = true;
            this.btnTarifarios.Click += new System.EventHandler(this.button6_Click);
            // 
            // pnlDesktop
            // 
            this.pnlDesktop.Controls.Add(this.tabControl1);
            this.pnlDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDesktop.Location = new System.Drawing.Point(336, 281);
            this.pnlDesktop.Name = "pnlDesktop";
            this.pnlDesktop.Size = new System.Drawing.Size(1709, 1162);
            this.pnlDesktop.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbpTarifarios);
            this.tabControl1.Controls.Add(this.tbpTarifas);
            this.tabControl1.Controls.Add(this.tbpCompetencia);
            this.tabControl1.Location = new System.Drawing.Point(6, 7);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1713, 1214);
            this.tabControl1.TabIndex = 0;
            // 
            // tbpTarifarios
            // 
            this.tbpTarifarios.Controls.Add(this.btnEliminarTodo);
            this.tbpTarifarios.Controls.Add(this.btnEliminar);
            this.tbpTarifarios.Controls.Add(this.txtBuscar);
            this.tbpTarifarios.Controls.Add(this.label3);
            this.tbpTarifarios.Controls.Add(this.label2);
            this.tbpTarifarios.Controls.Add(this.label1);
            this.tbpTarifarios.Controls.Add(this.dtpHasta);
            this.tbpTarifarios.Controls.Add(this.dtpDesde);
            this.tbpTarifarios.Controls.Add(this.dgvTarifarios);
            this.tbpTarifarios.Location = new System.Drawing.Point(8, 39);
            this.tbpTarifarios.Name = "tbpTarifarios";
            this.tbpTarifarios.Padding = new System.Windows.Forms.Padding(3);
            this.tbpTarifarios.Size = new System.Drawing.Size(1697, 1167);
            this.tbpTarifarios.TabIndex = 0;
            this.tbpTarifarios.Text = "TARIFARIOS";
            this.tbpTarifarios.UseVisualStyleBackColor = true;
            // 
            // btnEliminarTodo
            // 
            this.btnEliminarTodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarTodo.Location = new System.Drawing.Point(1324, 52);
            this.btnEliminarTodo.Name = "btnEliminarTodo";
            this.btnEliminarTodo.Size = new System.Drawing.Size(178, 77);
            this.btnEliminarTodo.TabIndex = 10;
            this.btnEliminarTodo.Text = "ELIMINAR TODO";
            this.btnEliminarTodo.UseVisualStyleBackColor = true;
            this.btnEliminarTodo.Click += new System.EventHandler(this.btnEliminarTodo_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(951, 52);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(178, 77);
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(67, 272);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(626, 31);
            this.txtBuscar.TabIndex = 8;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1316, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 46);
            this.label3.TabIndex = 7;
            this.label3.Text = "HASTA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(943, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 46);
            this.label2.TabIndex = 6;
            this.label2.Text = "DESDE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 46);
            this.label1.TabIndex = 5;
            this.label1.Text = "BUSCAR";
            // 
            // dtpHasta
            // 
            this.dtpHasta.CustomFormat = "yyyy-MM-dd";
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHasta.Location = new System.Drawing.Point(1324, 270);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(299, 31);
            this.dtpHasta.TabIndex = 4;
            this.dtpHasta.ValueChanged += new System.EventHandler(this.dtpHasta_ValueChanged);
            // 
            // dtpDesde
            // 
            this.dtpDesde.CustomFormat = "yyyy-MM-dd";
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDesde.Location = new System.Drawing.Point(951, 270);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(299, 31);
            this.dtpDesde.TabIndex = 3;
            this.dtpDesde.ValueChanged += new System.EventHandler(this.dtpDesde_ValueChanged);
            // 
            // dgvTarifarios
            // 
            this.dgvTarifarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvTarifarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTarifarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idTarifario,
            this.rutaTarifarios,
            this.proveedorAgenteOrigenTarifarios,
            this.manejosAgenteOrigenTarifarios,
            this.hblAgenteOrigenTarifarios,
            this.totalAgenteOrigenTarifarios,
            this.proveedorFleteInternacionalTarifario,
            this.thcFleteInternacionalTarifarios,
            this.docFeeFleteInternacionalTarifarios,
            this.securityFleteInternacionalTarifarios,
            this.impresionBlFleteInternacionalTarifarios,
            this.portFacilityFleteInternacional,
            this.canalFeeFleteInternacionalTarifarios,
            this.vacFleteInternacionalTarifarios,
            this.impdoFleteInternacionalTarifarios,
            this.merchantFleteInternacionalTarifarios,
            this.fleteTotalFleteInternacionalTarifarios,
            this.totalFleteInternacionalTarifarios,
            this.proveedorGastosPortuariosTarifarios,
            this.manejosPuertoGastosPortuariosTarifarios,
            this.totalGastosPortuariosTarifarios,
            this.proveedorMovimientoPuertoBodegaTarifarios,
            this.transportePuertoMovimientoPuertoBodegaTarifarios,
            this.totalMovimientoPuertoBodegaTarifarios,
            this.proveedorOC1Tarifarios,
            this.productoOC1Tarifarios,
            this.costoOC1Tarifarios,
            this.proveedorOC2Tarifarios,
            this.productoOC2Tarifarios,
            this.costoOC2Tarifarios,
            this.proveedorOC3Tarifarios,
            this.productoOC3Tarifarios,
            this.costoOC3Tarifarios,
            this.totalOCTarifarios,
            this.proveedorOS1Tarifarios,
            this.productoOS1Tarifarios,
            this.costoOS1Tarifarios,
            this.proveedorOS2Tarifarios,
            this.productoOS2Tarifarios,
            this.costoOS2Tarifarios,
            this.proveedorOS3Tarifarios,
            this.productoOS3Tarifarios,
            this.costoOS3Tarifarios,
            this.totalOSTarifarios,
            this.proveedorCargosDestino1Tarifarios,
            this.costoCargoDestino1Tarifarios,
            this.proveedorCargoDestino2Tarifarios,
            this.costoCargoDestino2Tarifarios,
            this.proveedorCargoDestino3Tarifarios,
            this.costoCargoDestino3Tarifarios,
            this.totalCargosDestinoTarifarios,
            this.modalidadTarifarios,
            this.equipoTarifarios,
            this.desdeTarifarios,
            this.hastaTarifarios,
            this.totalTarifarios});
            this.dgvTarifarios.Location = new System.Drawing.Point(0, 420);
            this.dgvTarifarios.Name = "dgvTarifarios";
            this.dgvTarifarios.RowHeadersWidth = 82;
            this.dgvTarifarios.RowTemplate.Height = 33;
            this.dgvTarifarios.Size = new System.Drawing.Size(1684, 667);
            this.dgvTarifarios.TabIndex = 2;
            this.dgvTarifarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTarifarios_CellClick);
            // 
            // idTarifario
            // 
            this.idTarifario.HeaderText = "ID";
            this.idTarifario.MinimumWidth = 10;
            this.idTarifario.Name = "idTarifario";
            this.idTarifario.Width = 77;
            // 
            // rutaTarifarios
            // 
            this.rutaTarifarios.HeaderText = "RUTA";
            this.rutaTarifarios.MinimumWidth = 10;
            this.rutaTarifarios.Name = "rutaTarifarios";
            this.rutaTarifarios.Width = 114;
            // 
            // proveedorAgenteOrigenTarifarios
            // 
            this.proveedorAgenteOrigenTarifarios.HeaderText = "AGENTE ORIGEN";
            this.proveedorAgenteOrigenTarifarios.MinimumWidth = 10;
            this.proveedorAgenteOrigenTarifarios.Name = "proveedorAgenteOrigenTarifarios";
            this.proveedorAgenteOrigenTarifarios.Width = 211;
            // 
            // manejosAgenteOrigenTarifarios
            // 
            this.manejosAgenteOrigenTarifarios.HeaderText = "MANEJOS";
            this.manejosAgenteOrigenTarifarios.MinimumWidth = 10;
            this.manejosAgenteOrigenTarifarios.Name = "manejosAgenteOrigenTarifarios";
            this.manejosAgenteOrigenTarifarios.Width = 159;
            // 
            // hblAgenteOrigenTarifarios
            // 
            this.hblAgenteOrigenTarifarios.HeaderText = "HBL";
            this.hblAgenteOrigenTarifarios.MinimumWidth = 10;
            this.hblAgenteOrigenTarifarios.Name = "hblAgenteOrigenTarifarios";
            this.hblAgenteOrigenTarifarios.Width = 98;
            // 
            // totalAgenteOrigenTarifarios
            // 
            this.totalAgenteOrigenTarifarios.HeaderText = "TOTAL";
            this.totalAgenteOrigenTarifarios.MinimumWidth = 10;
            this.totalAgenteOrigenTarifarios.Name = "totalAgenteOrigenTarifarios";
            this.totalAgenteOrigenTarifarios.Width = 125;
            // 
            // proveedorFleteInternacionalTarifario
            // 
            this.proveedorFleteInternacionalTarifario.HeaderText = "FLETE INTERNACIONAL";
            this.proveedorFleteInternacionalTarifario.MinimumWidth = 10;
            this.proveedorFleteInternacionalTarifario.Name = "proveedorFleteInternacionalTarifario";
            this.proveedorFleteInternacionalTarifario.Width = 271;
            // 
            // thcFleteInternacionalTarifarios
            // 
            this.thcFleteInternacionalTarifarios.HeaderText = "THC";
            this.thcFleteInternacionalTarifarios.MinimumWidth = 10;
            this.thcFleteInternacionalTarifarios.Name = "thcFleteInternacionalTarifarios";
            // 
            // docFeeFleteInternacionalTarifarios
            // 
            this.docFeeFleteInternacionalTarifarios.HeaderText = "DOC FEE";
            this.docFeeFleteInternacionalTarifarios.MinimumWidth = 10;
            this.docFeeFleteInternacionalTarifarios.Name = "docFeeFleteInternacionalTarifarios";
            this.docFeeFleteInternacionalTarifarios.Width = 139;
            // 
            // securityFleteInternacionalTarifarios
            // 
            this.securityFleteInternacionalTarifarios.HeaderText = "SECURITY";
            this.securityFleteInternacionalTarifarios.MinimumWidth = 10;
            this.securityFleteInternacionalTarifarios.Name = "securityFleteInternacionalTarifarios";
            this.securityFleteInternacionalTarifarios.Width = 163;
            // 
            // impresionBlFleteInternacionalTarifarios
            // 
            this.impresionBlFleteInternacionalTarifarios.HeaderText = "IMPRESION BL";
            this.impresionBlFleteInternacionalTarifarios.MinimumWidth = 10;
            this.impresionBlFleteInternacionalTarifarios.Name = "impresionBlFleteInternacionalTarifarios";
            this.impresionBlFleteInternacionalTarifarios.Width = 189;
            // 
            // portFacilityFleteInternacional
            // 
            this.portFacilityFleteInternacional.HeaderText = "PORT FACILITY";
            this.portFacilityFleteInternacional.MinimumWidth = 10;
            this.portFacilityFleteInternacional.Name = "portFacilityFleteInternacional";
            this.portFacilityFleteInternacional.Width = 196;
            // 
            // canalFeeFleteInternacionalTarifarios
            // 
            this.canalFeeFleteInternacionalTarifarios.HeaderText = "CANAL FEE";
            this.canalFeeFleteInternacionalTarifarios.MinimumWidth = 10;
            this.canalFeeFleteInternacionalTarifarios.Name = "canalFeeFleteInternacionalTarifarios";
            this.canalFeeFleteInternacionalTarifarios.Width = 161;
            // 
            // vacFleteInternacionalTarifarios
            // 
            this.vacFleteInternacionalTarifarios.HeaderText = "VAC";
            this.vacFleteInternacionalTarifarios.MinimumWidth = 10;
            this.vacFleteInternacionalTarifarios.Name = "vacFleteInternacionalTarifarios";
            // 
            // impdoFleteInternacionalTarifarios
            // 
            this.impdoFleteInternacionalTarifarios.HeaderText = "IMPDO";
            this.impdoFleteInternacionalTarifarios.MinimumWidth = 10;
            this.impdoFleteInternacionalTarifarios.Name = "impdoFleteInternacionalTarifarios";
            this.impdoFleteInternacionalTarifarios.Width = 125;
            // 
            // merchantFleteInternacionalTarifarios
            // 
            this.merchantFleteInternacionalTarifarios.HeaderText = "MERCHANT";
            this.merchantFleteInternacionalTarifarios.MinimumWidth = 10;
            this.merchantFleteInternacionalTarifarios.Name = "merchantFleteInternacionalTarifarios";
            this.merchantFleteInternacionalTarifarios.Width = 176;
            // 
            // fleteTotalFleteInternacionalTarifarios
            // 
            this.fleteTotalFleteInternacionalTarifarios.HeaderText = "FLETE";
            this.fleteTotalFleteInternacionalTarifarios.MinimumWidth = 10;
            this.fleteTotalFleteInternacionalTarifarios.Name = "fleteTotalFleteInternacionalTarifarios";
            this.fleteTotalFleteInternacionalTarifarios.Width = 123;
            // 
            // totalFleteInternacionalTarifarios
            // 
            this.totalFleteInternacionalTarifarios.HeaderText = "TOTAL CARGOS DESTINO";
            this.totalFleteInternacionalTarifarios.MinimumWidth = 10;
            this.totalFleteInternacionalTarifarios.Name = "totalFleteInternacionalTarifarios";
            this.totalFleteInternacionalTarifarios.Width = 291;
            // 
            // proveedorGastosPortuariosTarifarios
            // 
            this.proveedorGastosPortuariosTarifarios.HeaderText = "GASTOS PORTUARIOS";
            this.proveedorGastosPortuariosTarifarios.MinimumWidth = 10;
            this.proveedorGastosPortuariosTarifarios.Name = "proveedorGastosPortuariosTarifarios";
            this.proveedorGastosPortuariosTarifarios.Width = 262;
            // 
            // manejosPuertoGastosPortuariosTarifarios
            // 
            this.manejosPuertoGastosPortuariosTarifarios.HeaderText = "MANEJOS PUERTO";
            this.manejosPuertoGastosPortuariosTarifarios.MinimumWidth = 10;
            this.manejosPuertoGastosPortuariosTarifarios.Name = "manejosPuertoGastosPortuariosTarifarios";
            this.manejosPuertoGastosPortuariosTarifarios.Width = 231;
            // 
            // totalGastosPortuariosTarifarios
            // 
            this.totalGastosPortuariosTarifarios.HeaderText = "TOTAL";
            this.totalGastosPortuariosTarifarios.MinimumWidth = 10;
            this.totalGastosPortuariosTarifarios.Name = "totalGastosPortuariosTarifarios";
            this.totalGastosPortuariosTarifarios.Width = 125;
            // 
            // proveedorMovimientoPuertoBodegaTarifarios
            // 
            this.proveedorMovimientoPuertoBodegaTarifarios.HeaderText = "MOVIMIENTO PUERTO BODEGA";
            this.proveedorMovimientoPuertoBodegaTarifarios.MinimumWidth = 10;
            this.proveedorMovimientoPuertoBodegaTarifarios.Name = "proveedorMovimientoPuertoBodegaTarifarios";
            this.proveedorMovimientoPuertoBodegaTarifarios.Width = 265;
            // 
            // transportePuertoMovimientoPuertoBodegaTarifarios
            // 
            this.transportePuertoMovimientoPuertoBodegaTarifarios.HeaderText = "TRANSPORTE PUERTO";
            this.transportePuertoMovimientoPuertoBodegaTarifarios.MinimumWidth = 10;
            this.transportePuertoMovimientoPuertoBodegaTarifarios.Name = "transportePuertoMovimientoPuertoBodegaTarifarios";
            this.transportePuertoMovimientoPuertoBodegaTarifarios.Width = 268;
            // 
            // totalMovimientoPuertoBodegaTarifarios
            // 
            this.totalMovimientoPuertoBodegaTarifarios.HeaderText = "TOTAL";
            this.totalMovimientoPuertoBodegaTarifarios.MinimumWidth = 10;
            this.totalMovimientoPuertoBodegaTarifarios.Name = "totalMovimientoPuertoBodegaTarifarios";
            this.totalMovimientoPuertoBodegaTarifarios.Width = 125;
            // 
            // proveedorOC1Tarifarios
            // 
            this.proveedorOC1Tarifarios.HeaderText = "OTRAS CATEGORIAS 1";
            this.proveedorOC1Tarifarios.MinimumWidth = 10;
            this.proveedorOC1Tarifarios.Name = "proveedorOC1Tarifarios";
            this.proveedorOC1Tarifarios.Width = 264;
            // 
            // productoOC1Tarifarios
            // 
            this.productoOC1Tarifarios.HeaderText = "SERVICIO 1";
            this.productoOC1Tarifarios.MinimumWidth = 10;
            this.productoOC1Tarifarios.Name = "productoOC1Tarifarios";
            this.productoOC1Tarifarios.Width = 160;
            // 
            // costoOC1Tarifarios
            // 
            this.costoOC1Tarifarios.HeaderText = "COSTO 1";
            this.costoOC1Tarifarios.MinimumWidth = 10;
            this.costoOC1Tarifarios.Name = "costoOC1Tarifarios";
            this.costoOC1Tarifarios.Width = 138;
            // 
            // proveedorOC2Tarifarios
            // 
            this.proveedorOC2Tarifarios.HeaderText = "OTRAS CATEGORIAS 2";
            this.proveedorOC2Tarifarios.MinimumWidth = 10;
            this.proveedorOC2Tarifarios.Name = "proveedorOC2Tarifarios";
            this.proveedorOC2Tarifarios.Width = 264;
            // 
            // productoOC2Tarifarios
            // 
            this.productoOC2Tarifarios.HeaderText = "SERVICIO 2";
            this.productoOC2Tarifarios.MinimumWidth = 10;
            this.productoOC2Tarifarios.Name = "productoOC2Tarifarios";
            this.productoOC2Tarifarios.Width = 160;
            // 
            // costoOC2Tarifarios
            // 
            this.costoOC2Tarifarios.HeaderText = "COSTO 2";
            this.costoOC2Tarifarios.MinimumWidth = 10;
            this.costoOC2Tarifarios.Name = "costoOC2Tarifarios";
            this.costoOC2Tarifarios.Width = 138;
            // 
            // proveedorOC3Tarifarios
            // 
            this.proveedorOC3Tarifarios.HeaderText = "OTRAS CATEGORIAS 3";
            this.proveedorOC3Tarifarios.MinimumWidth = 10;
            this.proveedorOC3Tarifarios.Name = "proveedorOC3Tarifarios";
            this.proveedorOC3Tarifarios.Width = 264;
            // 
            // productoOC3Tarifarios
            // 
            this.productoOC3Tarifarios.HeaderText = "SERVICIO 3";
            this.productoOC3Tarifarios.MinimumWidth = 10;
            this.productoOC3Tarifarios.Name = "productoOC3Tarifarios";
            this.productoOC3Tarifarios.Width = 160;
            // 
            // costoOC3Tarifarios
            // 
            this.costoOC3Tarifarios.HeaderText = "COSTO 3";
            this.costoOC3Tarifarios.MinimumWidth = 10;
            this.costoOC3Tarifarios.Name = "costoOC3Tarifarios";
            this.costoOC3Tarifarios.Width = 138;
            // 
            // totalOCTarifarios
            // 
            this.totalOCTarifarios.HeaderText = "TOTAL";
            this.totalOCTarifarios.MinimumWidth = 10;
            this.totalOCTarifarios.Name = "totalOCTarifarios";
            this.totalOCTarifarios.Width = 125;
            // 
            // proveedorOS1Tarifarios
            // 
            this.proveedorOS1Tarifarios.HeaderText = "OTROS SERVICIOS 1";
            this.proveedorOS1Tarifarios.MinimumWidth = 10;
            this.proveedorOS1Tarifarios.Name = "proveedorOS1Tarifarios";
            this.proveedorOS1Tarifarios.Width = 244;
            // 
            // productoOS1Tarifarios
            // 
            this.productoOS1Tarifarios.HeaderText = "SERVICIO 1";
            this.productoOS1Tarifarios.MinimumWidth = 10;
            this.productoOS1Tarifarios.Name = "productoOS1Tarifarios";
            this.productoOS1Tarifarios.Width = 160;
            // 
            // costoOS1Tarifarios
            // 
            this.costoOS1Tarifarios.HeaderText = "COSTO 1";
            this.costoOS1Tarifarios.MinimumWidth = 10;
            this.costoOS1Tarifarios.Name = "costoOS1Tarifarios";
            this.costoOS1Tarifarios.Width = 138;
            // 
            // proveedorOS2Tarifarios
            // 
            this.proveedorOS2Tarifarios.HeaderText = "OTROS SERVICIOS 2";
            this.proveedorOS2Tarifarios.MinimumWidth = 10;
            this.proveedorOS2Tarifarios.Name = "proveedorOS2Tarifarios";
            this.proveedorOS2Tarifarios.Width = 244;
            // 
            // productoOS2Tarifarios
            // 
            this.productoOS2Tarifarios.HeaderText = "SERVICIO 2";
            this.productoOS2Tarifarios.MinimumWidth = 10;
            this.productoOS2Tarifarios.Name = "productoOS2Tarifarios";
            this.productoOS2Tarifarios.Width = 160;
            // 
            // costoOS2Tarifarios
            // 
            this.costoOS2Tarifarios.HeaderText = "COSTO 2";
            this.costoOS2Tarifarios.MinimumWidth = 10;
            this.costoOS2Tarifarios.Name = "costoOS2Tarifarios";
            this.costoOS2Tarifarios.Width = 138;
            // 
            // proveedorOS3Tarifarios
            // 
            this.proveedorOS3Tarifarios.HeaderText = "OTROS SERVICIOS 3";
            this.proveedorOS3Tarifarios.MinimumWidth = 10;
            this.proveedorOS3Tarifarios.Name = "proveedorOS3Tarifarios";
            this.proveedorOS3Tarifarios.Width = 244;
            // 
            // productoOS3Tarifarios
            // 
            this.productoOS3Tarifarios.HeaderText = "SERVICIO 3";
            this.productoOS3Tarifarios.MinimumWidth = 10;
            this.productoOS3Tarifarios.Name = "productoOS3Tarifarios";
            this.productoOS3Tarifarios.Width = 160;
            // 
            // costoOS3Tarifarios
            // 
            this.costoOS3Tarifarios.HeaderText = "COSTO 3";
            this.costoOS3Tarifarios.MinimumWidth = 10;
            this.costoOS3Tarifarios.Name = "costoOS3Tarifarios";
            this.costoOS3Tarifarios.Width = 138;
            // 
            // totalOSTarifarios
            // 
            this.totalOSTarifarios.HeaderText = "TOTAL";
            this.totalOSTarifarios.MinimumWidth = 10;
            this.totalOSTarifarios.Name = "totalOSTarifarios";
            this.totalOSTarifarios.Width = 125;
            // 
            // proveedorCargosDestino1Tarifarios
            // 
            this.proveedorCargosDestino1Tarifarios.HeaderText = "CARGOS DESTINO 1";
            this.proveedorCargosDestino1Tarifarios.MinimumWidth = 10;
            this.proveedorCargosDestino1Tarifarios.Name = "proveedorCargosDestino1Tarifarios";
            this.proveedorCargosDestino1Tarifarios.Width = 241;
            // 
            // costoCargoDestino1Tarifarios
            // 
            this.costoCargoDestino1Tarifarios.HeaderText = "COSTO 1";
            this.costoCargoDestino1Tarifarios.MinimumWidth = 10;
            this.costoCargoDestino1Tarifarios.Name = "costoCargoDestino1Tarifarios";
            this.costoCargoDestino1Tarifarios.Width = 138;
            // 
            // proveedorCargoDestino2Tarifarios
            // 
            this.proveedorCargoDestino2Tarifarios.HeaderText = "CARGOS DESTINO 2";
            this.proveedorCargoDestino2Tarifarios.MinimumWidth = 10;
            this.proveedorCargoDestino2Tarifarios.Name = "proveedorCargoDestino2Tarifarios";
            this.proveedorCargoDestino2Tarifarios.Width = 241;
            // 
            // costoCargoDestino2Tarifarios
            // 
            this.costoCargoDestino2Tarifarios.HeaderText = "COSTO 2";
            this.costoCargoDestino2Tarifarios.MinimumWidth = 10;
            this.costoCargoDestino2Tarifarios.Name = "costoCargoDestino2Tarifarios";
            this.costoCargoDestino2Tarifarios.Width = 138;
            // 
            // proveedorCargoDestino3Tarifarios
            // 
            this.proveedorCargoDestino3Tarifarios.HeaderText = "CARGOS DESTINO 3";
            this.proveedorCargoDestino3Tarifarios.MinimumWidth = 10;
            this.proveedorCargoDestino3Tarifarios.Name = "proveedorCargoDestino3Tarifarios";
            this.proveedorCargoDestino3Tarifarios.Width = 241;
            // 
            // costoCargoDestino3Tarifarios
            // 
            this.costoCargoDestino3Tarifarios.HeaderText = "COSTO 3";
            this.costoCargoDestino3Tarifarios.MinimumWidth = 10;
            this.costoCargoDestino3Tarifarios.Name = "costoCargoDestino3Tarifarios";
            this.costoCargoDestino3Tarifarios.Width = 138;
            // 
            // totalCargosDestinoTarifarios
            // 
            this.totalCargosDestinoTarifarios.HeaderText = "TOTAL";
            this.totalCargosDestinoTarifarios.MinimumWidth = 10;
            this.totalCargosDestinoTarifarios.Name = "totalCargosDestinoTarifarios";
            this.totalCargosDestinoTarifarios.Width = 125;
            // 
            // modalidadTarifarios
            // 
            this.modalidadTarifarios.HeaderText = "MODALIDAD";
            this.modalidadTarifarios.MinimumWidth = 10;
            this.modalidadTarifarios.Name = "modalidadTarifarios";
            this.modalidadTarifarios.Width = 181;
            // 
            // equipoTarifarios
            // 
            this.equipoTarifarios.HeaderText = "EQUIPO";
            this.equipoTarifarios.MinimumWidth = 10;
            this.equipoTarifarios.Name = "equipoTarifarios";
            this.equipoTarifarios.Width = 137;
            // 
            // desdeTarifarios
            // 
            this.desdeTarifarios.HeaderText = "DESDE";
            this.desdeTarifarios.MinimumWidth = 10;
            this.desdeTarifarios.Name = "desdeTarifarios";
            this.desdeTarifarios.Width = 129;
            // 
            // hastaTarifarios
            // 
            this.hastaTarifarios.HeaderText = "HASTA";
            this.hastaTarifarios.MinimumWidth = 10;
            this.hastaTarifarios.Name = "hastaTarifarios";
            this.hastaTarifarios.Width = 127;
            // 
            // totalTarifarios
            // 
            this.totalTarifarios.HeaderText = "TOTAL TARIFARIOS";
            this.totalTarifarios.MinimumWidth = 10;
            this.totalTarifarios.Name = "totalTarifarios";
            this.totalTarifarios.Width = 234;
            // 
            // tbpTarifas
            // 
            this.tbpTarifas.Controls.Add(this.btnEliminarTodoLCL);
            this.tbpTarifas.Controls.Add(this.btnEliminarLCL);
            this.tbpTarifas.Controls.Add(this.txtBuscarLCL);
            this.tbpTarifas.Controls.Add(this.label7);
            this.tbpTarifas.Controls.Add(this.label8);
            this.tbpTarifas.Controls.Add(this.label9);
            this.tbpTarifas.Controls.Add(this.dtpHastaLCL);
            this.tbpTarifas.Controls.Add(this.dtpDesdeLCL);
            this.tbpTarifas.Controls.Add(this.dgvLCL);
            this.tbpTarifas.Location = new System.Drawing.Point(8, 39);
            this.tbpTarifas.Name = "tbpTarifas";
            this.tbpTarifas.Padding = new System.Windows.Forms.Padding(3);
            this.tbpTarifas.Size = new System.Drawing.Size(1697, 1167);
            this.tbpTarifas.TabIndex = 1;
            this.tbpTarifas.Text = "LCL";
            this.tbpTarifas.UseVisualStyleBackColor = true;
            // 
            // tbpCompetencia
            // 
            this.tbpCompetencia.Controls.Add(this.btnEliminarTodoCompetencia);
            this.tbpCompetencia.Controls.Add(this.btnEliminarCompetencia);
            this.tbpCompetencia.Controls.Add(this.txtBuscarCompetencia);
            this.tbpCompetencia.Controls.Add(this.label4);
            this.tbpCompetencia.Controls.Add(this.label5);
            this.tbpCompetencia.Controls.Add(this.label6);
            this.tbpCompetencia.Controls.Add(this.dtpHastaCompetencia);
            this.tbpCompetencia.Controls.Add(this.dtpDesdeCompetencia);
            this.tbpCompetencia.Controls.Add(this.dgvCompetencia);
            this.tbpCompetencia.Location = new System.Drawing.Point(8, 39);
            this.tbpCompetencia.Name = "tbpCompetencia";
            this.tbpCompetencia.Padding = new System.Windows.Forms.Padding(3);
            this.tbpCompetencia.Size = new System.Drawing.Size(1697, 1167);
            this.tbpCompetencia.TabIndex = 2;
            this.tbpCompetencia.Text = "COMPETENCIA";
            this.tbpCompetencia.UseVisualStyleBackColor = true;
            // 
            // btnEliminarTodoCompetencia
            // 
            this.btnEliminarTodoCompetencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarTodoCompetencia.Location = new System.Drawing.Point(1324, 52);
            this.btnEliminarTodoCompetencia.Name = "btnEliminarTodoCompetencia";
            this.btnEliminarTodoCompetencia.Size = new System.Drawing.Size(178, 77);
            this.btnEliminarTodoCompetencia.TabIndex = 10;
            this.btnEliminarTodoCompetencia.Text = "ELIMINAR TODO";
            this.btnEliminarTodoCompetencia.UseVisualStyleBackColor = true;
            this.btnEliminarTodoCompetencia.Click += new System.EventHandler(this.btnEliminarTodoCompetencia_Click);
            // 
            // btnEliminarCompetencia
            // 
            this.btnEliminarCompetencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarCompetencia.Location = new System.Drawing.Point(951, 52);
            this.btnEliminarCompetencia.Name = "btnEliminarCompetencia";
            this.btnEliminarCompetencia.Size = new System.Drawing.Size(178, 77);
            this.btnEliminarCompetencia.TabIndex = 9;
            this.btnEliminarCompetencia.Text = "ELIMINAR";
            this.btnEliminarCompetencia.UseVisualStyleBackColor = true;
            this.btnEliminarCompetencia.Click += new System.EventHandler(this.btnEliminarCompetencia_Click);
            // 
            // txtBuscarCompetencia
            // 
            this.txtBuscarCompetencia.Location = new System.Drawing.Point(67, 272);
            this.txtBuscarCompetencia.Name = "txtBuscarCompetencia";
            this.txtBuscarCompetencia.Size = new System.Drawing.Size(626, 31);
            this.txtBuscarCompetencia.TabIndex = 8;
            this.txtBuscarCompetencia.TextChanged += new System.EventHandler(this.txtBuscarCompetencia_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1316, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 46);
            this.label4.TabIndex = 7;
            this.label4.Text = "HASTA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(943, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 46);
            this.label5.TabIndex = 6;
            this.label5.Text = "DESDE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(59, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(188, 46);
            this.label6.TabIndex = 5;
            this.label6.Text = "BUSCAR";
            // 
            // dtpHastaCompetencia
            // 
            this.dtpHastaCompetencia.CustomFormat = "yyyy-MM-dd";
            this.dtpHastaCompetencia.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHastaCompetencia.Location = new System.Drawing.Point(1324, 270);
            this.dtpHastaCompetencia.Name = "dtpHastaCompetencia";
            this.dtpHastaCompetencia.Size = new System.Drawing.Size(299, 31);
            this.dtpHastaCompetencia.TabIndex = 4;
            this.dtpHastaCompetencia.ValueChanged += new System.EventHandler(this.dtpHastaCompetencia_ValueChanged);
            // 
            // dtpDesdeCompetencia
            // 
            this.dtpDesdeCompetencia.CustomFormat = "yyyy-MM-dd";
            this.dtpDesdeCompetencia.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDesdeCompetencia.Location = new System.Drawing.Point(951, 270);
            this.dtpDesdeCompetencia.Name = "dtpDesdeCompetencia";
            this.dtpDesdeCompetencia.Size = new System.Drawing.Size(299, 31);
            this.dtpDesdeCompetencia.TabIndex = 3;
            this.dtpDesdeCompetencia.ValueChanged += new System.EventHandler(this.dtpDesdeCompetencia_ValueChanged);
            // 
            // dgvCompetencia
            // 
            this.dgvCompetencia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvCompetencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompetencia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCompetencia,
            this.nombreCompetencia,
            this.rutaCompetencia,
            this.fleteCompetencia,
            this.cargosDestinoCompetencia,
            this.otrosCostosCompetencia,
            this.ivaCompetencia,
            this.modalidadCompetencia,
            this.equipoCompetencia,
            this.desdeCompetencia,
            this.hastaCompetencia,
            this.totalCompetencia});
            this.dgvCompetencia.Location = new System.Drawing.Point(0, 420);
            this.dgvCompetencia.Name = "dgvCompetencia";
            this.dgvCompetencia.RowHeadersWidth = 82;
            this.dgvCompetencia.RowTemplate.Height = 33;
            this.dgvCompetencia.Size = new System.Drawing.Size(1684, 667);
            this.dgvCompetencia.TabIndex = 2;
            this.dgvCompetencia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCompetencia_CellClick);
            // 
            // idCompetencia
            // 
            this.idCompetencia.HeaderText = "ID";
            this.idCompetencia.MinimumWidth = 10;
            this.idCompetencia.Name = "idCompetencia";
            this.idCompetencia.Width = 77;
            // 
            // nombreCompetencia
            // 
            this.nombreCompetencia.HeaderText = "NOMBRE";
            this.nombreCompetencia.MinimumWidth = 10;
            this.nombreCompetencia.Name = "nombreCompetencia";
            this.nombreCompetencia.Width = 149;
            // 
            // rutaCompetencia
            // 
            this.rutaCompetencia.HeaderText = "RUTA";
            this.rutaCompetencia.MinimumWidth = 10;
            this.rutaCompetencia.Name = "rutaCompetencia";
            this.rutaCompetencia.Width = 114;
            // 
            // fleteCompetencia
            // 
            this.fleteCompetencia.HeaderText = "FLETE";
            this.fleteCompetencia.MinimumWidth = 10;
            this.fleteCompetencia.Name = "fleteCompetencia";
            this.fleteCompetencia.Width = 123;
            // 
            // cargosDestinoCompetencia
            // 
            this.cargosDestinoCompetencia.HeaderText = "CARGOS DESTINO";
            this.cargosDestinoCompetencia.MinimumWidth = 10;
            this.cargosDestinoCompetencia.Name = "cargosDestinoCompetencia";
            this.cargosDestinoCompetencia.Width = 225;
            // 
            // otrosCostosCompetencia
            // 
            this.otrosCostosCompetencia.HeaderText = "OTROS COSTOS";
            this.otrosCostosCompetencia.MinimumWidth = 10;
            this.otrosCostosCompetencia.Name = "otrosCostosCompetencia";
            this.otrosCostosCompetencia.Width = 207;
            // 
            // ivaCompetencia
            // 
            this.ivaCompetencia.HeaderText = "IVA";
            this.ivaCompetencia.MinimumWidth = 10;
            this.ivaCompetencia.Name = "ivaCompetencia";
            this.ivaCompetencia.Width = 90;
            // 
            // modalidadCompetencia
            // 
            this.modalidadCompetencia.HeaderText = "MODALIDAD";
            this.modalidadCompetencia.MinimumWidth = 10;
            this.modalidadCompetencia.Name = "modalidadCompetencia";
            this.modalidadCompetencia.Width = 181;
            // 
            // equipoCompetencia
            // 
            this.equipoCompetencia.HeaderText = "EQUIPO";
            this.equipoCompetencia.MinimumWidth = 10;
            this.equipoCompetencia.Name = "equipoCompetencia";
            this.equipoCompetencia.Width = 137;
            // 
            // desdeCompetencia
            // 
            this.desdeCompetencia.HeaderText = "DESDE";
            this.desdeCompetencia.MinimumWidth = 10;
            this.desdeCompetencia.Name = "desdeCompetencia";
            this.desdeCompetencia.Width = 129;
            // 
            // hastaCompetencia
            // 
            this.hastaCompetencia.HeaderText = "HASTA";
            this.hastaCompetencia.MinimumWidth = 10;
            this.hastaCompetencia.Name = "hastaCompetencia";
            this.hastaCompetencia.Width = 127;
            // 
            // totalCompetencia
            // 
            this.totalCompetencia.HeaderText = "TOTAL TARIFARIOS";
            this.totalCompetencia.MinimumWidth = 10;
            this.totalCompetencia.Name = "totalCompetencia";
            this.totalCompetencia.Width = 234;
            // 
            // btnEliminarTodoLCL
            // 
            this.btnEliminarTodoLCL.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarTodoLCL.Location = new System.Drawing.Point(1330, 66);
            this.btnEliminarTodoLCL.Name = "btnEliminarTodoLCL";
            this.btnEliminarTodoLCL.Size = new System.Drawing.Size(178, 77);
            this.btnEliminarTodoLCL.TabIndex = 19;
            this.btnEliminarTodoLCL.Text = "ELIMINAR TODO";
            this.btnEliminarTodoLCL.UseVisualStyleBackColor = true;
            this.btnEliminarTodoLCL.Click += new System.EventHandler(this.btnEliminarTodoLCL_Click);
            // 
            // btnEliminarLCL
            // 
            this.btnEliminarLCL.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarLCL.Location = new System.Drawing.Point(957, 66);
            this.btnEliminarLCL.Name = "btnEliminarLCL";
            this.btnEliminarLCL.Size = new System.Drawing.Size(178, 77);
            this.btnEliminarLCL.TabIndex = 18;
            this.btnEliminarLCL.Text = "ELIMINAR";
            this.btnEliminarLCL.UseVisualStyleBackColor = true;
            this.btnEliminarLCL.Click += new System.EventHandler(this.btnEliminarLCL_Click);
            // 
            // txtBuscarLCL
            // 
            this.txtBuscarLCL.Location = new System.Drawing.Point(73, 286);
            this.txtBuscarLCL.Name = "txtBuscarLCL";
            this.txtBuscarLCL.Size = new System.Drawing.Size(626, 31);
            this.txtBuscarLCL.TabIndex = 17;
            this.txtBuscarLCL.TextChanged += new System.EventHandler(this.txtBuscarLCL_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1322, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 46);
            this.label7.TabIndex = 16;
            this.label7.Text = "HASTA";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(949, 203);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(159, 46);
            this.label8.TabIndex = 15;
            this.label8.Text = "DESDE";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(65, 205);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(188, 46);
            this.label9.TabIndex = 14;
            this.label9.Text = "BUSCAR";
            // 
            // dtpHastaLCL
            // 
            this.dtpHastaLCL.CustomFormat = "yyyy-MM-dd";
            this.dtpHastaLCL.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHastaLCL.Location = new System.Drawing.Point(1330, 284);
            this.dtpHastaLCL.Name = "dtpHastaLCL";
            this.dtpHastaLCL.Size = new System.Drawing.Size(299, 31);
            this.dtpHastaLCL.TabIndex = 13;
            this.dtpHastaLCL.ValueChanged += new System.EventHandler(this.dtpHastaLCL_ValueChanged);
            // 
            // dtpDesdeLCL
            // 
            this.dtpDesdeLCL.CustomFormat = "yyyy-MM-dd";
            this.dtpDesdeLCL.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDesdeLCL.Location = new System.Drawing.Point(957, 284);
            this.dtpDesdeLCL.Name = "dtpDesdeLCL";
            this.dtpDesdeLCL.Size = new System.Drawing.Size(299, 31);
            this.dtpDesdeLCL.TabIndex = 12;
            this.dtpDesdeLCL.ValueChanged += new System.EventHandler(this.dtpDesdeLCL_ValueChanged);
            // 
            // dgvLCL
            // 
            this.dgvLCL.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvLCL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLCL.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idLCL,
            this.rutaLCL,
            this.proveedorAgenteOrigenLCL,
            this.manejosAgenteOrigenLCL,
            this.hblAgenteOrigenLCL,
            this.proveedorFleteInternacionalLCL,
            this.thcDCbmFleteInternacionalLCL,
            this.thcDMinimoFleteInternacionalLCL,
            this.vgmMinimoFleteInternacionalLCL,
            this.bunkerCbmFleteInternacionalLCL,
            this.bunkerMinimoFleteInternacionalLCL,
            this.sedMinimoFleteInternacionalLCL,
            this.tcaMinimoFleteInternacionalLCL,
            this.forwardingMinimoFleteInternacionalLCL,
            this.ManejosMinimoFleteInternacionalLCL,
            this.cargaPeligrosaMinimoFleteInternacionalLCL,
            this.proveedorCargosEnDestinoLCL,
            this.cargosCargosEnDestinoLCL,
            this.proveedorMovimientoBodegaLCL,
            this.transporteBodegaMovimientoBodegaLCL,
            this.proveedorOC1LCL,
            this.productoOC1LCL,
            this.costoOC1LCL,
            this.proveedorOC2LCL,
            this.productoOC2LCL,
            this.costoOC2LCL,
            this.proveedorOC3LCL,
            this.productoOC3LCL,
            this.costoOC3LCL,
            this.proveedorCargoDestino1LCL,
            this.costoCargoDestino1LCL,
            this.proveedorCargoDestino2LCL,
            this.costoCargoDestino2LCL,
            this.proveedorCargoDestino23LCL,
            this.costoCargoDestino3LCL,
            this.modalidadLCL,
            this.equipoLCL,
            this.desdeLCL,
            this.hastaLCL,
            this.totalFleteCbmLCL,
            this.totalFleteMinimoLCL,
            this.totalOtrosCostosCbmLCL,
            this.totalOtrosCostosMinimosLCL,
            this.totalOtrosCostosFlatCL});
            this.dgvLCL.Location = new System.Drawing.Point(6, 434);
            this.dgvLCL.Name = "dgvLCL";
            this.dgvLCL.RowHeadersWidth = 82;
            this.dgvLCL.RowTemplate.Height = 33;
            this.dgvLCL.Size = new System.Drawing.Size(1684, 667);
            this.dgvLCL.TabIndex = 11;
            this.dgvLCL.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLCL_CellClick);
            // 
            // idLCL
            // 
            this.idLCL.HeaderText = "ID";
            this.idLCL.MinimumWidth = 10;
            this.idLCL.Name = "idLCL";
            this.idLCL.Width = 77;
            // 
            // rutaLCL
            // 
            this.rutaLCL.HeaderText = "RUTA";
            this.rutaLCL.MinimumWidth = 10;
            this.rutaLCL.Name = "rutaLCL";
            this.rutaLCL.Width = 114;
            // 
            // proveedorAgenteOrigenLCL
            // 
            this.proveedorAgenteOrigenLCL.HeaderText = "AGENTE ORIGEN";
            this.proveedorAgenteOrigenLCL.MinimumWidth = 10;
            this.proveedorAgenteOrigenLCL.Name = "proveedorAgenteOrigenLCL";
            this.proveedorAgenteOrigenLCL.Width = 211;
            // 
            // manejosAgenteOrigenLCL
            // 
            this.manejosAgenteOrigenLCL.HeaderText = "MANEJOS";
            this.manejosAgenteOrigenLCL.MinimumWidth = 10;
            this.manejosAgenteOrigenLCL.Name = "manejosAgenteOrigenLCL";
            this.manejosAgenteOrigenLCL.Width = 159;
            // 
            // hblAgenteOrigenLCL
            // 
            this.hblAgenteOrigenLCL.HeaderText = "HBL";
            this.hblAgenteOrigenLCL.MinimumWidth = 10;
            this.hblAgenteOrigenLCL.Name = "hblAgenteOrigenLCL";
            this.hblAgenteOrigenLCL.Width = 98;
            // 
            // proveedorFleteInternacionalLCL
            // 
            this.proveedorFleteInternacionalLCL.HeaderText = "FLETE INTERNACIONAL";
            this.proveedorFleteInternacionalLCL.MinimumWidth = 10;
            this.proveedorFleteInternacionalLCL.Name = "proveedorFleteInternacionalLCL";
            this.proveedorFleteInternacionalLCL.Width = 271;
            // 
            // thcDCbmFleteInternacionalLCL
            // 
            this.thcDCbmFleteInternacionalLCL.HeaderText = "THC/D x CBM";
            this.thcDCbmFleteInternacionalLCL.MinimumWidth = 10;
            this.thcDCbmFleteInternacionalLCL.Name = "thcDCbmFleteInternacionalLCL";
            this.thcDCbmFleteInternacionalLCL.Width = 134;
            // 
            // thcDMinimoFleteInternacionalLCL
            // 
            this.thcDMinimoFleteInternacionalLCL.HeaderText = "THC/D MINIMO";
            this.thcDMinimoFleteInternacionalLCL.MinimumWidth = 10;
            this.thcDMinimoFleteInternacionalLCL.Name = "thcDMinimoFleteInternacionalLCL";
            this.thcDMinimoFleteInternacionalLCL.Width = 188;
            // 
            // vgmMinimoFleteInternacionalLCL
            // 
            this.vgmMinimoFleteInternacionalLCL.HeaderText = "VGM MINIMO";
            this.vgmMinimoFleteInternacionalLCL.MinimumWidth = 10;
            this.vgmMinimoFleteInternacionalLCL.Name = "vgmMinimoFleteInternacionalLCL";
            this.vgmMinimoFleteInternacionalLCL.Width = 173;
            // 
            // bunkerCbmFleteInternacionalLCL
            // 
            this.bunkerCbmFleteInternacionalLCL.HeaderText = "BUNKER x CBM";
            this.bunkerCbmFleteInternacionalLCL.MinimumWidth = 10;
            this.bunkerCbmFleteInternacionalLCL.Name = "bunkerCbmFleteInternacionalLCL";
            this.bunkerCbmFleteInternacionalLCL.Width = 154;
            // 
            // bunkerMinimoFleteInternacionalLCL
            // 
            this.bunkerMinimoFleteInternacionalLCL.HeaderText = "BUNKER MINIMO";
            this.bunkerMinimoFleteInternacionalLCL.MinimumWidth = 10;
            this.bunkerMinimoFleteInternacionalLCL.Name = "bunkerMinimoFleteInternacionalLCL";
            this.bunkerMinimoFleteInternacionalLCL.Width = 208;
            // 
            // sedMinimoFleteInternacionalLCL
            // 
            this.sedMinimoFleteInternacionalLCL.HeaderText = "SED MINIMO";
            this.sedMinimoFleteInternacionalLCL.MinimumWidth = 10;
            this.sedMinimoFleteInternacionalLCL.Name = "sedMinimoFleteInternacionalLCL";
            this.sedMinimoFleteInternacionalLCL.Width = 169;
            // 
            // tcaMinimoFleteInternacionalLCL
            // 
            this.tcaMinimoFleteInternacionalLCL.HeaderText = "TICA MINIMO";
            this.tcaMinimoFleteInternacionalLCL.MinimumWidth = 10;
            this.tcaMinimoFleteInternacionalLCL.Name = "tcaMinimoFleteInternacionalLCL";
            this.tcaMinimoFleteInternacionalLCL.Width = 172;
            // 
            // forwardingMinimoFleteInternacionalLCL
            // 
            this.forwardingMinimoFleteInternacionalLCL.HeaderText = "FORWARDING MINIMO";
            this.forwardingMinimoFleteInternacionalLCL.MinimumWidth = 10;
            this.forwardingMinimoFleteInternacionalLCL.Name = "forwardingMinimoFleteInternacionalLCL";
            this.forwardingMinimoFleteInternacionalLCL.Width = 260;
            // 
            // ManejosMinimoFleteInternacionalLCL
            // 
            this.ManejosMinimoFleteInternacionalLCL.HeaderText = "MANEJOS MINIMO";
            this.ManejosMinimoFleteInternacionalLCL.MinimumWidth = 10;
            this.ManejosMinimoFleteInternacionalLCL.Name = "ManejosMinimoFleteInternacionalLCL";
            this.ManejosMinimoFleteInternacionalLCL.Width = 222;
            // 
            // cargaPeligrosaMinimoFleteInternacionalLCL
            // 
            this.cargaPeligrosaMinimoFleteInternacionalLCL.HeaderText = "CARGA PELIGROSA MINIMO";
            this.cargaPeligrosaMinimoFleteInternacionalLCL.MinimumWidth = 10;
            this.cargaPeligrosaMinimoFleteInternacionalLCL.Name = "cargaPeligrosaMinimoFleteInternacionalLCL";
            this.cargaPeligrosaMinimoFleteInternacionalLCL.Width = 310;
            // 
            // proveedorCargosEnDestinoLCL
            // 
            this.proveedorCargosEnDestinoLCL.HeaderText = "CARGOS EN DESTINO";
            this.proveedorCargosEnDestinoLCL.MinimumWidth = 10;
            this.proveedorCargosEnDestinoLCL.Name = "proveedorCargosEnDestinoLCL";
            this.proveedorCargosEnDestinoLCL.Width = 256;
            // 
            // cargosCargosEnDestinoLCL
            // 
            this.cargosCargosEnDestinoLCL.HeaderText = "CARGOS";
            this.cargosCargosEnDestinoLCL.MinimumWidth = 10;
            this.cargosCargosEnDestinoLCL.Name = "cargosCargosEnDestinoLCL";
            this.cargosCargosEnDestinoLCL.Width = 147;
            // 
            // proveedorMovimientoBodegaLCL
            // 
            this.proveedorMovimientoBodegaLCL.HeaderText = "MOVIMIENTO BODEGA";
            this.proveedorMovimientoBodegaLCL.MinimumWidth = 10;
            this.proveedorMovimientoBodegaLCL.Name = "proveedorMovimientoBodegaLCL";
            this.proveedorMovimientoBodegaLCL.Width = 261;
            // 
            // transporteBodegaMovimientoBodegaLCL
            // 
            this.transporteBodegaMovimientoBodegaLCL.HeaderText = "TRANSPORTE BODEGA";
            this.transporteBodegaMovimientoBodegaLCL.MinimumWidth = 10;
            this.transporteBodegaMovimientoBodegaLCL.Name = "transporteBodegaMovimientoBodegaLCL";
            this.transporteBodegaMovimientoBodegaLCL.Width = 270;
            // 
            // proveedorOC1LCL
            // 
            this.proveedorOC1LCL.HeaderText = "OTRAS CATEGORIAS 1";
            this.proveedorOC1LCL.MinimumWidth = 10;
            this.proveedorOC1LCL.Name = "proveedorOC1LCL";
            this.proveedorOC1LCL.Width = 264;
            // 
            // productoOC1LCL
            // 
            this.productoOC1LCL.HeaderText = "SERVICIO 1";
            this.productoOC1LCL.MinimumWidth = 10;
            this.productoOC1LCL.Name = "productoOC1LCL";
            this.productoOC1LCL.Width = 160;
            // 
            // costoOC1LCL
            // 
            this.costoOC1LCL.HeaderText = "COSTO 1";
            this.costoOC1LCL.MinimumWidth = 10;
            this.costoOC1LCL.Name = "costoOC1LCL";
            this.costoOC1LCL.Width = 138;
            // 
            // proveedorOC2LCL
            // 
            this.proveedorOC2LCL.HeaderText = "OTRAS CATEGORIAS 2";
            this.proveedorOC2LCL.MinimumWidth = 10;
            this.proveedorOC2LCL.Name = "proveedorOC2LCL";
            this.proveedorOC2LCL.Width = 264;
            // 
            // productoOC2LCL
            // 
            this.productoOC2LCL.HeaderText = "SERVICIO 2";
            this.productoOC2LCL.MinimumWidth = 10;
            this.productoOC2LCL.Name = "productoOC2LCL";
            this.productoOC2LCL.Width = 160;
            // 
            // costoOC2LCL
            // 
            this.costoOC2LCL.HeaderText = "COSTO 2";
            this.costoOC2LCL.MinimumWidth = 10;
            this.costoOC2LCL.Name = "costoOC2LCL";
            this.costoOC2LCL.Width = 138;
            // 
            // proveedorOC3LCL
            // 
            this.proveedorOC3LCL.HeaderText = "OTRAS CATEGORIAS 3";
            this.proveedorOC3LCL.MinimumWidth = 10;
            this.proveedorOC3LCL.Name = "proveedorOC3LCL";
            this.proveedorOC3LCL.Width = 264;
            // 
            // productoOC3LCL
            // 
            this.productoOC3LCL.HeaderText = "SERVICIO 3";
            this.productoOC3LCL.MinimumWidth = 10;
            this.productoOC3LCL.Name = "productoOC3LCL";
            this.productoOC3LCL.Width = 160;
            // 
            // costoOC3LCL
            // 
            this.costoOC3LCL.HeaderText = "COSTO 3";
            this.costoOC3LCL.MinimumWidth = 10;
            this.costoOC3LCL.Name = "costoOC3LCL";
            this.costoOC3LCL.Width = 138;
            // 
            // proveedorCargoDestino1LCL
            // 
            this.proveedorCargoDestino1LCL.HeaderText = "CARGOS DESTINO 1";
            this.proveedorCargoDestino1LCL.MinimumWidth = 10;
            this.proveedorCargoDestino1LCL.Name = "proveedorCargoDestino1LCL";
            this.proveedorCargoDestino1LCL.Width = 241;
            // 
            // costoCargoDestino1LCL
            // 
            this.costoCargoDestino1LCL.HeaderText = "COSTO 1";
            this.costoCargoDestino1LCL.MinimumWidth = 10;
            this.costoCargoDestino1LCL.Name = "costoCargoDestino1LCL";
            this.costoCargoDestino1LCL.Width = 138;
            // 
            // proveedorCargoDestino2LCL
            // 
            this.proveedorCargoDestino2LCL.HeaderText = "CARGOS DESTINO 2";
            this.proveedorCargoDestino2LCL.MinimumWidth = 10;
            this.proveedorCargoDestino2LCL.Name = "proveedorCargoDestino2LCL";
            this.proveedorCargoDestino2LCL.Width = 241;
            // 
            // costoCargoDestino2LCL
            // 
            this.costoCargoDestino2LCL.HeaderText = "COSTO 2";
            this.costoCargoDestino2LCL.MinimumWidth = 10;
            this.costoCargoDestino2LCL.Name = "costoCargoDestino2LCL";
            this.costoCargoDestino2LCL.Width = 138;
            // 
            // proveedorCargoDestino23LCL
            // 
            this.proveedorCargoDestino23LCL.HeaderText = "CARGOS DESTINO 3";
            this.proveedorCargoDestino23LCL.MinimumWidth = 10;
            this.proveedorCargoDestino23LCL.Name = "proveedorCargoDestino23LCL";
            this.proveedorCargoDestino23LCL.Width = 241;
            // 
            // costoCargoDestino3LCL
            // 
            this.costoCargoDestino3LCL.HeaderText = "COSTO 3";
            this.costoCargoDestino3LCL.MinimumWidth = 10;
            this.costoCargoDestino3LCL.Name = "costoCargoDestino3LCL";
            this.costoCargoDestino3LCL.Width = 138;
            // 
            // modalidadLCL
            // 
            this.modalidadLCL.HeaderText = "MODALIDAD";
            this.modalidadLCL.MinimumWidth = 10;
            this.modalidadLCL.Name = "modalidadLCL";
            this.modalidadLCL.Width = 181;
            // 
            // equipoLCL
            // 
            this.equipoLCL.HeaderText = "EQUIPO";
            this.equipoLCL.MinimumWidth = 10;
            this.equipoLCL.Name = "equipoLCL";
            this.equipoLCL.Width = 137;
            // 
            // desdeLCL
            // 
            this.desdeLCL.HeaderText = "DESDE";
            this.desdeLCL.MinimumWidth = 10;
            this.desdeLCL.Name = "desdeLCL";
            this.desdeLCL.Width = 129;
            // 
            // hastaLCL
            // 
            this.hastaLCL.HeaderText = "HASTA";
            this.hastaLCL.MinimumWidth = 10;
            this.hastaLCL.Name = "hastaLCL";
            this.hastaLCL.Width = 127;
            // 
            // totalFleteCbmLCL
            // 
            this.totalFleteCbmLCL.HeaderText = "TOTAL FLETE CBM";
            this.totalFleteCbmLCL.MinimumWidth = 10;
            this.totalFleteCbmLCL.Name = "totalFleteCbmLCL";
            this.totalFleteCbmLCL.Width = 187;
            // 
            // totalFleteMinimoLCL
            // 
            this.totalFleteMinimoLCL.HeaderText = "TOTAL FLETE MINIMO";
            this.totalFleteMinimoLCL.MinimumWidth = 10;
            this.totalFleteMinimoLCL.Name = "totalFleteMinimoLCL";
            this.totalFleteMinimoLCL.Width = 256;
            // 
            // totalOtrosCostosCbmLCL
            // 
            this.totalOtrosCostosCbmLCL.HeaderText = "TOTAL OTROS COSTOS CBM";
            this.totalOtrosCostosCbmLCL.MinimumWidth = 10;
            this.totalOtrosCostosCbmLCL.Name = "totalOtrosCostosCbmLCL";
            this.totalOtrosCostosCbmLCL.Width = 279;
            // 
            // totalOtrosCostosMinimosLCL
            // 
            this.totalOtrosCostosMinimosLCL.HeaderText = "TOTAL OTROS COSTOS MINIMOS";
            this.totalOtrosCostosMinimosLCL.MinimumWidth = 10;
            this.totalOtrosCostosMinimosLCL.Name = "totalOtrosCostosMinimosLCL";
            this.totalOtrosCostosMinimosLCL.Width = 279;
            // 
            // totalOtrosCostosFlatCL
            // 
            this.totalOtrosCostosFlatCL.HeaderText = "TOTAL OTROS COSTOS FLAT";
            this.totalOtrosCostosFlatCL.MinimumWidth = 10;
            this.totalOtrosCostosFlatCL.Name = "totalOtrosCostosFlatCL";
            this.totalOtrosCostosFlatCL.Width = 279;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2045, 1443);
            this.Controls.Add(this.pnlDesktop);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(2071, 1514);
            this.MinimumSize = new System.Drawing.Size(2071, 1514);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.pnlDesktop.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tbpTarifarios.ResumeLayout(false);
            this.tbpTarifarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarifarios)).EndInit();
            this.tbpTarifas.ResumeLayout(false);
            this.tbpTarifas.PerformLayout();
            this.tbpCompetencia.ResumeLayout(false);
            this.tbpCompetencia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompetencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLCL)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnAgregarDatos;
        private System.Windows.Forms.Button btnLcl;
        private System.Windows.Forms.Button btnTarifarios;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel pnlDesktop;
        private FontAwesome.Sharp.IconButton btnSalir;
        private FontAwesome.Sharp.IconButton btnMinimizar;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbpTarifarios;
        private System.Windows.Forms.TabPage tbpTarifas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.DataGridView dgvTarifarios;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTarifario;
        private System.Windows.Forms.DataGridViewTextBoxColumn rutaTarifarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn proveedorAgenteOrigenTarifarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn manejosAgenteOrigenTarifarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn hblAgenteOrigenTarifarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalAgenteOrigenTarifarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn proveedorFleteInternacionalTarifario;
        private System.Windows.Forms.DataGridViewTextBoxColumn thcFleteInternacionalTarifarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn docFeeFleteInternacionalTarifarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn securityFleteInternacionalTarifarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn impresionBlFleteInternacionalTarifarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn portFacilityFleteInternacional;
        private System.Windows.Forms.DataGridViewTextBoxColumn canalFeeFleteInternacionalTarifarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn vacFleteInternacionalTarifarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn impdoFleteInternacionalTarifarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn merchantFleteInternacionalTarifarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn fleteTotalFleteInternacionalTarifarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalFleteInternacionalTarifarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn proveedorGastosPortuariosTarifarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn manejosPuertoGastosPortuariosTarifarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalGastosPortuariosTarifarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn proveedorMovimientoPuertoBodegaTarifarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn transportePuertoMovimientoPuertoBodegaTarifarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalMovimientoPuertoBodegaTarifarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn proveedorOC1Tarifarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn productoOC1Tarifarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoOC1Tarifarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn proveedorOC2Tarifarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn productoOC2Tarifarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoOC2Tarifarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn proveedorOC3Tarifarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn productoOC3Tarifarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoOC3Tarifarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalOCTarifarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn proveedorOS1Tarifarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn productoOS1Tarifarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoOS1Tarifarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn proveedorOS2Tarifarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn productoOS2Tarifarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoOS2Tarifarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn proveedorOS3Tarifarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn productoOS3Tarifarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoOS3Tarifarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalOSTarifarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn proveedorCargosDestino1Tarifarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoCargoDestino1Tarifarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn proveedorCargoDestino2Tarifarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoCargoDestino2Tarifarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn proveedorCargoDestino3Tarifarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoCargoDestino3Tarifarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalCargosDestinoTarifarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn modalidadTarifarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipoTarifarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn desdeTarifarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn hastaTarifarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalTarifarios;
        private System.Windows.Forms.Button btnCompetencia;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEliminarTodo;
        private System.Windows.Forms.TabPage tbpCompetencia;
        private System.Windows.Forms.Button btnEliminarTodoCompetencia;
        private System.Windows.Forms.Button btnEliminarCompetencia;
        private System.Windows.Forms.TextBox txtBuscarCompetencia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpHastaCompetencia;
        private System.Windows.Forms.DateTimePicker dtpDesdeCompetencia;
        private System.Windows.Forms.DataGridView dgvCompetencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCompetencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCompetencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn rutaCompetencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn fleteCompetencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargosDestinoCompetencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn otrosCostosCompetencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ivaCompetencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn modalidadCompetencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipoCompetencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn desdeCompetencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn hastaCompetencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalCompetencia;
        private System.Windows.Forms.Button btnEliminarTodoLCL;
        private System.Windows.Forms.Button btnEliminarLCL;
        private System.Windows.Forms.TextBox txtBuscarLCL;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpHastaLCL;
        private System.Windows.Forms.DateTimePicker dtpDesdeLCL;
        private System.Windows.Forms.DataGridView dgvLCL;
        private System.Windows.Forms.DataGridViewTextBoxColumn idLCL;
        private System.Windows.Forms.DataGridViewTextBoxColumn rutaLCL;
        private System.Windows.Forms.DataGridViewTextBoxColumn proveedorAgenteOrigenLCL;
        private System.Windows.Forms.DataGridViewTextBoxColumn manejosAgenteOrigenLCL;
        private System.Windows.Forms.DataGridViewTextBoxColumn hblAgenteOrigenLCL;
        private System.Windows.Forms.DataGridViewTextBoxColumn proveedorFleteInternacionalLCL;
        private System.Windows.Forms.DataGridViewTextBoxColumn thcDCbmFleteInternacionalLCL;
        private System.Windows.Forms.DataGridViewTextBoxColumn thcDMinimoFleteInternacionalLCL;
        private System.Windows.Forms.DataGridViewTextBoxColumn vgmMinimoFleteInternacionalLCL;
        private System.Windows.Forms.DataGridViewTextBoxColumn bunkerCbmFleteInternacionalLCL;
        private System.Windows.Forms.DataGridViewTextBoxColumn bunkerMinimoFleteInternacionalLCL;
        private System.Windows.Forms.DataGridViewTextBoxColumn sedMinimoFleteInternacionalLCL;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcaMinimoFleteInternacionalLCL;
        private System.Windows.Forms.DataGridViewTextBoxColumn forwardingMinimoFleteInternacionalLCL;
        private System.Windows.Forms.DataGridViewTextBoxColumn ManejosMinimoFleteInternacionalLCL;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargaPeligrosaMinimoFleteInternacionalLCL;
        private System.Windows.Forms.DataGridViewTextBoxColumn proveedorCargosEnDestinoLCL;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargosCargosEnDestinoLCL;
        private System.Windows.Forms.DataGridViewTextBoxColumn proveedorMovimientoBodegaLCL;
        private System.Windows.Forms.DataGridViewTextBoxColumn transporteBodegaMovimientoBodegaLCL;
        private System.Windows.Forms.DataGridViewTextBoxColumn proveedorOC1LCL;
        private System.Windows.Forms.DataGridViewTextBoxColumn productoOC1LCL;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoOC1LCL;
        private System.Windows.Forms.DataGridViewTextBoxColumn proveedorOC2LCL;
        private System.Windows.Forms.DataGridViewTextBoxColumn productoOC2LCL;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoOC2LCL;
        private System.Windows.Forms.DataGridViewTextBoxColumn proveedorOC3LCL;
        private System.Windows.Forms.DataGridViewTextBoxColumn productoOC3LCL;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoOC3LCL;
        private System.Windows.Forms.DataGridViewTextBoxColumn proveedorCargoDestino1LCL;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoCargoDestino1LCL;
        private System.Windows.Forms.DataGridViewTextBoxColumn proveedorCargoDestino2LCL;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoCargoDestino2LCL;
        private System.Windows.Forms.DataGridViewTextBoxColumn proveedorCargoDestino23LCL;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoCargoDestino3LCL;
        private System.Windows.Forms.DataGridViewTextBoxColumn modalidadLCL;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipoLCL;
        private System.Windows.Forms.DataGridViewTextBoxColumn desdeLCL;
        private System.Windows.Forms.DataGridViewTextBoxColumn hastaLCL;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalFleteCbmLCL;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalFleteMinimoLCL;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalOtrosCostosCbmLCL;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalOtrosCostosMinimosLCL;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalOtrosCostosFlatCL;
    }
}

