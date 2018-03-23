using System;

namespace RandomLab1
{
    public class Controller
    {
#region Fields
        private int sampleSize;
        private int intervalsNumber;
        private int sequenceNumber;

        private double[] sample;

        private int[] frequency;
        private int[] distribution;

        private double sum;
        private double sumSquared;
        private double sumCubed;

        private double secondStartMoment;
        private double thirdStartMoment;

        private double mx;
        private double dx;
        #endregion Fields

#region Properties
        public int SampleSize
        {
            get { return sampleSize; }
        }

        public int IntervalsNumber
        {
            get { return intervalsNumber; }
        }

        public int[] Frequency
        {
            get { return frequency; }
        }

        public int[] Distribution
        {
            get { return distribution; }
        }

        public double Sum
        {
            get { return sum; }
        }

        public double Mx
        {
            get { return mx; }
        }

        public double Dx
        {
            get { return dx; }
        }

        public double SecondStartMoment
        {
            get { return secondStartMoment; }
        }

        public double ThirdStartMoment
        {
            get { return thirdStartMoment; }
        }
#endregion Properties

        public Controller(int sampleSize, int intervalsNumber, int sequenceNumber)
        {
            this.sampleSize = sampleSize;
            this.intervalsNumber = intervalsNumber;
            this.sequenceNumber = sequenceNumber;

            sample = new double[sampleSize];
        }

        public void Generate()
        {
            MarsagliaRandom random = new MarsagliaRandom(sequenceNumber);

            frequency = new int[intervalsNumber];
            distribution = new int[intervalsNumber];

            for (int i = 0; i < sampleSize; i++)
            {
                sample[i] = random.Rnd();
                GenerateDistributionAndFrequency(sample[i]);
                GenerateSums(sample[i]);
            }

            GenerateData();
        }

        private void GenerateDistributionAndFrequency(double sampleValue)
        {
            for (int j = 1; j <= intervalsNumber; j++)
            {
                if (sampleValue <= (double)j / intervalsNumber)
                {
                    distribution[j - 1] += 1;
                    GenerateFrequency(sampleValue, j - 1);
                }
            }
        }

        private void GenerateFrequency(double sampleValue, int position)
        {
            if (sampleValue > (double)(position) / intervalsNumber)
            {
                frequency[position] += 1;
            }
        }

        private void GenerateSums(double sampleValue)
        {
            sum += sampleValue;
            sumSquared += Math.Pow(sampleValue, 2);
            sumCubed += Math.Pow(sampleValue, 3);
        }

        private void GenerateData()
        {
            mx = sum / sampleSize;
            dx = sampleSize / (sampleSize - 1) * (sumSquared / sampleSize - Math.Pow(mx, 2));
            secondStartMoment = sumSquared / sampleSize;
            thirdStartMoment = sumCubed / sampleSize;
        }
    }
}
