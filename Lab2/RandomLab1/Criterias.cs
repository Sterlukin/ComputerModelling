using System;

namespace RandomLab1
{
    public static class Criterias
    {
        public static double GetPirson(int[] hst, double pt, int k, int n)
        {
            double xi = 0.0;
            for (int i = 0; i < k; i++)
            {
                xi += Math.Pow(hst[i] - n * pt, 2) / (n * pt);
            }

            return xi;
        }

        public static double GetLambda(double[] values)
        {
            double dMax = 0.0;
            for (int i = 0; i < values.Length; i++)
            {
                double dp = Math.Abs((double)(i + 1) / values.Length - values[i]);
                double dm = Math.Abs(values[i] - (double)i / values.Length);
                if (dp > dMax)
                    dMax = dp;
                if (dm > dMax)
                    dMax = dm;
            }
            return (dMax * Math.Sqrt(values.Length)) / 2;
        }
    }
}
