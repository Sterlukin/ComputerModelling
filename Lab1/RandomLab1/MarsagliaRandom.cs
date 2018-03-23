using System;

namespace RandomLab1
{
    public class MarsagliaRandom
    {
        private int length;
        private double[] firstSequence;
        private double[] secondSequence;

        private Random random;

        public MarsagliaRandom(int length)
        {
            this.length = length;
            firstSequence = new double[length];
            secondSequence = new double[length];

            random = new Random();
        }

        public double Rnd()
        {
            double firstValue = random.NextDouble();
            double secondValue = random.NextDouble();
            int index = (int)(secondValue * length);
            double result = firstSequence[index];
            firstSequence[index] = firstValue;

            return result;
        }



    }
}
