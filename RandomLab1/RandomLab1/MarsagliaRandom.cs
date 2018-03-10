using System;

namespace RandomLab1
{
    public class MarsagliaRandom
    {
        private int length;
        private double[] z1;
        private double[] z2;

        private Random random;

        public MarsagliaRandom(int length)
        {
            this.length = length;
            z1 = new double[length];
            z2 = new double[length];

            random = new Random();
        }

        public double Rnd()
        {
            double g1 = random.NextDouble();
            double g2 = random.NextDouble();
            int m = (int)(g2 * length);
            double result = z1[m];
            z1[m] = g1;

            return result;
        }



    }
}
