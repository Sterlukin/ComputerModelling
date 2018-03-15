using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int n = int.Parse(numUDSample.Text);
            Random random = new Random();

            double[] x = new double[n];
            double r;

            int Interval = int.Parse(numUDInterv.Text); ;
            int[] Frequency = new int[Interval];
            int[] Distribution = new int[Interval];
            double sum = 0;
            double sumdx = 0;
            double theoricalChance = 0;
            double Pirson = 0;
            double Kolmogorov = 0;

            for (int i = 0; i < n; i++)
            {
                r = random.NextDouble();

                if(0 <= Math.Sqrt(r) && 0.25 > Math.Sqrt(r))
                {
                    x[i] = r * r;
                }
                if(0.25 <= Math.Sqrt(r) && 2.25 > Math.Sqrt(r))
                {
                    x[i] = (r - 0.4375) / 0.25;
                }
                sum += x[i];
                sumdx += Math.Pow(x[i], 2);
            }

            double mx = sum / n;
            double dx = n / (n - 1) * ((sumdx / 8) / n - Math.Pow(mx, 2));

            txtBoxMx.Text = mx.ToString("0.0000");
            txtBoxDx.Text = dx.ToString("0.0000");

            for (int i = 0; i < n; i++)
            {
                for (int j = 1; j <= Interval; j++)
                {
                    if (x[i] <= (double)j / Interval)
                    {
                        Distribution[j - 1] += 1;
                        if (x[i] > (double)(j - 1) / Interval)
                        {
                            Frequency[j - 1] += 1;
                        }
                    }
                }
            }

            for (int i = 0; i < Interval; i++)
            {
                chart1.Series[0].Points.AddXY((double)(i + 1) / Interval, (double)Frequency[i]);
                chart2.Series[0].Points.AddXY((double)(i + 1) / Interval, (double)Distribution[i] / n);
            }

            //КРИТЕРИЙ ПИРСОНА-------------------------------------------
            double[] pt = new double[20];
            for (int i = 0; i < Interval; i++)
            {
                pt[i] = (double)1 / Interval;
            }
            theoricalChance = (double)1 / Interval;
            Pirson = Xi2(Frequency, pt, Interval, n);
            txtBoxPirson.Text = Convert.ToString(Math.Round(Pirson, 4));
            //КРИТЕРИЙ КОЛМОГОРОВА---------------------------------------
            Array.Sort(x);
            Kolmogorov = Lambda(x, n);
            txtBoxKolmog.Text = Convert.ToString(Math.Round(Kolmogorov, 4));
        }

        //Пирсон
        private static double Xi2(int[] hst, double[] pt, int k, int n)
        {
            double xi = 0.0;
            for (int i = 0; i < k; i++)
            {
                xi += Math.Pow(hst[i] - n * pt[i], 2) / (n * pt[i]);
            }
            return xi;
        }
        //Колмогоров
        private static double Lambda(double[] x, int n)
        {
            double dMax = 0.0;
            for (int i = 0; i < n; i++)
            {
                double dp = Math.Abs((double)(i + 1) / n - x[i]);
                double dm = Math.Abs(x[i] - (double)i / n);
                if (dp > dMax) dMax = dp;
                if (dm > dMax) dMax = dm;
            }
            return dMax * Math.Sqrt(n);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
