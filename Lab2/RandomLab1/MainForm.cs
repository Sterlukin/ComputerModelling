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

            //Pirson
            double theoricalChance = (double)1 / interval;
            double pirson = Criterias.GetPirson(frequency, theoricalChance, interval, n);

            txtBoxPirson.Text = Math.Round(pirson, 4).ToString();

            //Kolmogorov
            Array.Sort(x);
            double kolmogorov = Criterias.GetLambda(x, n);
            txtBoxKolmogorov.Text = Math.Round(kolmogorov, 4).ToString();

            //Тест серий
            double splitter = 0.45;
            double nonSplitter = 1 - 0.45;

            int r = GetR(x, n, splitter);
            double MOR = 2 * n * splitter * nonSplitter + splitter * splitter + Math.Pow(nonSplitter, 2);
            double DR = 4 * n * splitter * nonSplitter * (1 - 3 * splitter * nonSplitter) - 2 * splitter * nonSplitter * (3 - 10 * splitter * nonSplitter);
            double sigmaR = Math.Sqrt(DR);

            double Tb = 3.5;

            double Rb = MOR + Tb * sigmaR;
            double Rh = MOR - Tb * sigmaR;

            if(r >= Rh && Rb >= r)
            {
                lblSeriesHypotize.Text = "Гипотеза принимается!";
            }
            else
            {
                lblSeriesHypotize.Text = "Гипотеза отвергается!";
            }

            txtBoxRb.Text = Math.Round(Rb, 4).ToString();
            txtBoxRh.Text = Math.Round(Rh, 4).ToString();
            txtBoxR.Text = Math.Round((double)r, 4).ToString();
        }

        private static int GetR(double[] x, int n, double p)
        {
            bool y1, y2;
            int R = 0;
            if (x[0] < p)
            {
                y1 = false;
            }
            else
            {
                y1 = true;
            }
            for (int i = 0; i < n; i++)
            {
                if (x[i] < p)
                {
                    y2 = false;
                }
                else
                {
                    y2 = true;
                }
                if (y1 != y2)
                {
                    R++;
                }
            }
            return R;
        }
    }
}
