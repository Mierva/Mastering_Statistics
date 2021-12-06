using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace histograms
{
    public partial class ReverseFunc : Form
    {
        private int size;
        private double lambda;
        private double beta;

        public List<string> sample;
        public ReverseFunc(string distribution)
        {           
            InitializeComponent();

            switch (distribution)
            {
                case "exp":
                    spanel1.Visible = true;
                    slabel4.Visible = true;
                    slabel3.Visible = true;
                    slabel5.Visible = true;
                    sample_lambda.Visible = true;
                    sample_size.Visible = true;

                    break;

                case "veib":
                    spanel1.Visible = true;
                    slabel4.Visible = true;
                    slabel4.Text = "α = ";
                    slabel6.Visible = true;
                    slabel3.Visible = true;
                    slabel5.Visible = true;
                    sample_lambda.Visible = true;
                    sample_size.Visible = true;
                    sample_beta.Visible = true;
                    break;

                default:
                    //Console.WriteLine($"Measured value is {measurement}.");
                    break;
            }

        }

        private void Create_btn_Click(object sender, EventArgs e)
        {
            try
            {
                size = int.Parse(sample_size.Text);
                lambda = double.Parse(sample_lambda.Text.Replace(".", ","));
                beta = double.Parse(sample_beta.Text.Replace(".", ","));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Exponential()
        {

        }
        private void Weibull()
        {
            if (sample_size.Visible == false)
            {
                spanel1.Visible = true;
                slabel4.Visible = true;
                slabel4.Text = "α = ";
                slabel6.Visible = true;
                slabel3.Visible = true;
                slabel5.Visible = true;
                sample_lambda.Visible = true;
                sample_size.Visible = true;
                sample_beta.Visible = true;

                return;
            }


            int N = Convert.ToInt32(sample_size.Text);
            double alpha = Convert.ToDouble(sample_lambda.Text.Replace(".", ","));
            double beta = Convert.ToDouble(sample_beta.Text.Replace(".", ","));

            Sample random_sample = new Sample(N, alpha, beta);

            List<double> Dsample = random_sample.MakeSampleWeibull();

            random_sample.SaveSample(Dsample);

            sample = ToString(Dsample);            
        }
        public List<string> ToString(List<double> cleaned)
        {
            List<string> na = new List<string>();
            foreach (var i in cleaned)
                na.Add(i.ToString());
            return na;
        }
        private void Clear_btn_Click(object sender, EventArgs e)
        {
            sample_size.Text = "";
            sample_lambda.Text = "";
            sample_beta.Text = "";
        }
    }
    public class Sample
    {
        public int N;
        public double lambda;
        public double alpha;
        public double beta;

        private double a;
        public Sample()
        {

        }
        public Sample(int N, double lambda)
        {
            this.N = N;
            this.lambda = lambda;
        }
        public Sample(int N, double alpha, double beta)
        {
            this.N = N;
            this.alpha = alpha;
            this.beta = beta;
        }

        public List<double> MakeSampleExp()
        {
            List<double> sample = new List<double>();
            Random rnd = new Random();

            double x = 0;
            for (int i = 0; i < N; i++)
            {
                a = rnd.NextDouble();

                x = (1 / lambda) * Math.Log(1 / (1 - a));
                sample.Add(x);
            }

            return sample;
        }
        public List<double> MakeSampleWeibull()
        {
            List<double> sample = new List<double>();
            Random rnd = new Random();

            double x = 0;
            for (int i = 0; i < N; i++)
            {
                a = rnd.NextDouble();

                x = Math.Pow(-(Math.Log(1-a))/alpha, 1.0 / beta);
                sample.Add(x);
            }


            return sample;
        }

        public void SaveSample(List<double> sample)
        {
            string path = @"D:\NAU\Statistics\histograms\data\generated_samples\sample.txt";

            using (StreamWriter writer = new StreamWriter(path))
            {
                foreach (var num in sample)
                    writer.WriteLine(num);
            }
            MessageBox.Show(@"Файл file.txt збережено до D:\NAU\Statistics\histograms\data\generated_samples\sample.txt", "Файл збережено успішно.");
        }
    }
}
