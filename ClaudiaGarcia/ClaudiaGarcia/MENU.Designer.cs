namespace ClaudiaGarcia
{
    partial class MENU
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.primerFormularioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.segundoFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tercerFormularioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.primerFormularioToolStripMenuItem,
            this.segundoFToolStripMenuItem,
            this.tercerFormularioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // primerFormularioToolStripMenuItem
            // 
            this.primerFormularioToolStripMenuItem.Name = "primerFormularioToolStripMenuItem";
            this.primerFormularioToolStripMenuItem.Size = new System.Drawing.Size(167, 29);
            this.primerFormularioToolStripMenuItem.Text = "Primer formulario";
            this.primerFormularioToolStripMenuItem.Click += new System.EventHandler(this.primerFormularioToolStripMenuItem_Click);
            // 
            // segundoFToolStripMenuItem
            // 
            this.segundoFToolStripMenuItem.Name = "segundoFToolStripMenuItem";
            this.segundoFToolStripMenuItem.Size = new System.Drawing.Size(188, 29);
            this.segundoFToolStripMenuItem.Text = "Segundo formulario";
            this.segundoFToolStripMenuItem.Click += new System.EventHandler(this.segundoFToolStripMenuItem_Click);
            // 
            // tercerFormularioToolStripMenuItem
            // 
            this.tercerFormularioToolStripMenuItem.Name = "tercerFormularioToolStripMenuItem";
            this.tercerFormularioToolStripMenuItem.Size = new System.Drawing.Size(161, 29);
            this.tercerFormularioToolStripMenuItem.Text = "Tercer formulario";
            this.tercerFormularioToolStripMenuItem.Click += new System.EventHandler(this.tercerFormularioToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // MENU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MENU";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem primerFormularioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem segundoFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tercerFormularioToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

