using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace histograms
{
    class Distributions
    {
        static void Normal(List<double> sample, double avg)
        {

        }
        static void Exponential(List<double> sample, double avg)
        {
            List<double> chart_points = new List<double>();

            double lambda = 1 / avg;
            double step = (sample.Max() + sample.Min()) / 100;

            double f = 0;
            for (double x = sample.Min(); x < sample.Max(); x += step)
            {
                f = 1 - Math.Exp(-lambda * x);
                chart_points.Add(f);
            }
        }
        static void Weibull(List<double> sample)
        {

        }
        static void Flat(List<double> sample, double avg)
        {

        }
        static void Arcsin(List<double> sample)
        {

        }
    }
}
