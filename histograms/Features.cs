using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace histograms
{
    /// <summary>
    /// Підрахунок статистик.
    /// </summary>
    public partial class Features : Form1
    {       
        /// <returns>Список з коефіцієнтом асиметрії, ексцес, контрексцес.</returns>
        public static List<double> GetEx_Asym_CEx(List<double> sample, variation[] variants, double sigma, double selective_avg)
        {
            List<double> values = new List<double>();
            double asymmetry = 0;
            double m3_asym = 0;
            double moment = 0;
            List<double> cental_moments = new List<double>();
            List<double> m3_moms = new List<double>();
            for (int i = 0; i < variants.Length; i++)
            {
                moment = Math.Round(Math.Pow(Math.Abs(variants[i].value - selective_avg), 4) * variants[i].reps, 3);
                m3_asym = Math.Round(Math.Pow(variants[i].value - selective_avg, 3) * variants[i].reps, 3);
                cental_moments.Add(moment);
                m3_moms.Add(m3_asym);
            }
            double m3_sum = m3_moms.Sum();
            m3_sum /= sample.Count;
            asymmetry = m3_sum / Math.Pow(sigma, 3);
            double moments_sum = cental_moments.Sum();

            double M = moments_sum / sample.Count;
            double excess = (M / Math.Pow(sigma, 4)) - 3;
            double counter_excess = 1 / Math.Sqrt(Math.Abs(excess));
            values.Add(asymmetry);
            values.Add(excess);
            values.Add(counter_excess);

            return values;
        }
        public static List<List<double>> GetIntervals(double min, double max, double h)
        {
            List<double> upper_interval = new List<double>();
            List<double> lower_interval = new List<double>();
            double interval = 0.0;
            double edge = min;
            for (int i = 0; i < classes; i++)
            {
                lower_interval.Add(edge);
                interval = Math.Round(edge + h, 4);
                upper_interval.Add(interval);
                edge = interval;
            }
            List<List<double>> intervals = new List<List<double>>();
            upper_interval.Insert(upper_interval.Count - 1, max);
            lower_interval.RemoveAt(0);
            lower_interval.Insert(0, Math.Round(min, 4));
            lower_interval.Add(max);

            intervals.Add(upper_interval);
            intervals.Add(lower_interval);

            return intervals;
        }
        /*public static List<double> GetTrustedInterval(double theta, double sigma, double quantile)
        {
            List<double> trusted_intervals = new List<double>();
            double lower_interval = 0;
            double upper_interval = 0;

            double a = 0;
            double v = 0;
            for (int i = 2; i < v; i++)
            {
                lower_interval = theta - (quantile / i) * sigma;
                upper_interval = theta + (quantile / i) * sigma;
            }

            return trusted_intervals;
        }*/
        public static double GetSelectiveAvg(variation[] variants)
        {
            double selective_a = 0;
            double selective_b = 0;
            for (int i = 0; i < variants.Length; i++)
            {
                selective_a += variants[i].value * variants[i].freq;
                selective_b += variants[i].freq;
            }

            return selective_a / selective_b;
        }
        public static double GetSigma(variation[] variants, double h, List<double> sample)
        {
            double sigma = 0;
            double A = variants[0].value;
            List<double> x_moment = new List<double>();
            List<double> x_square = new List<double>();
            for (int i = 0; i < variants.Length; i++)
            {
                x_moment.Add(((variants[i].value - A) / h) * variants[i].reps);
                x_square.Add(Math.Pow((variants[i].value - A) / h, 2) * variants[i].reps);
            }
            double x_All = x_moment.Sum();
            double for_square_root = (x_All / sample.Count) * h + A;
            double square_root = x_square.Sum();

            sigma = Math.Sqrt((square_root / sample.Count) * Math.Pow(h, 2) - Math.Pow(for_square_root - A, 2));
            return sigma;
        }
        public static double GetMedian(List<double> sample)
        {
            double median = 0;
            int N = sample.Count;
            if (N % 2 == 0)
                median = (sample[N / 2] + sample[(N / 2) + 1]) / 2;
            else
                median = Convert.ToDouble(sample[N / 2]);
            return median;
        }
        public static decimal GetWalshMedian(List<double> sample, int N)
        {
            decimal walsh_median = 0.0m;
            List<double> X = new List<double>();

            for (int i = 0; i < N; i++)
                for (int j = 0; j < N; j++)
                    X.Add(sample[i] + sample[j] / 2.0);

            if (X.Count % 2 != 0)
                walsh_median = (decimal)X[X.Count / 2 + 1];
            else
                walsh_median = (decimal)(X[X.Count / 2] + X[X.Count / 2 + 1] / 2);

            return walsh_median;
        }
        /// <returns>Усічене середнє.</returns>
        public static decimal GetTruncatedMean(double koef, int N, List<double> sample)
        {
            decimal truncated_mean = 0.0m;
            int k = Convert.ToInt32(koef * N);
           
            double sum = 0;
            for (int i = k + 1; i < N - k; i++)
                sum += sample[i];

            truncated_mean = (decimal)sum / (N - 2 * k);
            return truncated_mean;
        }
    }
}
