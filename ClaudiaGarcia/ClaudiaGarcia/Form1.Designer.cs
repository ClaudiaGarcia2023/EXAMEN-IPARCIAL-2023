namespace ClaudiaGarcia
{
    partial class F1
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtCapital = new System.Windows.Forms.TextBox();
            this.txtTasaIntereses = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lstmes = new System.Windows.Forms.ListBox();
            this.btncacular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(92, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Capital";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(99, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mes";
            // 
            // txtCapital
            // 
            this.txtCapital.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCapital.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtCapital.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtCapital.Location = new System.Drawing.Point(297, 15);
            this.txtCapital.Name = "txtCapital";
            this.txtCapital.Size = new System.Drawing.Size(100, 26);
            this.txtCapital.TabIndex = 3;
            // 
            // txtTasaIntereses
            // 
            this.txtTasaIntereses.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTasaIntereses.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtTasaIntereses.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtTasaIntereses.Location = new System.Drawing.Point(297, 57);
            this.txtTasaIntereses.Name = "txtTasaIntereses";
            this.txtTasaIntereses.Size = new System.Drawing.Size(100, 26);
            this.txtTasaIntereses.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(92, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tasa de interes";
            // 
            // lstmes
            // 
            this.lstmes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstmes.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lstmes.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstmes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lstmes.FormattingEnabled = true;
            this.lstmes.ItemHeight = 20;
            this.lstmes.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre"});
            this.lstmes.Location = new System.Drawing.Point(297, 111);
            this.lstmes.Name = "lstmes";
            this.lstmes.Size = new System.Drawing.Size(120, 244);
            this.lstmes.TabIndex = 7;
            // 
            // btncacular
            // 
            this.btncacular.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btncacular.Location = new System.Drawing.Point(446, 342);
            this.btncacular.Name = "btncacular";
            this.btncacular.Size = new System.Drawing.Size(164, 31);
            this.btncacular.TabIndex = 9;
            this.btncacular.Text = "Calculo intereses";
            this.btncacular.UseVisualStyleBackColor = false;
            this.btncacular.Click += new System.EventHandler(this.btncacular_Click);
            // 
            // F1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(669, 455);
            this.Controls.Add(this.btncacular);
            this.Controls.Add(this.lstmes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTasaIntereses);
            this.Controls.Add(this.txtCapital);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "F1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PrimerFormulario";
            this.Load += new System.EventHandler(this.F1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCapital;
        private System.Windows.Forms.TextBox txtTasaIntereses;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstmes;
        private System.Windows.Forms.Button btncacular;
    }
}