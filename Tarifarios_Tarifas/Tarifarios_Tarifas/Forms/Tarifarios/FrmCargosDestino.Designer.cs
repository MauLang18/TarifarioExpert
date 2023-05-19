namespace Tarifarios_Tarifas.Forms.Tarifarios
{
    partial class FrmCargosDestino
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.txtTotalTarifario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.clbCargosDestino = new System.Windows.Forms.CheckedListBox();
            this.txtCargosD = new System.Windows.Forms.TextBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 45);
            this.label1.TabIndex = 15;
            this.label1.Text = "Proveedor";
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguiente.Location = new System.Drawing.Point(853, 746);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(279, 129);
            this.btnSiguiente.TabIndex = 24;
            this.btnSiguiente.Text = "GUARDAR";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // txtTotalTarifario
            // 
            this.txtTotalTarifario.Location = new System.Drawing.Point(853, 422);
            this.txtTotalTarifario.Name = "txtTotalTarifario";
            this.txtTotalTarifario.ReadOnly = true;
            this.txtTotalTarifario.Size = new System.Drawing.Size(750, 31);
            this.txtTotalTarifario.TabIndex = 25;
            this.txtTotalTarifario.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(845, 355);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 45);
            this.label2.TabIndex = 26;
            this.label2.Text = "Total Tarifario";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(99, 647);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 45);
            this.label8.TabIndex = 31;
            this.label8.Text = "Total";
            // 
            // clbCargosDestino
            // 
            this.clbCargosDestino.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clbCargosDestino.CheckOnClick = true;
            this.clbCargosDestino.ColumnWidth = 1;
            this.clbCargosDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbCargosDestino.FormattingEnabled = true;
            this.clbCargosDestino.HorizontalScrollbar = true;
            this.clbCargosDestino.Location = new System.Drawing.Point(107, 247);
            this.clbCargosDestino.Name = "clbCargosDestino";
            this.clbCargosDestino.Size = new System.Drawing.Size(419, 384);
            this.clbCargosDestino.TabIndex = 29;
            this.clbCargosDestino.SelectedIndexChanged += new System.EventHandler(this.clbCargosDestino_SelectedIndexChanged);
            // 
            // txtCargosD
            // 
            this.txtCargosD.Location = new System.Drawing.Point(107, 706);
            this.txtCargosD.Name = "txtCargosD";
            this.txtCargosD.ReadOnly = true;
            this.txtCargosD.Size = new System.Drawing.Size(290, 31);
            this.txtCargosD.TabIndex = 30;
            this.txtCargosD.Text = "0";
            this.txtCargosD.TextChanged += new System.EventHandler(this.txtCargosD_TextChanged);
            // 
            // btnCrear
            // 
            this.btnCrear.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrear.Location = new System.Drawing.Point(1232, 746);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(279, 129);
            this.btnCrear.TabIndex = 32;
            this.btnCrear.Text = "CREAR";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(853, 746);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(279, 129);
            this.button1.TabIndex = 24;
            this.button1.Text = "GUARDAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1232, 746);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(279, 129);
            this.button2.TabIndex = 32;
            this.button2.Text = "CREAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // FrmCargosDestino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1644, 1019);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.clbCargosDestino);
            this.Controls.Add(this.txtCargosD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtTotalTarifario);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.label1);
            this.Name = "FrmCargosDestino";
            this.Text = "FrmCargosDestino";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.TextBox txtTotalTarifario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckedListBox clbCargosDestino;
        private System.Windows.Forms.TextBox txtCargosD;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}