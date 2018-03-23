using System;
using System.Windows.Forms;

namespace RandomLab1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonCountClick(object sender, EventArgs e)
        {
            int sampleSize = (int)numeriUDSampleSize.Value;
            int intervalsNumber = (int)numericUDSectionsNumber.Value;
            int sequenceNumber = (int)numericUDSequencySize.Value;
            
            Controller controller = new Controller(sampleSize, intervalsNumber, sequenceNumber);
            controller.Generate();
            ShowTextData(controller);
            ShowChartData(controller);
        }

        private void ShowTextData(Controller controller)
        {
            string format = "0.0000";

            txtBoxMx.Text = controller.Mx.ToString(format);
            txtBoxDx.Text = controller.Dx.ToString(format);
            txtBoxCm2.Text = controller.SecondStartMoment.ToString(format);
            txtBoxCm3.Text = controller.ThirdStartMoment.ToString(format);
        }

        private void ShowChartData(Controller controller)
        {
            for (int i = 0; i < controller.IntervalsNumber; i++)
            {
                chartFrequency.Series[0].Points.AddXY((double)(i + 1) / controller.IntervalsNumber, (double)controller.Frequency[i] / controller.SampleSize);
                chartDistribution.Series[0].Points.AddXY((double)(i + 1) / controller.IntervalsNumber, (double)controller.Distribution[i] / controller.SampleSize);
            }
        }
    }
}
