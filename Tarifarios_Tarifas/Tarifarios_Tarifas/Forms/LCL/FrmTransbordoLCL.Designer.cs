namespace Tarifarios_Tarifas.Forms.LCL
{
    partial class FrmTransbordoLCL
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
            this.label8 = new System.Windows.Forms.Label();
            this.clbOtrasCategorias = new System.Windows.Forms.CheckedListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTotalTransbordo = new System.Windows.Forms.TextBox();
            this.txtOtrasCategorias = new System.Windows.Forms.TextBox();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMovimientoPuertoBodega = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxMovimientoPuertoBodegaProveedor = new System.Windows.Forms.ComboBox();
            this.txtGastosPortuarios = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxGastosPortuariosProveedor = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(688, 683);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(404, 45);
            this.label8.TabIndex = 43;
            this.label8.Text = "Total de Otros Costos FLAT";
            // 
            // clbOtrasCategorias
            // 
            this.clbOtrasCategorias.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clbOtrasCategorias.CheckOnClick = true;
            this.clbOtrasCategorias.ColumnWidth = 1;
            this.clbOtrasCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbOtrasCategorias.FormattingEnabled = true;
            this.clbOtrasCategorias.HorizontalScrollbar = true;
            this.clbOtrasCategorias.Location = new System.Drawing.Point(69, 459);
            this.clbOtrasCategorias.Name = "clbOtrasCategorias";
            this.clbOtrasCategorias.Size = new System.Drawing.Size(419, 384);
            this.clbOtrasCategorias.TabIndex = 29;
            this.clbOtrasCategorias.SelectedIndexChanged += new System.EventHandler(this.clbOtrasCategorias_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(688, 501);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(311, 45);
            this.label7.TabIndex = 42;
            this.label7.Text = "Total de Flete x CBM";
            // 
            // txtTotalTransbordo
            // 
            this.txtTotalTransbordo.Location = new System.Drawing.Point(696, 583);
            this.txtTotalTransbordo.Name = "txtTotalTransbordo";
            this.txtTotalTransbordo.ReadOnly = true;
            this.txtTotalTransbordo.Size = new System.Drawing.Size(290, 31);
            this.txtTotalTransbordo.TabIndex = 41;
            this.txtTotalTransbordo.Text = "0";
            // 
            // txtOtrasCategorias
            // 
            this.txtOtrasCategorias.Location = new System.Drawing.Point(696, 749);
            this.txtOtrasCategorias.Name = "txtOtrasCategorias";
            this.txtOtrasCategorias.ReadOnly = true;
            this.txtOtrasCategorias.Size = new System.Drawing.Size(290, 31);
            this.txtOtrasCategorias.TabIndex = 40;
            this.txtOtrasCategorias.Text = "0";
            this.txtOtrasCategorias.TextChanged += new System.EventHandler(this.txtOtrasCategorias_TextChanged);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguiente.Location = new System.Drawing.Point(1225, 583);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(279, 129);
            this.btnSiguiente.TabIndex = 39;
            this.btnSiguiente.Text = "GUARDAR";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(61, 398);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(256, 45);
            this.label5.TabIndex = 38;
            this.label5.Text = "Otras Categorias";
            // 
            // txtMovimientoPuertoBodega
            // 
            this.txtMovimientoPuertoBodega.Location = new System.Drawing.Point(858, 329);
            this.txtMovimientoPuertoBodega.Name = "txtMovimientoPuertoBodega";
            this.txtMovimientoPuertoBodega.ReadOnly = true;
            this.txtMovimientoPuertoBodega.Size = new System.Drawing.Size(750, 31);
            this.txtMovimientoPuertoBodega.TabIndex = 37;
            this.txtMovimientoPuertoBodega.Text = "0";
            this.txtMovimientoPuertoBodega.TextChanged += new System.EventHandler(this.txtMovimientoPuertoBodega_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(850, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(412, 45);
            this.label2.TabIndex = 36;
            this.label2.Text = "Movimiento Puerto Bodega";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 45);
            this.label3.TabIndex = 35;
            this.label3.Text = "Proveedor";
            // 
            // cbxMovimientoPuertoBodegaProveedor
            // 
            this.cbxMovimientoPuertoBodegaProveedor.FormattingEnabled = true;
            this.cbxMovimientoPuertoBodegaProveedor.Location = new System.Drawing.Point(45, 329);
            this.cbxMovimientoPuertoBodegaProveedor.Name = "cbxMovimientoPuertoBodegaProveedor";
            this.cbxMovimientoPuertoBodegaProveedor.Size = new System.Drawing.Size(750, 33);
            this.cbxMovimientoPuertoBodegaProveedor.TabIndex = 34;
            this.cbxMovimientoPuertoBodegaProveedor.SelectedIndexChanged += new System.EventHandler(this.cbxMovimientoPuertoBodegaProveedor_SelectedIndexChanged);
            // 
            // txtGastosPortuarios
            // 
            this.txtGastosPortuarios.Location = new System.Drawing.Point(858, 167);
            this.txtGastosPortuarios.Name = "txtGastosPortuarios";
            this.txtGastosPortuarios.ReadOnly = true;
            this.txtGastosPortuarios.Size = new System.Drawing.Size(750, 31);
            this.txtGastosPortuarios.TabIndex = 33;
            this.txtGastosPortuarios.Text = "0";
            this.txtGastosPortuarios.TextChanged += new System.EventHandler(this.txtGastosPortuarios_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(850, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(269, 45);
            this.label4.TabIndex = 32;
            this.label4.Text = "Gastos Portuarios";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 45);
            this.label1.TabIndex = 31;
            this.label1.Text = "Proveedor";
            // 
            // cbxGastosPortuariosProveedor
            // 
            this.cbxGastosPortuariosProveedor.FormattingEnabled = true;
            this.cbxGastosPortuariosProveedor.Location = new System.Drawing.Point(45, 167);
            this.cbxGastosPortuariosProveedor.Name = "cbxGastosPortuariosProveedor";
            this.cbxGastosPortuariosProveedor.Size = new System.Drawing.Size(750, 33);
            this.cbxGastosPortuariosProveedor.TabIndex = 30;
            this.cbxGastosPortuariosProveedor.SelectedIndexChanged += new System.EventHandler(this.cbxGastosPortuariosProveedor_SelectedIndexChanged);
            // 
            // FrmTransbordoLCL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1644, 1019);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.clbOtrasCategorias);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTotalTransbordo);
            this.Controls.Add(this.txtOtrasCategorias);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMovimientoPuertoBodega);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxMovimientoPuertoBodegaProveedor);
            this.Controls.Add(this.txtGastosPortuarios);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxGastosPortuariosProveedor);
            this.Name = "FrmTransbordoLCL";
            this.Text = "FrmTransbordoLCL";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckedListBox clbOtrasCategorias;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTotalTransbordo;
        private System.Windows.Forms.TextBox txtOtrasCategorias;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMovimientoPuertoBodega;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxMovimientoPuertoBodegaProveedor;
        private System.Windows.Forms.TextBox txtGastosPortuarios;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxGastosPortuariosProveedor;
    }
}