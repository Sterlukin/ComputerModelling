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

        private int zeroNumber;
        private int changedToZero;

        private double pZero;
        private double mZero;
        private double dZero;
        private double omz;

        private double mzMinus;
        private double mzPlus;

        private double pirsonValue;
        private double lambdaValue;
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

        public int ZeroNumber
        {
            get { return zeroNumber; }
        }

        public int ChangedToZero
        {
            get { return changedToZero; }
        }

        public double PZero
        {
            get { return pZero; }
        }

        public double MzMinus
        {
            get { return mzMinus; }
        }

        public double MzPlus
        {
            get { return mzPlus; }
        }

        public double PirsonValue
        {
            get { return pirsonValue; }
        }

        public double LambdaValue
        {
            get { return lambdaValue; }
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

        public void GenerateZeroSequence()
        {
            double[] updatedValues = new double[sampleSize];
            double element = 0.45;
            for (int i = 0; i < sampleSize; i++)
            {
                if (sample[i] <= element)
                    updatedValues[i] = 0;
                else
                    updatedValues[i] = 1;
            }

            for (int i = 1; i < sampleSize; i++)
            {
                if (updatedValues[i] == 0)
                {
                    zeroNumber++;
                    if (updatedValues[i - 1] == 1)
                    {
                        changedToZero++;
                    }
                }
            }

            pZero = (double)zeroNumber / sampleSize;
        }

        public double GenerateMZero()
        {
            return (pZero / (1 - pZero)) + 1;
        }

        public double GenerateDZero()
        {
            return pZero / Math.Pow((1 - pZero), 2);
        }

        public double GenerateOmz()
        {
            return (double)zeroNumber / (double)changedToZero;
        }

        public string AcceptZeroCriterion()
        {
            mZero = GenerateMZero();
            dZero = GenerateDZero();
            double tau = 1.65;
            double QQ = tau * Math.Sqrt(dZero / changedToZero);

            mzMinus = mZero - QQ;
            mzPlus = mZero + QQ;

            return (mZero > mzMinus) && (mZero < mzPlus) ? "Гипотеза принимается" : "Гипотеза отвергается";
        }

        public string AcceptPirsonCriterion()
        {
            double theoricalChance = (double)1 / intervalsNumber;
            double r = intervalsNumber - 1;
            pirsonValue = Criterias.GetPirson(frequency, theoricalChance, intervalsNumber, sampleSize);

            double maxPirson = 17.32;

            return (pirsonValue <= maxPirson) ? "Гипотеза принимается" : "Гипотеза отвергается";
        }

        public string AcceptLambdaCriterion()
        {
            Array.Sort(sample);
            lambdaValue = Math.Round(Criterias.GetLambda(sample), 1);

            double maxLambda = 2;

            return (lambdaValue <= maxLambda) ? "Гипотеза принимается" : "Гипотеза отвергается";
        }
    }
}
