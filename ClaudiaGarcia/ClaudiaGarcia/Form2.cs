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
    public partial class F2 : Form
    {
        public F2()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txttotalapagar_TextChanged(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            double precio1 = Convert.ToDouble(txtpreciop1.Text);
            double cantidad1 = Convert.ToDouble(txtcantidadp1.Text);
            double precio2 = Convert.ToDouble(txtpreciop2.Text);
            double cantidad2 = Convert.ToDouble(txtcantidadp2.Text);

           
            double calculost = await calcularfacturaAsync(precio1, precio2, cantidad1, cantidad2);
            txtsubtotal.Text = calculost.ToString();

            double desct;
            double totalfact;

            desct = calculost * 0.15;
            txtdescuento.Text = desct.ToString();


            totalfact = calculost - desct;
            txttotalapagar.Text = totalfact.ToString();

        }

        private async Task<double> calcularfacturaAsync(double preciop1, double preciop2, double cantidadp1, double cantidadp2)
        {

            double Subt = await Task.Run(() =>
            {
               /// double desct;
                ///double totalfact;

                return ((preciop1 * cantidadp1) + (preciop2 * cantidadp2));

                ///desct = Subt * 0.15;
                ///totalfact = Subt - desct;
                 

            });

            return Subt;
        }

        private void F2_Load(object sender, EventArgs e)
        {

        }
    }
}
