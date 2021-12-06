using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;

namespace histograms
{    
    public partial class Form1 : Form
    {      
        double probability = 0.95;
        
        double koeficcient = 0.5;
        double Probability
        {
            get
            {
                return probability;
            }
            set
            {
                if (value < 1 && value > 0)
                    probability = value;
            }
        }
        double Koeficcient
        {
            get
            {
                return koeficcient;
            }
            set
            {
                if (value <= 0.49 && value >= 0)
                    koeficcient = value;
            }
        }

        private static int mark      = 0;
        private static int classes   = 0;
        private static double sigma  = 0;
        private static double avg    = 0;
        private static double pirson = 0;

        List<string> father, son, cleaned_data;        
        List<double> temple;       

        double excess, counter_excess, selective_avg, asymmetry;

        int click_count = 0;
        public Form1()
        {
            InitializeComponent();
        }
        #region Buttons

        #region Interface
        private void create_exponential_Click(object sender, EventArgs e)
        {
            new ReverseFunc("exp").Show();
            /*
            if (sample_size.Visible == false)
            {
                spanel1.Visible = true;
                slabel4.Visible = true;
                slabel3.Visible = true;
                slabel5.Visible = true;
                sample_lambda.Visible = true;
                sample_size.Visible = true;

                return;
            }

           
            int N = Convert.ToInt32(sample_size.Text);
            double lambda = Convert.ToDouble(sample_lambda.Text.Replace(".",","));
            Sample random_sample = new Sample(N,lambda);                

            List<double> sample = random_sample.MakeSampleExp();

            random_sample.SaveSample(sample);

            List<string> str_sample = ToString(sample);
            try
            {
                if (str_sample == null)
                    throw new FileNotFoundException();
                else if (str_sample.Count == 1)
                    throw new WarningException();
                else
                {
                    AnalyzeData(str_sample);
                    father = str_sample;
                    son = str_sample;

                    if (click_count == 1)
                        click_count = 0;
                }
            }
            catch (WarningException ex)
            {
                MessageBox.Show($"Замала кількість даних.", "Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Виникла непедбачувана ситуація:\n{ex.Message}", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }
        private void create_weibull_Click(object sender, EventArgs e)
        {
            new ReverseFunc("weib").Show();

            /*
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

            Sample random_sample = new Sample(N, alpha,beta);

            List<double> sample = random_sample.MakeSampleWeibull();

            random_sample.SaveSample(sample);

            List<string> str_sample = ToString(sample);
            try
            {
                if (str_sample == null)
                    throw new FileNotFoundException();
                else if (str_sample.Count == 1)
                    throw new WarningException();
                else
                {
                    AnalyzeData(str_sample);
                    father = str_sample;
                    son = str_sample;

                    if (click_count == 1)
                        click_count = 0;
                }
            }
            catch (WarningException ex)
            {
                MessageBox.Show($"Замала кількість даних.", "Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           */
        }

