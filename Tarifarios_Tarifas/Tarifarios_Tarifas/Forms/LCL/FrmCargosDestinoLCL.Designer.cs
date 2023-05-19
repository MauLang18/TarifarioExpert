namespace Tarifarios_Tarifas.Forms.LCL
{
    partial class FrmCargosDestinoLCL
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
            this.clbCargosDestino = new System.Windows.Forms.CheckedListBox();
            this.txtCargosD = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // clbCargosDestino
            // 
            this.clbCargosDestino.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clbCargosDestino.CheckOnClick = true;
            this.clbCargosDestino.ColumnWidth = 1;
            this.clbCargosDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbCargosDestino.FormattingEnabled = true;
            this.clbCargosDestino.HorizontalScrollbar = true;
            this.clbCargosDestino.Location = new System.Drawing.Point(78, 235);
            this.clbCargosDestino.Name = "clbCargosDestino";
            this.clbCargosDestino.Size = new System.Drawing.Size(419, 384);
            this.clbCargosDestino.TabIndex = 37;
            this.clbCargosDestino.SelectedIndexChanged += new System.EventHandler(this.clbCargosDestino_SelectedIndexChanged);
            // 
            // txtCargosD
            // 
            this.txtCargosD.Location = new System.Drawing.Point(824, 425);
            this.txtCargosD.Name = "txtCargosD";
            this.txtCargosD.ReadOnly = true;
            this.txtCargosD.Size = new System.Drawing.Size(417, 31);
            this.txtCargosD.TabIndex = 38;
            this.txtCargosD.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(816, 343);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(311, 45);
            this.label2.TabIndex = 36;
            this.label2.Text = "Total de Flete x CBM";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(895, 527);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(279, 129);
            this.button1.TabIndex = 34;
            this.button1.Text = "GUARDAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 45);
            this.label1.TabIndex = 33;
            this.label1.Text = "Proveedor";
            // 
            // FrmCargosDestinoLCL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1644, 1019);
            this.Controls.Add(this.clbCargosDestino);
            this.Controls.Add(this.txtCargosD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "FrmCargosDestinoLCL";
            this.Text = "FrmCargosDestinoLCL";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckedListBox clbCargosDestino;
        private System.Windows.Forms.TextBox txtCargosD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}