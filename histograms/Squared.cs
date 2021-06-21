using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace histograms
{
    class Squared
    {
        #region Values
        public static double GetMean(double sigma, int N)
        {
            return sigma/Math.Sqrt(N);
        }
        public static double GetSigma(double sigma, int N)
        {
            return sigma / Math.Sqrt(2*N);
        }
        public static double GetAssymetry(List<double> sample, variation[] variants, double sigma, double selective_avg, int N)
        {
            List<double> vars = Features.GetEx_Asym_CEx(sample, variants, sigma, selective_avg);
            double assymetry = vars[0];

            return Math.Sqrt((1/(4*N))*(4*N-12*N-24*N+9*N*N-36));
        }
        public static double GetExcess(List<double> sample, variation[] variants, double sigma, double selective_avg, int N)
        {
            List<double> vars = Features.GetEx_Asym_CEx(sample, variants, sigma, selective_avg);
            double excess = vars[1];

            return Math.Sqrt((1 / (4 * N)) * (4 * N - 12 * N - 24 * N + 9 * N * N - 36));
        }
        #endregion

        #region Routine
        
        #endregion
    }
}
