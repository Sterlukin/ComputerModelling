using System;
using System.Windows.Forms;

namespace RandomLab1
{
    public partial class MainForm : Form
    {
        private string format = "0.0000";
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
            ShowPracticalData(controller);
            ShowZeroCriterion(controller);
            ShowPirsonCriterion(controller);
            ShowKolmogorovCriterion(controller);
            ShowChartData(controller);
        }

        private void ShowPracticalData(Controller controller)
        {
            txtBoxMx.Text = controller.Mx.ToString(format);
            txtBoxDx.Text = controller.Dx.ToString(format);
            txtBoxCm2.Text = controller.SecondStartMoment.ToString(format);
            txtBoxCm3.Text = controller.ThirdStartMoment.ToString(format);
        }

        private void ShowZeroCriterion(Controller controller)
        {
            controller.GenerateZeroSequence();
            txtBoxK0.Text = controller.ChangedToZero.ToString();
            txtBoxN0.Text = controller.ZeroNumber.ToString();

            txtBoxp0.Text = controller.PZero.ToString(format);
            txtBoxm0.Text = controller.GenerateMZero().ToString(format);
            txtBoxd0.Text = controller.GenerateDZero().ToString(format);
            txtBoxomz.Text = controller.GenerateOmz().ToString(format);

            lblSeriasTest.Text = controller.AcceptZeroCriterion();

            txtBoxmzplus.Text = controller.MzPlus.ToString(format);
            txtBoxmzminus.Text = controller.MzMinus.ToString(format);
        }

        private void ShowPirsonCriterion(Controller controller)
        {
            lblPirson.Text = controller.AcceptPirsonCriterion();
            txtBoxPirson.Text = Math.Round(controller.PirsonValue, 4).ToString();
        }

        private void ShowKolmogorovCriterion(Controller controller)
        {
            lblKolmogorov.Text = controller.AcceptLambdaCriterion();
            txtBoxKolmogorov.Text = Math.Round(controller.LambdaValue, 4).ToString();
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
