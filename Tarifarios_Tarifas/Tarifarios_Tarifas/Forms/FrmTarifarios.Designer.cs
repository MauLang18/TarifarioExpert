namespace Tarifarios_Tarifas.Forms
{
    partial class FrmTarifarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnCargosDestino = new System.Windows.Forms.Button();
            this.btnTransbordo = new System.Windows.Forms.Button();
            this.btnNaviero = new System.Windows.Forms.Button();
            this.btnAgenteOrigen = new System.Windows.Forms.Button();
            this.pnlDesktop = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.cbxORIGEN = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbxPAIS = new System.Windows.Forms.ComboBox();
            this.cbxVIA = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxPOE = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxModalidad = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxEquipo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.cbxPOL = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.pnlDesktop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.White;
            this.panelMenu.Controls.Add(this.btnCargosDestino);
            this.panelMenu.Controls.Add(this.btnTransbordo);
            this.panelMenu.Controls.Add(this.btnNaviero);
            this.panelMenu.Controls.Add(this.btnAgenteOrigen);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(1670, 140);
            this.panelMenu.TabIndex = 3;
            // 
            // btnCargosDestino
            // 
            this.btnCargosDestino.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargosDestino.Location = new System.Drawing.Point(1250, 57);
            this.btnCargosDestino.Name = "btnCargosDestino";
            this.btnCargosDestino.Size = new System.Drawing.Size(417, 41);
            this.btnCargosDestino.TabIndex = 3;
            this.btnCargosDestino.Text = "CARGOS DESTINO";
            this.btnCargosDestino.UseVisualStyleBackColor = true;
            this.btnCargosDestino.Click += new System.EventHandler(this.btnCargosDestino_Click);
            this.btnCargosDestino.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnCargosDestino_MouseClick);
            // 
            // btnTransbordo
            // 
            this.btnTransbordo.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransbordo.Location = new System.Drawing.Point(837, 57);
            this.btnTransbordo.Name = "btnTransbordo";
            this.btnTransbordo.Size = new System.Drawing.Size(417, 41);
            this.btnTransbordo.TabIndex = 2;
            this.btnTransbordo.Text = "TRANSBORDO";
            this.btnTransbordo.UseVisualStyleBackColor = true;
            this.btnTransbordo.Click += new System.EventHandler(this.btnTransbordo_Click);
            // 
            // btnNaviero
            // 
            this.btnNaviero.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNaviero.Location = new System.Drawing.Point(414, 57);
            this.btnNaviero.Name = "btnNaviero";
            this.btnNaviero.Size = new System.Drawing.Size(417, 41);
            this.btnNaviero.TabIndex = 1;
            this.btnNaviero.Text = "FLETE INTERNACIONAL";
            this.btnNaviero.UseVisualStyleBackColor = true;
            this.btnNaviero.Click += new System.EventHandler(this.btnNaviero_Click);
            // 
            // btnAgenteOrigen
            // 
            this.btnAgenteOrigen.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgenteOrigen.ForeColor = System.Drawing.Color.Black;
            this.btnAgenteOrigen.Location = new System.Drawing.Point(3, 57);
            this.btnAgenteOrigen.Name = "btnAgenteOrigen";
            this.btnAgenteOrigen.Size = new System.Drawing.Size(417, 41);
            this.btnAgenteOrigen.TabIndex = 0;
            this.btnAgenteOrigen.Text = "AGENTE ORIGEN";
            this.btnAgenteOrigen.UseVisualStyleBackColor = true;
            this.btnAgenteOrigen.Click += new System.EventHandler(this.btnAgenteOrigen_Click);
            // 
            // pnlDesktop
            // 
            this.pnlDesktop.Controls.Add(this.label10);
            this.pnlDesktop.Controls.Add(this.cbxORIGEN);
            this.pnlDesktop.Controls.Add(this.label9);
            this.pnlDesktop.Controls.Add(this.label8);
            this.pnlDesktop.Controls.Add(this.cbxPAIS);
            this.pnlDesktop.Controls.Add(this.cbxVIA);
            this.pnlDesktop.Controls.Add(this.label7);
            this.pnlDesktop.Controls.Add(this.cbxPOE);
            this.pnlDesktop.Controls.Add(this.label6);
            this.pnlDesktop.Controls.Add(this.dtpHasta);
            this.pnlDesktop.Controls.Add(this.label5);
            this.pnlDesktop.Controls.Add(this.dtpDesde);
            this.pnlDesktop.Controls.Add(this.label4);
            this.pnlDesktop.Controls.Add(this.cbxModalidad);
            this.pnlDesktop.Controls.Add(this.label3);
            this.pnlDesktop.Controls.Add(this.cbxEquipo);
            this.pnlDesktop.Controls.Add(this.label2);
            this.pnlDesktop.Controls.Add(this.btnSiguiente);
            this.pnlDesktop.Controls.Add(this.cbxPOL);
            this.pnlDesktop.Controls.Add(this.label1);
            this.pnlDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDesktop.Location = new System.Drawing.Point(0, 140);
            this.pnlDesktop.Name = "pnlDesktop";
            this.pnlDesktop.Size = new System.Drawing.Size(1670, 1090);
            this.pnlDesktop.TabIndex = 4;
            this.pnlDesktop.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDesktop_Paint);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(67, 122);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(171, 37);
            this.label10.TabIndex = 21;
            this.label10.Text = "PAIS ORIGEN";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // cbxORIGEN
            // 
            this.cbxORIGEN.FormattingEnabled = true;
            this.cbxORIGEN.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbxORIGEN.Location = new System.Drawing.Point(74, 162);
            this.cbxORIGEN.Name = "cbxORIGEN";
            this.cbxORIGEN.Size = new System.Drawing.Size(262, 33);
            this.cbxORIGEN.TabIndex = 20;
            this.cbxORIGEN.SelectedIndexChanged += new System.EventHandler(this.cbxORIGEN_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1376, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(183, 37);
            this.label9.TabIndex = 19;
            this.label9.Text = "PAIS DESTINO";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1055, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 37);
            this.label8.TabIndex = 18;
            this.label8.Text = "VIA";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // cbxPAIS
            // 
            this.cbxPAIS.FormattingEnabled = true;
            this.cbxPAIS.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbxPAIS.Location = new System.Drawing.Point(1383, 162);
            this.cbxPAIS.Name = "cbxPAIS";
            this.cbxPAIS.Size = new System.Drawing.Size(262, 33);
            this.cbxPAIS.TabIndex = 17;
            this.cbxPAIS.SelectedIndexChanged += new System.EventHandler(this.cbxPAIS_SelectedIndexChanged);
            // 
            // cbxVIA
            // 
            this.cbxVIA.FormattingEnabled = true;
            this.cbxVIA.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbxVIA.Location = new System.Drawing.Point(1062, 162);
            this.cbxVIA.Name = "cbxVIA";
            this.cbxVIA.Size = new System.Drawing.Size(262, 33);
            this.cbxVIA.TabIndex = 16;
            this.cbxVIA.SelectedIndexChanged += new System.EventHandler(this.cbxVIA_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(715, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 37);
            this.label7.TabIndex = 15;
            this.label7.Text = "POD";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // cbxPOE
            // 
            this.cbxPOE.FormattingEnabled = true;
            this.cbxPOE.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbxPOE.Location = new System.Drawing.Point(722, 162);
            this.cbxPOE.Name = "cbxPOE";
            this.cbxPOE.Size = new System.Drawing.Size(262, 33);
            this.cbxPOE.TabIndex = 14;
            this.cbxPOE.SelectedIndexChanged += new System.EventHandler(this.cbxPOE_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(393, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 37);
            this.label6.TabIndex = 13;
            this.label6.Text = "POL";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // dtpHasta
            // 
            this.dtpHasta.CustomFormat = "yyyy-MM-dd";
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHasta.Location = new System.Drawing.Point(976, 515);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(535, 31);
            this.dtpHasta.TabIndex = 12;
            this.dtpHasta.ValueChanged += new System.EventHandler(this.dtpHasta_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(968, 422);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 47);
            this.label5.TabIndex = 11;
            this.label5.Text = "HASTA";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // dtpDesde
            // 
            this.dtpDesde.CustomFormat = "yyyy-MM-dd";
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDesde.Location = new System.Drawing.Point(74, 515);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(535, 31);
            this.dtpDesde.TabIndex = 10;
            this.dtpDesde.ValueChanged += new System.EventHandler(this.dtpDesde_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(66, 422);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 47);
            this.label4.TabIndex = 9;
            this.label4.Text = "DESDE";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // cbxModalidad
            // 
            this.cbxModalidad.FormattingEnabled = true;
            this.cbxModalidad.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbxModalidad.Location = new System.Drawing.Point(976, 307);
            this.cbxModalidad.Name = "cbxModalidad";
            this.cbxModalidad.Size = new System.Drawing.Size(535, 33);
            this.cbxModalidad.TabIndex = 8;
            this.cbxModalidad.SelectedIndexChanged += new System.EventHandler(this.cbxModalidad_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(968, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 47);
            this.label3.TabIndex = 7;
            this.label3.Text = "MODALIDAD";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // cbxEquipo
            // 
            this.cbxEquipo.FormattingEnabled = true;
            this.cbxEquipo.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbxEquipo.Location = new System.Drawing.Point(74, 307);
            this.cbxEquipo.Name = "cbxEquipo";
            this.cbxEquipo.Size = new System.Drawing.Size(535, 33);
            this.cbxEquipo.TabIndex = 6;
            this.cbxEquipo.SelectedIndexChanged += new System.EventHandler(this.cbxEquipo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 47);
            this.label2.TabIndex = 5;
            this.label2.Text = "EQUIPO";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguiente.Location = new System.Drawing.Point(722, 741);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(279, 129);
            this.btnSiguiente.TabIndex = 4;
            this.btnSiguiente.Text = "GUARDAR";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // cbxPOL
            // 
            this.cbxPOL.FormattingEnabled = true;
            this.cbxPOL.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbxPOL.Location = new System.Drawing.Point(400, 162);
            this.cbxPOL.Name = "cbxPOL";
            this.cbxPOL.Size = new System.Drawing.Size(262, 33);
            this.cbxPOL.TabIndex = 1;
            this.cbxPOL.SelectedIndexChanged += new System.EventHandler(this.cbxPOL_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "RUTA";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FrmTarifarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1670, 1230);
            this.Controls.Add(this.pnlDesktop);
            this.Controls.Add(this.panelMenu);
            this.Name = "FrmTarifarios";
            this.Text = "FrmTarifarios";
            this.panelMenu.ResumeLayout(false);
            this.pnlDesktop.ResumeLayout(false);
            this.pnlDesktop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnTransbordo;
        private System.Windows.Forms.Button btnNaviero;
        private System.Windows.Forms.Button btnAgenteOrigen;
        private System.Windows.Forms.Panel pnlDesktop;
        private System.Windows.Forms.ComboBox cbxPOL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.ComboBox cbxModalidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxEquipo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxPOE;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbxPAIS;
        private System.Windows.Forms.ComboBox cbxVIA;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbxORIGEN;
        public System.Windows.Forms.Button btnCargosDestino;
    }
}