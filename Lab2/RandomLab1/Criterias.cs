using System;

namespace RandomLab1
{
    public static class Criterias
    {
        //Хи-квадрат Пирсон
        public static double GetPirson(int[] hst, double pt, int k, int n)
        {
            double xi = 0.0;
            for (int i = 0; i < k; i++)
            {
                xi += Math.Pow(hst[i] - n * pt, 2) / (n * pt);
            }

            return xi;
        }

        //Колмогоров
        public static double GetLambda(double[] S, int N)
        {
            double dMax = 0.0;
            for (int i = 0; i < N; i++)
            {
                double dp = Math.Abs((double)(i + 1) / N - S[i]);
                double dm = Math.Abs(S[i] - (double)i / N);
                if (dp > dMax)
                    dMax = dp;
                if (dm > dMax)
                    dMax = dm;
            }
            return (dMax * Math.Sqrt(N)) / 2;
        }
    }
}
