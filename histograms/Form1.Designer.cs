namespace histograms
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.file_button = new System.Windows.Forms.Button();
            this.column_bar = new System.Windows.Forms.TrackBar();
            this.create = new System.Windows.Forms.Button();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.prob_grid = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.result = new System.Windows.Forms.DataGridView();
            this.statistics = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.values = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trusted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sqrd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.variationGrid = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.variant = new System.Windows.Forms.RichTextBox();
            this.log_button = new System.Windows.Forms.Button();
            this.standart_button = new System.Windows.Forms.Button();
            this.probability_field = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.a_value = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.відкритиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.перетворенняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.логарифмуванняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.стандартизаціяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.column_bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prob_grid)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.result)).BeginInit();
            this.tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.variationGrid)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // file_button
            // 
            resources.ApplyResources(this.file_button, "file_button");
            this.file_button.Name = "file_button";
            this.file_button.UseVisualStyleBackColor = true;
            this.file_button.Click += new System.EventHandler(this.file_button_Click);
            // 
            // column_bar
            // 
            this.column_bar.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.column_bar, "column_bar");
            this.column_bar.Maximum = 25;
            this.column_bar.Name = "column_bar";
            this.column_bar.Scroll += new System.EventHandler(this.column_bar_Scroll);
            // 
            // create
            // 
            resources.ApplyResources(this.create, "create");
            this.create.Name = "create";
            this.create.UseVisualStyleBackColor = true;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // chart
            // 
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            this.chart.IsSoftShadows = false;
            resources.ApplyResources(this.chart, "chart");
            this.chart.Name = "chart";
            this.chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series1.BorderColor = System.Drawing.Color.Black;
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.SystemColors.InactiveCaption;
            series1.CustomProperties = "PointWidth=1";
            series1.Name = "Series1";
            this.chart.Series.Add(series1);
            this.chart.Click += new System.EventHandler(this.chart_Click);
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            resources.ApplyResources(this.tabControl2, "tabControl2");
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.chart);
            this.tabPage3.Controls.Add(this.column_bar);
            resources.ApplyResources(this.tabPage3, "tabPage3");
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.trackBar1);
            this.tabPage4.Controls.Add(this.chart1);
            this.tabPage4.Controls.Add(this.prob_grid);
            resources.ApplyResources(this.tabPage4, "tabPage4");
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.trackBar1, "trackBar1");
            this.trackBar1.Maximum = 25;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            resources.ApplyResources(this.chart1, "chart1");
            this.chart1.Name = "chart1";
            series2.BorderColor = System.Drawing.Color.Black;
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine;
            series2.Color = System.Drawing.Color.Maroon;
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            // 
            // prob_grid
            // 
            chartArea3.Name = "ChartArea1";
            this.prob_grid.ChartAreas.Add(chartArea3);
            resources.ApplyResources(this.prob_grid, "prob_grid");
            this.prob_grid.Name = "prob_grid";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            series3.Name = "Series1";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series4.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            series4.Name = "Series2";
            this.prob_grid.Series.Add(series3);
            this.prob_grid.Series.Add(series4);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage7);
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.result);
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // result
            // 
            this.result.BackgroundColor = System.Drawing.Color.White;
            this.result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.result.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.statistics,
            this.values,
            this.trusted,
            this.sqrd});
            resources.ApplyResources(this.result, "result");
            this.result.Name = "result";
            this.result.RowHeadersVisible = false;
            this.result.RowTemplate.Height = 24;
            // 
            // statistics
            // 
            this.statistics.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            resources.ApplyResources(this.statistics, "statistics");
            this.statistics.Name = "statistics";
            this.statistics.ReadOnly = true;
            // 
            // values
            // 
            this.values.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            resources.ApplyResources(this.values, "values");
            this.values.Name = "values";
            this.values.ReadOnly = true;
            // 
            // trusted
            // 
            this.trusted.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            resources.ApplyResources(this.trusted, "trusted");
            this.trusted.Name = "trusted";
            this.trusted.ReadOnly = true;
            // 
            // sqrd
            // 
            resources.ApplyResources(this.sqrd, "sqrd");
            this.sqrd.Name = "sqrd";
            this.sqrd.ReadOnly = true;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.variationGrid);
            this.tabPage7.Controls.Add(this.variant);
            resources.ApplyResources(this.tabPage7, "tabPage7");
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // variationGrid
            // 
            this.variationGrid.BackgroundColor = System.Drawing.Color.White;
            this.variationGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.variationGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column1,
            this.Column2,
            this.Column3});
            this.variationGrid.GridColor = System.Drawing.Color.DimGray;
            resources.ApplyResources(this.variationGrid, "variationGrid");
            this.variationGrid.Name = "variationGrid";
            this.variationGrid.RowHeadersVisible = false;
            this.variationGrid.RowTemplate.Height = 24;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            resources.ApplyResources(this.Column4, "Column4");
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column1
            // 
            resources.ApplyResources(this.Column1, "Column1");
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            resources.ApplyResources(this.Column2, "Column2");
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            resources.ApplyResources(this.Column3, "Column3");
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // variant
            // 
            resources.ApplyResources(this.variant, "variant");
            this.variant.Name = "variant";
            this.variant.ReadOnly = true;
            // 
            // log_button
            // 
            resources.ApplyResources(this.log_button, "log_button");
            this.log_button.Name = "log_button";
            this.log_button.UseVisualStyleBackColor = true;
            this.log_button.Click += new System.EventHandler(this.log_button_Click);
            // 
            // standart_button
            // 
            resources.ApplyResources(this.standart_button, "standart_button");
            this.standart_button.Name = "standart_button";
            this.standart_button.UseVisualStyleBackColor = true;
            this.standart_button.Click += new System.EventHandler(this.standart_button_Click);
            // 
            // probability_field
            // 
            resources.ApplyResources(this.probability_field, "probability_field");
            this.probability_field.Name = "probability_field";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // a_value
            // 
            resources.ApplyResources(this.a_value, "a_value");
            this.a_value.Name = "a_value";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.перетворенняToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.відкритиToolStripMenuItem,
            this.очиститиToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            resources.ApplyResources(this.файлToolStripMenuItem, "файлToolStripMenuItem");
            // 
            // відкритиToolStripMenuItem
            // 
            this.відкритиToolStripMenuItem.Name = "відкритиToolStripMenuItem";
            resources.ApplyResources(this.відкритиToolStripMenuItem, "відкритиToolStripMenuItem");
            // 
            // очиститиToolStripMenuItem
            // 
            this.очиститиToolStripMenuItem.Name = "очиститиToolStripMenuItem";
            resources.ApplyResources(this.очиститиToolStripMenuItem, "очиститиToolStripMenuItem");
            // 
            // перетворенняToolStripMenuItem
            // 
            this.перетворенняToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.логарифмуванняToolStripMenuItem,
            this.стандартизаціяToolStripMenuItem});
            this.перетворенняToolStripMenuItem.Name = "перетворенняToolStripMenuItem";
            resources.ApplyResources(this.перетворенняToolStripMenuItem, "перетворенняToolStripMenuItem");
            // 
            // логарифмуванняToolStripMenuItem
            // 
            this.логарифмуванняToolStripMenuItem.Name = "логарифмуванняToolStripMenuItem";
            resources.ApplyResources(this.логарифмуванняToolStripMenuItem, "логарифмуванняToolStripMenuItem");
            // 
            // стандартизаціяToolStripMenuItem
            // 
            this.стандартизаціяToolStripMenuItem.Name = "стандартизаціяToolStripMenuItem";
            resources.ApplyResources(this.стандартизаціяToolStripMenuItem, "стандартизаціяToolStripMenuItem");
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.a_value);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.probability_field);
            this.Controls.Add(this.standart_button);
            this.Controls.Add(this.log_button);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.create);
            this.Controls.Add(this.file_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.column_bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prob_grid)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.result)).EndInit();
            this.tabPage7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.variationGrid)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button file_button;
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.RichTextBox variant;
        private System.Windows.Forms.Button log_button;
        private System.Windows.Forms.Button standart_button;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        public System.Windows.Forms.TrackBar column_bar;
        private System.Windows.Forms.TextBox probability_field;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart prob_grid;
        private System.Windows.Forms.TextBox a_value;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView result;
        private System.Windows.Forms.DataGridView variationGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        public System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.DataGridViewTextBoxColumn statistics;
        private System.Windows.Forms.DataGridViewTextBoxColumn values;
        private System.Windows.Forms.DataGridViewTextBoxColumn trusted;
        private System.Windows.Forms.DataGridViewTextBoxColumn sqrd;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem відкритиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очиститиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem перетворенняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem логарифмуванняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem стандартизаціяToolStripMenuItem;
    }
}

