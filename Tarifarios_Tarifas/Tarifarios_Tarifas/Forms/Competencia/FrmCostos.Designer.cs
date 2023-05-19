namespace Tarifarios_Tarifas.Forms.Competencia
{
    partial class FrmCostos
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
            this.btnCrear = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIva = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOtrosCostos = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCargosDestino = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFlete = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCrear
            // 
            this.btnCrear.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrear.Location = new System.Drawing.Point(853, 618);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(279, 129);
            this.btnCrear.TabIndex = 36;
            this.btnCrear.Text = "CREAR";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(269, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 45);
            this.label3.TabIndex = 35;
            this.label3.Text = "IVA";
            // 
            // txtIva
            // 
            this.txtIva.Location = new System.Drawing.Point(277, 328);
            this.txtIva.Name = "txtIva";
            this.txtIva.Size = new System.Drawing.Size(428, 31);
            this.txtIva.TabIndex = 34;
            this.txtIva.Text = "0";
            this.txtIva.TextChanged += new System.EventHandler(this.txtIva_TextChanged);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(474, 618);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(279, 129);
            this.btnGuardar.TabIndex = 33;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(878, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 45);
            this.label1.TabIndex = 38;
            this.label1.Text = "Total Tarifario";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(886, 328);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(508, 31);
            this.txtTotal.TabIndex = 37;
            this.txtTotal.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1116, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 45);
            this.label2.TabIndex = 40;
            this.label2.Text = "Otros Costos";
            // 
            // txtOtrosCostos
            // 
            this.txtOtrosCostos.Location = new System.Drawing.Point(1124, 140);
            this.txtOtrosCostos.Name = "txtOtrosCostos";
            this.txtOtrosCostos.Size = new System.Drawing.Size(388, 31);
            this.txtOtrosCostos.TabIndex = 39;
            this.txtOtrosCostos.Text = "0";
            this.txtOtrosCostos.TextChanged += new System.EventHandler(this.txtOtrosCostos_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(603, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(237, 45);
            this.label4.TabIndex = 42;
            this.label4.Text = "Cargos Destino";
            // 
            // txtCargosDestino
            // 
            this.txtCargosDestino.Location = new System.Drawing.Point(611, 140);
            this.txtCargosDestino.Name = "txtCargosDestino";
            this.txtCargosDestino.Size = new System.Drawing.Size(388, 31);
            this.txtCargosDestino.TabIndex = 41;
            this.txtCargosDestino.Text = "0";
            this.txtCargosDestino.TextChanged += new System.EventHandler(this.txtCargosDestino_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(46, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 45);
            this.label5.TabIndex = 44;
            this.label5.Text = "Flete";
            // 
            // txtFlete
            // 
            this.txtFlete.Location = new System.Drawing.Point(54, 140);
            this.txtFlete.Name = "txtFlete";
            this.txtFlete.Size = new System.Drawing.Size(388, 31);
            this.txtFlete.TabIndex = 43;
            this.txtFlete.Text = "0";
            this.txtFlete.TextChanged += new System.EventHandler(this.txtFlete_TextChanged);
            // 
            // FrmCostos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1644, 1019);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtFlete);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCargosDestino);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOtrosCostos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIva);
            this.Controls.Add(this.btnGuardar);
            this.Name = "FrmCostos";
            this.Text = "FrmCostos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIva;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOtrosCostos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCargosDestino;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFlete;
    }
}