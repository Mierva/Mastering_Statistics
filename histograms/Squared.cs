using System;
using System.Collections.Generic;

namespace histograms
{
    class Squared
    {
        int N;
        double avg;
        List<double> data;        
        public Squared(int N, List<double> data,double avg)
        {
            this.N = N;
            this.data = data;
            this.avg = avg;
        }
        public double GetMean(double sigma)
        {
            return sigma / Math.Sqrt(N);
        }
        public double GetSigma(double sigma)
        {
            return sigma / Math.Sqrt(2 * N);
        }
        public double GetAssymetry()
        {
            double b4, b3, b2, b1;
            b4 = GetBeta(4);
            b3 = GetBeta(3);
            b2 = GetBeta(2);
            b1 = GetBeta(1);

            return Math.Sqrt((1 / (4 * N)) * (4 * b4 - 12 * b3 - 24 * b2 + 9 * b2 * b1 + 35 * b1 - 36));        
        }
        public double GetExcess()
        {
            double b6,b4, b3, b2, b1;
            b6 = GetBeta(6);
            b4 = GetBeta(4);
            b3 = GetBeta(3);
            b2 = GetBeta(2);
            b1 = GetBeta(1);

            return Math.Sqrt((1/N)*(b6-4*b4*b2-8*b3+4*Math.Pow(b2,3)-Math.Pow(b2,2)+16*b2*b1+16*b1));
        }
        public double GetCounterExcess(double excess)
        {
            return Math.Sqrt((Math.Abs(excess) / 29 * N) * Math.Pow(Math.Pow(Math.Abs(Math.Pow(excess, 2) - 1), 3), 1 / 4));
        }
        public double GetPirson(double pirson)
        {
            return pirson * Math.Sqrt((1 + 2 * Math.Round(pirson, 2)) / (2 * N));
        }

        private double GetBeta(int k)
        {
            k /= 2;
            double beta = 0;

            if (k % 2 == 0)
            {
                beta = SummarizeMean(k) / Math.Pow(SummarizeMean(2), k + 1);
            }
            else
            {
                beta = (SummarizeMean(3) * SummarizeMean(k)) / Math.Pow(SummarizeMean(k), k + 3);
            }

            return beta;
        }
        private double SummarizeMean(int k)
        {
            double mean = 0;

            for (int i = 0; i < data.Count; i++)
                mean += Math.Pow(data[i] - avg, k) / N; 
            
            return mean;
        }
    }
}
