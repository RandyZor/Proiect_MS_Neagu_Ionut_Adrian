using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_MS_Neagu_Ionut_Adrian
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        double f(double x)
        {
            return 1 / x;
        }

        double Iexact(double a, double b)
        {
            return Math.Log(b) - Math.Log(a);
        }

            private void button1_Click(object sender, EventArgs e)
        {

                double a, b, U, I, S;
                int n, i;
                Random r = new Random();
                a = Convert.ToDouble(textBox1.Text);
                b = Convert.ToDouble(textBox2.Text);
                n = Convert.ToInt16(textBox3.Text);
                S = 0;
                for (i = 1; i <= n; i++)
                {
                    U = r.NextDouble();
                    S += f(a + (b - a) * U);
                }
                I = (b - a) * S / n;
                textBox4.AppendText("\r\n I exact = " + Iexact(a,b).ToString("0.000000"));
                textBox4.AppendText("\r\n I aprox = " + I.ToString("0.000000"));

        }
    }
}
