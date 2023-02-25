namespace ClaudiaGarcia
{
    partial class F3
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
            this.btncalcular = new System.Windows.Forms.Button();
            this.lstListaNum = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btncalcular
            // 
            this.btncalcular.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btncalcular.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalcular.Location = new System.Drawing.Point(94, 72);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(186, 65);
            this.btncalcular.TabIndex = 0;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = false;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // lstListaNum
            // 
            this.lstListaNum.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lstListaNum.FormattingEnabled = true;
            this.lstListaNum.ItemHeight = 20;
            this.lstListaNum.Location = new System.Drawing.Point(332, 75);
            this.lstListaNum.Name = "lstListaNum";
            this.lstListaNum.Size = new System.Drawing.Size(170, 224);
            this.lstListaNum.TabIndex = 1;
            // 
            // F3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstListaNum);
            this.Controls.Add(this.btncalcular);
            this.Name = "F3";
            this.Text = "TercerFormulario";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.ListBox lstListaNum;
    }
}