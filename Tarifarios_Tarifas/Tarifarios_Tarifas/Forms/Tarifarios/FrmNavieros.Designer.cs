﻿namespace Tarifarios_Tarifas.Forms.Tarifarios
{
    partial class FrmNavieros
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
            this.cbxNaviero = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFlete = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMerchant = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtImpdo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCanalFee = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPortFacility = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtImpresionBL = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtVAC = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSecurity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDocFee = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTHC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTotalCostos = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTotalFlete = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxNaviero
            // 
            this.cbxNaviero.FormattingEnabled = true;
            this.cbxNaviero.Location = new System.Drawing.Point(62, 169);
            this.cbxNaviero.Name = "cbxNaviero";
            this.cbxNaviero.Size = new System.Drawing.Size(750, 33);
            this.cbxNaviero.TabIndex = 2;
            this.cbxNaviero.SelectedIndexChanged += new System.EventHandler(this.cbxNaviero_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 45);
            this.label1.TabIndex = 3;
            this.label1.Text = "Proveedor";
            // 
            // txtFlete
            // 
            this.txtFlete.Location = new System.Drawing.Point(62, 303);
            this.txtFlete.Name = "txtFlete";
            this.txtFlete.Size = new System.Drawing.Size(750, 31);
            this.txtFlete.TabIndex = 9;
            this.txtFlete.Text = "0";
            this.txtFlete.TextChanged += new System.EventHandler(this.txtFlete_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(54, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(282, 45);
            this.label4.TabIndex = 8;
            this.label4.Text = "Flete Internacional";
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguiente.Location = new System.Drawing.Point(1154, 149);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(279, 129);
            this.btnSiguiente.TabIndex = 10;
            this.btnSiguiente.Text = "GUARDAR";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMerchant);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtImpdo);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtCanalFee);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtPortFacility);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtImpresionBL);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtVAC);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtSecurity);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtDocFee);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTHC);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(232, 373);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1201, 492);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "COSTOS";
            // 
            // txtMerchant
            // 
            this.txtMerchant.Location = new System.Drawing.Point(813, 400);
            this.txtMerchant.Name = "txtMerchant";
            this.txtMerchant.ReadOnly = true;
            this.txtMerchant.Size = new System.Drawing.Size(363, 54);
            this.txtMerchant.TabIndex = 21;
            this.txtMerchant.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(805, 329);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(189, 45);
            this.label11.TabIndex = 20;
            this.label11.Text = "MERCHANT";
            // 
            // txtImpdo
            // 
            this.txtImpdo.Location = new System.Drawing.Point(411, 400);
            this.txtImpdo.Name = "txtImpdo";
            this.txtImpdo.ReadOnly = true;
            this.txtImpdo.Size = new System.Drawing.Size(363, 54);
            this.txtImpdo.TabIndex = 19;
            this.txtImpdo.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(403, 329);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 45);
            this.label7.TabIndex = 18;
            this.label7.Text = "IMPDO";
            // 
            // txtCanalFee
            // 
            this.txtCanalFee.Location = new System.Drawing.Point(813, 257);
            this.txtCanalFee.Name = "txtCanalFee";
            this.txtCanalFee.ReadOnly = true;
            this.txtCanalFee.Size = new System.Drawing.Size(363, 54);
            this.txtCanalFee.TabIndex = 17;
            this.txtCanalFee.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(805, 186);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(178, 45);
            this.label8.TabIndex = 16;
            this.label8.Text = "CANAL FEE";
            // 
            // txtPortFacility
            // 
            this.txtPortFacility.Location = new System.Drawing.Point(411, 257);
            this.txtPortFacility.Name = "txtPortFacility";
            this.txtPortFacility.ReadOnly = true;
            this.txtPortFacility.Size = new System.Drawing.Size(363, 54);
            this.txtPortFacility.TabIndex = 15;
            this.txtPortFacility.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(403, 186);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(229, 45);
            this.label9.TabIndex = 14;
            this.label9.Text = "PORT FACILITY";
            // 
            // txtImpresionBL
            // 
            this.txtImpresionBL.Location = new System.Drawing.Point(14, 257);
            this.txtImpresionBL.Name = "txtImpresionBL";
            this.txtImpresionBL.ReadOnly = true;
            this.txtImpresionBL.Size = new System.Drawing.Size(363, 54);
            this.txtImpresionBL.TabIndex = 13;
            this.txtImpresionBL.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 186);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(227, 45);
            this.label10.TabIndex = 12;
            this.label10.Text = "IMPRESION BL";
            // 
            // txtVAC
            // 
            this.txtVAC.Location = new System.Drawing.Point(14, 400);
            this.txtVAC.Name = "txtVAC";
            this.txtVAC.ReadOnly = true;
            this.txtVAC.Size = new System.Drawing.Size(363, 54);
            this.txtVAC.TabIndex = 11;
            this.txtVAC.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 329);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 45);
            this.label6.TabIndex = 10;
            this.label6.Text = "VAC";
            // 
            // txtSecurity
            // 
            this.txtSecurity.Location = new System.Drawing.Point(813, 121);
            this.txtSecurity.Name = "txtSecurity";
            this.txtSecurity.ReadOnly = true;
            this.txtSecurity.Size = new System.Drawing.Size(363, 54);
            this.txtSecurity.TabIndex = 9;
            this.txtSecurity.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(805, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 45);
            this.label5.TabIndex = 8;
            this.label5.Text = "SECURITY";
            // 
            // txtDocFee
            // 
            this.txtDocFee.Location = new System.Drawing.Point(411, 121);
            this.txtDocFee.Name = "txtDocFee";
            this.txtDocFee.ReadOnly = true;
            this.txtDocFee.Size = new System.Drawing.Size(363, 54);
            this.txtDocFee.TabIndex = 7;
            this.txtDocFee.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(403, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 45);
            this.label3.TabIndex = 6;
            this.label3.Text = "DOC FEE";
            // 
            // txtTHC
            // 
            this.txtTHC.Location = new System.Drawing.Point(14, 121);
            this.txtTHC.Name = "txtTHC";
            this.txtTHC.ReadOnly = true;
            this.txtTHC.Size = new System.Drawing.Size(363, 54);
            this.txtTHC.TabIndex = 5;
            this.txtTHC.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 45);
            this.label2.TabIndex = 3;
            this.label2.Text = "THC";
            // 
            // txtTotalCostos
            // 
            this.txtTotalCostos.Location = new System.Drawing.Point(232, 953);
            this.txtTotalCostos.Name = "txtTotalCostos";
            this.txtTotalCostos.ReadOnly = true;
            this.txtTotalCostos.Size = new System.Drawing.Size(363, 31);
            this.txtTotalCostos.TabIndex = 23;
            this.txtTotalCostos.Text = "0";
            this.txtTotalCostos.TextChanged += new System.EventHandler(this.txtTotalCostos_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(224, 882);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(194, 45);
            this.label12.TabIndex = 22;
            this.label12.Text = "Total Costos";
            // 
            // txtTotalFlete
            // 
            this.txtTotalFlete.Location = new System.Drawing.Point(1070, 953);
            this.txtTotalFlete.Name = "txtTotalFlete";
            this.txtTotalFlete.ReadOnly = true;
            this.txtTotalFlete.Size = new System.Drawing.Size(363, 31);
            this.txtTotalFlete.TabIndex = 25;
            this.txtTotalFlete.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(1267, 882);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(166, 45);
            this.label13.TabIndex = 24;
            this.label13.Text = "Total Flete";
            // 
            // FrmNavieros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1644, 1019);
            this.Controls.Add(this.txtTotalFlete);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtTotalCostos);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.txtFlete);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxNaviero);
            this.Name = "FrmNavieros";
            this.Text = "FrmNavieros";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxNaviero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFlete;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMerchant;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtImpdo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCanalFee;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPortFacility;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtImpresionBL;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtVAC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSecurity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDocFee;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTHC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTotalCostos;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtTotalFlete;
        private System.Windows.Forms.Label label13;
    }
}