        private void createFile_Click(object sender, EventArgs e)
        {
            /*try
            {
                if (son == null)
                    throw new FileNotFoundException();
                else if (son.Count == 1)
                    throw new WarningException();
                else
                {
                    AnalyzeData(son);

                    if (click_count == 1)
                        click_count = 0;
                }
            }
            catch (WarningException дex)
            {
                MessageBox.Show($"Замала кількість даних.", "Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Виникла непедбачувана ситуація:\n{ex.Message}", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
            Create(son);

            if (click_count == 1)
                click_count = 0;
        }
        private void openFile_Click(object sender, EventArgs e)
        {
            father = ReadFile();
            son = father;
        }
        private void clearFile_Click(object sender, EventArgs e)
        {
            Clear();
            father = null;
            son = null;
            cleaned_data = null;
        }
        private void toLog_Click(object sender, EventArgs e)
        {
            //TODO: fix toLog algoritm
            //changing data using log(e) doesn't work for some cases, what's the case?
            //minimum finding?
            try
            {
                if (son == null)
                    throw new FileNotFoundException();
                else if (son.Count == 1)
                    throw new WarningException();

                click_count = 0;
                List<double> sample = ListConv(son);
                List<double> brand_new = new List<double>();
                double new_x = 0;

                double min = 0;
                for (int i = 0; i < sample.Count; i++)
                {
                    if (sample[i] < 0 && min > sample[i])
                        min = sample[i];
                }

                for (int i = 0; i < sample.Count; i++)
                {
                    new_x = sample[i] + Math.Abs(min) + probability;
                    brand_new.Add(Math.Round(Math.Log10(new_x), 4));
                }

                List<string> transfer = ToString(brand_new);
                AnalyzeData(transfer);
            }
            catch (WarningException ex)
            {
                MessageBox.Show($"Замала кількість даних.", "Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Виникла непедбачувана ситуація:\n{ex.Message}", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void toNormal_Click(object sender, EventArgs e)
        {
            if (click_count != 0) return;
            else
            {
                try
                {
                    if (son == null)
                        throw new FileNotFoundException();
                    else if (son.Count == 1)
                        throw new WarningException();

                    click_count = 1;
                    List<double> sample = ListConv(son);
                    List<double> brand_new = new List<double>();

                    for (int i = 0; i < sample.Count; i++)
                        brand_new.Add((sample[i] - avg) / sigma);

                    List<string> transfer = ToString(brand_new);
                    AnalyzeData(transfer);
                }
                catch (WarningException ex)
                {
                    MessageBox.Show($"Замала кількість даних.", "Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Виникла непедбачувана ситуація:\n{ex.Message}", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void chart_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Вилучити аномальні значення?", "Аномальні значення", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                List<double> cleaned = Anomaly_review(temple, excess, selective_avg, asymmetry, sigma);
                cleaned_data = ToString(cleaned);
                son = cleaned_data;
                AnalyzeData(cleaned_data);
            }
            else if (result == DialogResult.Cancel)
            {
                son = father;
                AnalyzeData(son);
            }
        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            classes = trackBar1.Value;
            column_bar.Value = trackBar1.Value;
            try
            {
                AnalyzeData(son);
            }
            catch
            {
                MessageBox.Show("Something went wrong.", "Error!");
            }
        }
        private void column_bar_Scroll(object sender, EventArgs e)
        {
            try
            {
                classes = column_bar.Value;
                trackBar1.Value = column_bar.Value;

                if (son != null)
                {
                    List<string> list = son;
                    if (list != null)
                        AnalyzeData(list);
                    else
                        throw new Exception();
                }
            }
            catch
            {
                MessageBox.Show($"Виникла непедбачувана ситуація,\nперевірте вхідні дані.", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Distributions
        private void exp_distr_Click(object sender, EventArgs e)
        {
            Exponential(temple, avg, classes);
        }
        private void norm_distr_Click(object sender, EventArgs e)
        {
            Normal(temple, avg, classes);
        }
        private void weibull_distr_Click(object sender, EventArgs e)
        {
            Weibull(temple, avg, classes);
        }
        private void flat_distr_Click(object sender, EventArgs e)
        {
            Flat(temple, avg, classes);
        }
        private void arcsin_distr_Click(object sender, EventArgs e)
        {
            Arcsin(temple, avg, classes);
        }
        #endregion

        #endregion

        #region Operations

        #region Main

        public void AnalyzeData(List<string> local_list)
        {
            Clear();
            double temp;
            double.TryParse(probability_field.Text.Replace(".", ","), out temp);
            Probability = temp;
            double.TryParse(a_value.Text.Replace(".", ","), out temp);
            Koeficcient = temp;

            List<double> sample = ListConv(local_list);
            sample = ToSort(sample);
            int N = sample.Count;
            classes = GetClasses(sample);
            temple = sample;

            double sum = 0.0;
            foreach (var i in sample)
                sum += i;

            avg = sum / N;

            double min = sample.Min();
            double max = sample.Max();
            double h = Math.Round((max - min) / classes, 4);

<<<<<<< HEAD
            BasicStatistics features = new BasicStatistics(classes);
=======

            Features features = new Features(classes);
>>>>>>> 9db09e445d4d96d401da94363a8e690e5b39d2bf
            List<List<double>> intervals = features.GetIntervals(min, max, h);
            List<double> upper_interval = intervals[0];
            List<double> lower_interval = intervals[1];

            variation[] variants = GetVarianta(upper_interval, lower_interval, sample);
            selective_avg = features.GetSelectiveAvg(variants);
<<<<<<< HEAD
            sigma = Math.Sqrt(features.GetDispersion(variants, h, sample));
=======
            sigma = features.GetSigma(variants, h, sample);
>>>>>>> 9db09e445d4d96d401da94363a8e690e5b39d2bf

            // підрахунок цих трьох значень тісно зв'язаний,
            // тому раціональніше вивести список який містить всі значення.
            List<double> Excess_asymmetry = features.GetEx_Asym_CEx(sample, variants, sigma, selective_avg);
            asymmetry = Excess_asymmetry[0];
            excess = Excess_asymmetry[1];
            counter_excess = Excess_asymmetry[2];

<<<<<<< HEAD
            pirson = (sigma / avg) * 100;
            
            double walsh_median = features.GetWalshMedian(sample, N);
            double truncated_mean = features.GetTruncatedMean(koeficcient, N, sample);
=======
            pirson = (sigma / avg) * 100;            
            decimal walsh_median = features.GetWalshMedian(sample, N);
            decimal truncated_mean = features.GetTruncatedMean(koeficcient, N, sample);
>>>>>>> 9db09e445d4d96d401da94363a8e690e5b39d2bf

            List<double> freqs = Empiric.GetFreqs(variants);
            DrawChart(variants, lower_interval);
            DrawEmpiricFunction(variants, lower_interval, freqs);
            DrawProbabilityGrid(variants, lower_interval, freqs, sample);


            List<List<double>> confidence_intervals = AddConfidenceIntervals(N,sample);

            ShowStatistics(min, max, pirson, walsh_median, truncated_mean, confidence_intervals, sample,N);            

            for (int i = 0; i < variants.Length; i++)
                variationGrid.Rows.Add(i, variants[i].value, variants[i].reps, variants[i].freq);
        }

        private List<List<double>> AddConfidenceIntervals(int N, List<double> sample)
        {
            SquaredData data = new SquaredData(N,sample,avg);
            List<List<double>> ints = new List<List<double>>();
            ints.Add(GetConfidenceInterval(avg, data.GetMean(sigma), N, probability));
            ints.Add(GetConfidenceInterval(sigma, data.GetSigma(sigma), N, probability));            
            ints.Add(GetConfidenceInterval(asymmetry, data.GetAssymetry(), N, probability));            
            ints.Add(GetConfidenceInterval(excess, data.GetExcess(), N, probability));// 3            
            ints.Add(GetConfidenceInterval(counter_excess, data.GetCounterExcess(excess), N, probability));
            ints.Add(GetConfidenceInterval(pirson, data.GetPirson(pirson), N, probability));           
            ints.Add(GetConfidenceInterval(selective_avg, data.GetMean(selective_avg), N, probability));

            return ints;
        }
        private void ShowStatistics(double min, double max, double pirson, double walsh_median, double truncated_mean, List<List<double>> ints, List<double> sample, int N)
        {
            SquaredData data = new SquaredData(N, sample, avg);
            
            result.Rows.Add("Класи", classes);
            result.Rows.Add("Сер.ариф", 
                Math.Round(avg, 4),
                Math.Round(ints[0][0], 4) + " < " + Math.Round(ints[0][1], 4) + " < " + Math.Round(ints[0][2], 4), 
                Math.Round(data.GetMean(sigma),4));
            result.Rows.Add("Мінімальне", Math.Round(min, 4));
            result.Rows.Add("Максимальне", Math.Round(max, 4));
            result.Rows.Add("Сер.кв.відхилення", 
                Math.Round(sigma, 4),
                Math.Round(ints[1][0], 4) + " < " + Math.Round(ints[1][1], 4) + " < " + Math.Round(ints[1][2], 4), 
                Math.Round(data.GetSigma(sigma),4));
            result.Rows.Add("Коеф.асиметрії", 
                Math.Round(asymmetry, 4),
                Math.Round(ints[2][0], 4) + " < " + Math.Round(ints[2][1], 4) + " < " + Math.Round(ints[2][2], 4),
                Math.Round(data.GetAssymetry(),4));
            result.Rows.Add("Ексцес", 
                Math.Round(excess, 4),
                Math.Round(ints[3][0], 4) + " < " + Math.Round(ints[3][1], 4) + " < " + Math.Round(ints[3][2], 4), 
                Math.Round(data.GetExcess(),4));
            result.Rows.Add("Контрексцес", 
                Math.Round(counter_excess, 4),
                Math.Round(ints[4][0], 4) + " < " + Math.Round(ints[4][1], 4) + " < " + Math.Round(ints[4][2], 4),
                Math.Round(data.GetCounterExcess(excess),4));
            result.Rows.Add("Коеф.Пірсона", 
                Math.Round(pirson, 4),
                Math.Round(ints[5][0], 4) + " < " + Math.Round(ints[5][1], 4) + " < " + Math.Round(ints[5][2], 4),
                Math.Round(data.GetPirson(pirson),4));
            result.Rows.Add("Вибіркове середнє", 
                Math.Round(selective_avg, 4),
                Math.Round(ints[6][0], 4) + " < " + Math.Round(ints[6][1], 4) + " < " + Math.Round(ints[6][2], 4),
                Math.Round(data.GetMean(selective_avg),4));
            result.Rows.Add("Медіана Уолша", Math.Round(walsh_median, 4));
            result.Rows.Add("Усічене середнє", Math.Round(truncated_mean, 4));
        }
        public List<string> ReadFile()
        {
            string line = "";           
            List<string> raw_data = new List<string>();

            OpenFileDialog file_properties = new OpenFileDialog();
            file_properties.InitialDirectory = @"D:\NAU\Statistics\histograms\data";
            file_properties.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            file_properties.FilterIndex = 2;
            file_properties.RestoreDirectory = true;


            if (file_properties.ShowDialog() == DialogResult.OK)
            {
                using (var fileStream = file_properties.OpenFile())
                {
                    using (StreamReader txt = new StreamReader(fileStream))
                    {                        
                        for (int c = 0; !txt.EndOfStream; c++)
                        {
                            line = txt.ReadLine().Replace(".", ",");
                            raw_data.Add(line);
                        }
                    }
                }               
            }


            return raw_data;
        }
        private void ReadDatFile()
        {
            string line = "";
            List<string> raw_data = new List<string>();

            OpenFileDialog file_properties = new OpenFileDialog();
            file_properties.InitialDirectory = @"D:\NAU\Statistics\histograms\data";
            file_properties.FilterIndex = 2;
            file_properties.RestoreDirectory = true;

            int longest_line = 0, current_line = 0;
            
            if (file_properties.ShowDialog() == DialogResult.OK)
            {
                using (var fileStream = file_properties.OpenFile())
                {
                    using (StreamReader txt = new StreamReader(fileStream))
                    {
                        for (int c = 0; !txt.EndOfStream; c++)
                        {
                            line = txt.ReadLine().Replace(".", ",");
                            current_line = ColumnCount(line);

                            if (longest_line < current_line)
                                longest_line = current_line;

                            raw_data.Add(line);
                        }
                    } 
                }
            }

            string[] rows = new string[longest_line];
            for(int i = 0; i<rows.Length; i++)
            {
                //rows[i] = raw_data.ToArray();
            }

                
            string[] columns = new string[raw_data.Count];
        }

        private int ColumnCount(string line)
        {
            line = line.Trim();

            int count = 0;
            for (int i = 0; i < line.Length; i++)
            {
                if(line[i] == ' ')
                    count++;
            }
            
            return count;
        }

        private void DrawChart(variation[] variants, List<double> lower_interval)
        { 
            List<double> y_max = new List<double>();
            for (int i = 0; i < variants.Length; i++)
                y_max.Add(variants[i].freq);

            y_max = ToSort(y_max);
            lower_interval = ToSort(lower_interval);
            chart.ChartAreas[0].AxisY.Minimum = 0;
            chart.ChartAreas[0].AxisY.Maximum = Math.Round(y_max[y_max.Count-1], 3);
            chart.ChartAreas[0].AxisX.Maximum = Math.Round(lower_interval[lower_interval.Count - 1],3);
            chart.ChartAreas[0].AxisX.Minimum = lower_interval[0];
                
            for (int i = 0; i < variants.Length; i++)
                chart.Series[0].Points.AddXY(Math.Round(variants[i].value, 3), Math.Round(variants[i].freq, 3));            
        }
        private void DrawEmpiricFunction(variation[] variants, List<double> lower_interval, List<double> freqs)
        {
            List<double> X = Empiric.GetNotZero(variants);
            chart1.ChartAreas[0].AxisY.Maximum = 1;
            chart1.ChartAreas[0].AxisY.Minimum = 0;
            chart1.ChartAreas[0].AxisX.Maximum = Math.Round(lower_interval[lower_interval.Count - 1], 3);
            chart1.ChartAreas[0].AxisX.Minimum = lower_interval[0];

            for (int i = 0; i < X.Count; i++)
                chart1.Series[0].Points.AddXY(Math.Round(variants[i].value, 3), Math.Round(freqs[i],3));
        }
        private void DrawProbabilityGrid(variation[] variants, List<double> intervals, List<double> freqs, List<double> sample)
        {
            List<double> X = Empiric.GetFreqs(variants);
            List<double> temp = new List<double>();
            prob_grid.ChartAreas[0].AxisY.Maximum = 1;
            prob_grid.ChartAreas[0].AxisY.Minimum = 0;            
            prob_grid.ChartAreas[0].AxisX.Maximum = intervals[intervals.Count - 1];
            prob_grid.ChartAreas[0].AxisX.Minimum = intervals[0];

            
            for (int i = 0; i < sample.Count; i++)
            {
                //prob_grid.Series[1].Points.AddXY(Math.Round(sample[i], 3), GetF(GetZscore(sample, i)));
                prob_grid.Series[1].Points.AddXY(Math.Round(sample[i], 3), Math.Round(GetP(i, sample.Count),3));
                temp.Add(chart.DataManipulator.Statistics.NormalDistribution(GetP(i, sample.Count)));
                //temp.Add(chart.DataManipulator.Statistics.NormalDistribution(GetZscore(intervals, i)));
                //prob_grid.Series[1].Points.AddXY(Math.Round(Math.Log(variants[i].value), 3), Math.Round(Math.Log(-Math.Log(1-GetP(i, son.Count))), 3));
                //prob_grid.Series[0].Points.AddXY(Math.Round(sample[i], 3), Math.Round(temp[i], 3));
                //prob_grid.Series[1].Points.AddXY(Math.Round(variants[i].value, 3), Math.Round(X[i], 3));
            }
        }
        public void Clear()
        {
            chart.Series[0].Points.Clear();
            chart1.Series[0].Points.Clear();
            prob_grid.Series[0].Points.Clear();
            prob_grid.Series[1].Points.Clear();
            variationGrid.Rows.Clear();
            result.Rows.Clear();

            chart.Series[1].ClearPoints();
            chart1.Series[1].ClearPoints();
        }
        #endregion

        #region Distributions
        //TODO: complete all distributions making
        private void Normal(List<double> sample, double avg, int classes)
        {
            chart.Series[1].ClearPoints();
            chart1.Series[1].ClearPoints();
            prob_grid.Series[0].ClearPoints();
            double step = (sample.Max() - sample.Min()) / classes;

            double b1, b2, b3, b4, b5;
            b1 = 0.31938153;
            b2 = -0.356563782;
            b3 = 1.781477937;
            b4 = -1.821255978;
            b5 = 1.330274429;

            
            //double t = 1 / (1+(0.2316319*u));

            double x2 = 0;           
            foreach (int num in sample)
                x2 += Math.Pow(num, 2);
            x2 = x2/sample.Count;

            double m = avg;
            double sigma = (sample.Count / (sample.Count - 1)) * Math.Sqrt(x2 - Math.Pow(avg, 2));

            double f = 0;
            for (double x = sample.Min(); x <= sample.Max(); x += step)
            {
                chart.Series[1].Points.AddXY(x, classes * 
                    Math.Exp(Math.Pow((x - m), 2) / (-2 * Math.Pow(sigma,2))) / (sigma * Math.Sqrt(2 * Math.PI)));
                
                //f = 1.0 - Math.Exp(-0.5 * Math.Pow((x - m) / sigma, 2)) * (b1 * t + b2 * t * t + b3 * Math.Pow(t, 3) + b4 * Math.Pow(t, 4) + b5 * Math.Pow(t, 5)) / Math.Sqrt(2 * Math.PI) + 7.7e-8;
                //chart1.Series[1].Points.AddXY(x, f);
            }
        }
        private void Exponential(List<double> sample, double avg, int classes)
        {
            chart.Series[1].ClearPoints();
            chart1.Series[1].ClearPoints();

            double lambda = 1.0 / avg;
            double step = (sample.Max() - sample.Min()) / classes;

            double f = 0;
            for (double x = sample.Min(); x <= sample.Max(); x += step)
            {
                f = 1.0 - Math.Exp(-lambda * x);
                chart1.Series[1].Points.AddXY(x, f);
                chart.Series[1].Points.AddXY(x, step * lambda * Math.Exp(-lambda * x));
                prob_grid.Series[0].Points.AddXY(x, (1 - Math.Exp(-lambda * x)));            
            }

            MessageBox.Show($"lambda = {lambda}", "");
        }
        private void Weibull(List<double> sample, double avg, int classes)
        {
            sample = ToSort(sample);
            chart.Series[1].ClearPoints();
            chart1.Series[1].ClearPoints();

            double h = (sample.Max() - sample.Min()) / classes;                       
            double alpha, beta, x, probability_func;
            double A;            
            double A01 = 0;
            double A11 = 0;
            double[] b_vect = new double[2] { 0, 0 };

            int sample_size = sample.Count;
            int index = 0;


            int count = 0, j;
            for (j = 0; j < sample.Count; j++)
                if (sample[j] <= sample[index])
                    count++;
            
            for (int l = 0; l < sample_size - 1; l++)
            {
                A01 += Math.Log(sample[l]);
                A11 += Math.Pow(Math.Log(sample[l]), 2);
                b_vect[0] += Math.Log(Math.Log(1.0 / (1 - GetTheoretical(sample, l))));
                b_vect[1] += Math.Log(sample[l]) * Math.Log(Math.Log(1.0 / (1 - GetTheoretical(sample, l))));
            }

            double[,] matrix = new double[2, 2] 
            { 
                { (sample_size - 1), A01 }, 
                { A01, A11 } 
            };

            //знаходимо значення бета та альфа.
            beta = (matrix[0, 0] * b_vect[1] - matrix[1, 0] * b_vect[0]) / (matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0]);

            A = (b_vect[0] - matrix[0, 1] * beta) / matrix[0, 0];
            
            alpha = Math.Exp(-A);

            //виводимо значення для перевірки коректності змодельованої вибірки.
            MessageBox.Show($"alpha = {alpha}|{A}\nbeta = {beta}", "");

            double step = (sample.Max() - sample.Min()) / 1000.0;

            for (x = sample.Min(); x <= sample.Max(); x += step)
            {
                if (x >= 0)
                {
                    chart.Series[1].Points.AddXY(x, h * beta * Math.Pow(x, beta - 1) * Math.Exp(-Math.Pow(x, beta) / alpha) / alpha);

                    probability_func = 1.0 - Math.Exp(-Math.Pow(x, beta) / alpha);

                    chart1.Series[1].Points.AddXY(x, probability_func);;
                }
            }

        }        
        private void Flat(List<double> sample, double avg, int classes)
        {
            chart.Series[1].ClearPoints();
            chart1.Series[1].ClearPoints();
            
        }
        private void Arcsin(List<double> sample, double avg, int classes)
        {
            chart.Series[1].ClearPoints();
            chart1.Series[1].ClearPoints();
            
        }

        #region Additional
        
        private double GetTheoretical(List<double> sample, int indx)
        {
            int count = 0, j;
            for (j = 0; j < sample.Count; j++)
                if (sample[j] <= sample[indx])
                    count++;

            return (double)count / sample.Count;
        }

        #endregion
        /*private double FindQuantile(double g)
        {
            double c0 = 2.515517;
            double c1 = 0.802853;
            double c2 = 0.010328;
            double d1 = 1.432788;
            double d2 = 0.1892659;
            double d3 = 0.001308;

            double p = g / 2.0, t = Math.Sqrt(Math.Log(1 / Math.Pow(p, 2)));

            return (t - (c0 + c1 * t + c2 * t * t) / (1 + d1 * t + d2 * t * t + d3 * t * t * t) + 4e-4);
        }*/
        #endregion

        #region GetValue       
        private variation[] GetVarianta(List<double> upper_interval, List<double> lower_interval, List<double> sample)
        {
            variation[] variants = new variation[classes];

            List<double> Axis = new List<double>();
            for (int i = 0; i < classes; i++)
            {
                Axis.Add((lower_interval[i] + upper_interval[i]) / 2);
                variants[i] = new variation();                           
            }
            
            List<double> reps = variation.GetReps(sample, upper_interval, lower_interval, classes, variants);
            for (int i = 0; i < Axis.Count; i++)
                variants[i].value = Axis[i];
            for (int i = 0; i < reps.Count; i++)
                variants[i].reps = reps[i];
            for (int l = 0; l < variants.Length; l++)
                variants[l].freq = variants[l].reps / sample.Count;
            
            return variants;
        }
        private List<double> GetConfidenceInterval(double local_theta, double squared_value,int N, double probability)
        {
            List<double> trustIntervals = new List<double>();               
            int degreeOfFreedom = N - 1;
            double quantile = 0;
            if (N > 60)
                quantile = chart.DataManipulator.Statistics.InverseTDistribution(probability, degreeOfFreedom);
            else
                quantile = chart.DataManipulator.Statistics.InverseNormalDistribution(probability);
            
            double lower = local_theta - (quantile * squared_value);            
            double upper = local_theta + (quantile * squared_value);            

            trustIntervals.Add(lower);
            trustIntervals.Add(local_theta);
            trustIntervals.Add(upper);

            return trustIntervals;
        }
        /*public double GetF(double z_score)
        {            
            return chart.DataManipulator.Statistics.InverseNormalDistribution(chart.DataManipulator.Statistics.NormalDistribution(z_score));            
        }
        public double GetZscore(List<double> intervals, int i)
        {
            return (intervals[i] - avg) / sigma;        
        }*/
        private double GetP(int i, int N)
        {
            return (i - 0.5) / N;
        }
        /*public double GetStandardDev(List<double> sample)
        {
            double sum = 0;
            for(int i = 0; i < sample.Count; i++)
            {
                sum += Math.Abs(sample[i]-avg);
            }
            return Math.Sqrt(Math.Pow(sum, 2) / sample.Count);
        }*/

        #endregion

        #region Transformation
        public List<string> ToString(List<double> cleaned)
        {
            List<string> na = new List<string>();
            foreach (var i in cleaned)
                na.Add(i.ToString());
            return na;
        }     
        public List<double> ToSort(List<double> sample)
        {
            double forSwap;
            for (int i = 0; i < sample.Count; i++)
            {
                for (int j = 0; j < sample.Count - 1 - i; j++)
                {
                    if (sample[j] > sample[j + 1])
                    {
                        forSwap = sample[j + 1];
                        sample[j + 1] = sample[j];
                        sample[j] = forSwap;
                    }
                }
            }
            return sample;
        }
        public double[] ToSort(double[] sample)
        {
            double forSwap;
            for (int i = 0; i < sample.Length; i++)
            {
                for (int j = 0; j < sample.Length - 1 - i; j++)
                {
                    if (sample[j] > sample[j + 1])
                    {
                        forSwap = sample[j + 1];
                        sample[j + 1] = sample[j];
                        sample[j] = forSwap;
                    }
                }
            }
            return sample;
        }
        public List<double> ListConv(List<string> str_list)
        {
            variant.Text = "";
            result.Text = "";
            List<double> temp = new List<double>();
            double num;
            for (int i = 0; i < str_list.Count; i++)
            {
                double.TryParse(str_list[i], out num);
                temp.Add(num);
            }
            return temp;
        }
        /// <summary>
        /// Перевірка на наявність аномальних значень.
        /// </summary>
        /// <returns>Список значень без аномалій, інакше - список без змін.</returns>
        public List<double> Anomaly_review(List<double> sample, double excess, double average, double asymmetry, double sigma)
        {
            decimal a, b;
            List<double> no_anomalies = new List<double>();

            decimal t1 = (decimal)(2 + 0.2 * Math.Log10(0.04 * son.Count));
            decimal t2 = (decimal)(Math.Sqrt(19 * (Math.Sqrt(excess + 2)) + 1));

            if (asymmetry < -0.2)
            {
                a = (decimal)(average - (double)t2 * sigma);
                b = (decimal)(average + (double)t1 * sigma);
            }
            else if (asymmetry > 0.2)
            {
                a = (decimal)(average - (double)t1 * sigma);
                b = (decimal)(average + (double)t2 * sigma);
            }
            else if (Math.Abs(asymmetry) <= 0.2)
            {
                a = (decimal)(average - (double)t1 * sigma);
                b = (decimal)(average + (double)t1 * sigma);
            }
            else
                throw new ArgumentException();
            
            MessageBox.Show($"\nA:{Math.Round(a, 4)}\nB:{Math.Round(b, 4)}\n", "");

            //добавляємо не аномальні значення в массив
            for (int i = 0; i < sample.Count; i++)
            {
                if (sample[i] >= (double)a && sample[i] <= (double)b)
                    no_anomalies.Add(sample[i]);
            }
            return no_anomalies;
        }
        public int GetClasses(List<double> sample)
        {
            int N = sample.Count;
            int num = 0;

            if (column_bar.Value > 1)
                num = column_bar.Value;
            else if (N >= 100 && N % 2 == 0)
                num = (int)Math.Pow(N, 1.0 / 3.0);
            else if (N >= 100 && N % 2 != 0)
                num = (int)Math.Pow(N, 1.0 / 3.0) - 1;
            else
                num = Convert.ToInt32(1 + 3.322 * Math.Log10((double)N));

            return num;
        }
        #endregion

        #endregion
    }
    #region HelpClasses
    /// <summary>
    /// Варіаційний ряд з полями для варіанти, кількості повторень, відносної частоти.
    /// </summary>
    public class variation 
    {
        public double value;
        public double reps;
        public double freq;
        /// <returns>Список повторень на інтервалах.</returns>
        public static List<double> GetReps(List<double> sample, List<double> upper_interval, List<double> lower_interval, int classes, variation[] variants)
        {
            for (int i = 0; i < classes; i++)
            {
                for (int j = 0; j < sample.Count; j++)
                {
                    if (lower_interval[i] <= sample[j] && sample[j] <= upper_interval[i])
                        variants[i].reps++;
                }
            }
            List<double> reps = new List<double>();
            for (int i = 0; i < variants.Length; i++)
                reps.Add(variants[i].reps);

            return reps;
        }
    }
    /// <summary>
    /// Рахує накопичені відносні частоти.
    /// </summary>
    public class Empiric
    {
        public static List<double> GetFreqs(variation[] variants)
        {
            List<double> no_nulls = GetAscendingReps(variants);

            List<double> result = new List<double>();            
            result.Add(no_nulls[0]);
            for (int i = 1; i < no_nulls.Count; i++)
                result.Add(Math.Round(result[i - 1] + no_nulls[i],3));

            return result;
        }
        public static List<double> GetNotZero(variation[] variants)
        {
            List<double> proceed = new List<double>();
            for (int i = 0; i < variants.Length; i++)
            {
                if (variants[i].reps != 0)
                    proceed.Add(variants[i].freq);
            }            
            return proceed;
        }   
        public static List<double> GetAscendingReps(variation[] variants)
        {
            List<double> result = new List<double>();
            
            double sum = 0;
            for (int i = 0; i < variants.Length; i++)
                sum += variants[i].reps;

            for(int i = 0; i < variants.Length; i++)
                result.Add(variants[i].reps / sum);

            return result;
        }
    }
    
    /// <summary>
    /// class for changing distributions into linear form(for minimum squares method, for instance)
    /// </summary>
    public partial class LinearForm//: Sample
    {                
        //TODO: complete these functions
        //(they're the same as reversed functions actually lol, so i can use them in these cases as well)
        public double ChangeExponential(double lambda, double x, double f_theoretical)
        {
            return Math.Log((1.0 / f_theoretical));
        }
        public double ChangeWeibull(double lambda, double x, double f_theoretical)
        {
            return Math.Log((1.0 / f_theoretical));
        }
        public double ChangeNormal(double lambda, double x, double f_theoretical)
        {
            return Math.Log((1.0 / f_theoretical));
        }
        public double ChangeUniform(double lambda, double x, double f_theoretical)
        {
            return Math.Log((1.0 / f_theoretical));
        }        
    }
    #endregion
}