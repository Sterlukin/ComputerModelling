using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomLab1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MakeVisible()
        {
            label7.Visible = true;
            panel2.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            label11.Visible = true;
            txtBoxMx.Visible = true;
            txtBoxDx.Visible = true;
            txtBoxCm2.Visible = true;
            txtBoxCm3.Visible = true;
        }

        private void buttonCountClick(object sender, EventArgs e)
        {
            MakeVisible();

            int n = (int)numeriUDSampleSize.Value;
            int interval = (int)numericUDSectionsNumber.Value;
            int length = (int)numericUDSequencySize.Value;

            MarsagliaRandom random = new MarsagliaRandom(length);

            double[] x = new double[n];
            double sum = 0;
            double sumdx = 0;
            double sumcm3 = 0;
            int[] frequency = new int[interval];
            int[] distribution = new int[interval];
            for (int i = 0; i < n; i++)
            {
                x[i] = random.Rnd();

                for (int j = 1; j <= interval; j++)
                {
                    if (x[i] <= (double)j / interval)
                    {
                        distribution[j - 1] += 1;
                        if (x[i] > (double)(j - 1) / interval)
                        {
                            frequency[j - 1] += 1;
                        }
                    }
                }

                sum += x[i];
                sumdx += Math.Pow(x[i], 2);
                sumcm3 += Math.Pow(x[i], 3);
            }
            double mx = sum / n;
            double dx = n / (n - 1) * (sumdx / n - Math.Pow(mx, 2));
            double cm2 = sumdx / n;
            double cm3 = sumcm3 / n;
            txtBoxMx.Text = mx.ToString("0.0000");
            txtBoxDx.Text = dx.ToString("0.0000");
            txtBoxCm2.Text = cm2.ToString("0.0000");
            txtBoxCm3.Text = cm3.ToString("0.0000");

            for (int i = 0; i < interval; i++)
            {
                chart1.Series[0].Points.AddXY((double)(i + 1) / interval, (double)frequency[i] / n);
                chart2.Series[0].Points.AddXY((double)(i + 1) / interval, (double)distribution[i] / n);
            }
        }
    }
}
