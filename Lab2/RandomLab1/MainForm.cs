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


            double[] YY = new double[n];
            double Praz = 0.45;//разделительный элемент
            for (int i = 0; i < n; i++)
            {
                if (x[i] <= Praz)
                    YY[i] = 0;
                else
                    YY[i] = 1;
            }

            int zeroNumber = 0; //количество нулей
            int changedToZero = 0; //количество переходов 1->0

            for(int i = 1; i < n; i++)
            {
                if(YY[i] == 0)
                {
                    zeroNumber++;
                    if (YY[i - 1] == 1)
                    {
                        changedToZero++;
                    }
                }
            }

            double p0 = (double)zeroNumber / n;

            txtBoxK0.Text = changedToZero.ToString();
            txtBoxN0.Text = zeroNumber.ToString();

            double m0 = (p0 / (1 - p0)) + 1;//мат.ожидание числа нулей в серии
            double d0 = p0 / Math.Pow((1 - p0), 2);//дисперсия числа нулей в серии
            double omz = (double)zeroNumber / (double)changedToZero;//средняя оценка числа нулей в серии

            txtBoxp0.Text = p0.ToString("0.0000");
            txtBoxm0.Text = m0.ToString("0.0000");
            txtBoxd0.Text = d0.ToString("0.0000");
            txtBoxomz.Text = omz.ToString("0.0000");

            //таблица стр 56
            double beta = 0.9;
            double alpha = 1 - 0.9;
            double tau = 1.65;
            double QQ = tau * Math.Sqrt(d0 / changedToZero);

            //неравенство на странице 58
            double mz1 = m0 - QQ;
            double mz2 = m0 + QQ;

            txtBoxmzplus.Text = mz1.ToString("0.0000");
            txtBoxmzminus.Text = mz2.ToString("0.0000");

            lblSeriasTest.Text = (m0 > mz1) && (m0 < mz2) ? "Гипотеза принимается" : "Гипотеза отвергается";

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
            double r = interval - 1;
            double pirson = Criterias.GetPirson(frequency, theoricalChance, interval, n);

            txtBoxPirson.Text = Math.Round(pirson, 4).ToString();

            double maxPirson = 17.32;

            lblPirson.Text = (pirson <= maxPirson) ? "Гипотеза принимается" : "Гипотеза отвергается";

            //Kolmogorov
            Array.Sort(x);
            double lambda = Math.Round(Criterias.GetLambda(x, n), 1);
            txtBoxKolmogorov.Text = lambda.ToString();

            lblKolmogorov.Text = (lambda <= 2) ? "Гипотеза принимается" : "Гипотеза отвергается";
        }
    }
}
