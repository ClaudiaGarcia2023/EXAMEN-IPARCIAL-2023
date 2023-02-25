using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClaudiaGarcia
{
    public partial class MENU : Form
    {
        public MENU()
        {
            InitializeComponent();
        }

        private void primerFormularioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form PrimerFormulario = new F1();
            PrimerFormulario.Show();
        }

        private void segundoFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form SegundoFormulario = new F2();
            SegundoFormulario.Show();
        }

        private void tercerFormularioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form TercerFormulario = new F3();
            TercerFormulario.Show();
        }
    }
}
