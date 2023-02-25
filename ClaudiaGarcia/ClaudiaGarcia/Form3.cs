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
    public partial class F3 : Form
    {
        public F3()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            int contador = 1;
            int Mul3 = 1;
            int Mul5= 1;

            while (contador <=100)
            {
                Mul3 = contador % 3;
                Mul5= contador % 5;

                if (Mul3 == 0 && Mul5 != 0)
                {
                    this.lstListaNum.Items.Add("Claudia");

                }

                else if
                    (Mul5 == 0 && Mul3 != 0)
                {
                    this.lstListaNum.Items.Add("Garcia");
                }

                else if
                 (Mul3 == 0 && Mul5 == 0)
                {
                    this.lstListaNum.Items.Add("Claudia Garcia");
                }

                else 
                {
                    this.lstListaNum.Items.Add(Convert.ToString(contador));

                }


                contador =contador+1;
            }
        }
    }
}
