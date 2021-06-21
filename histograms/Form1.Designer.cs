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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea16 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series21 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea17 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series22 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea18 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series23 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series24 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.column_bar = new System.Windows.Forms.TrackBar();
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
            this.probability_field = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.a_value = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.file_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.openFile = new System.Windows.Forms.ToolStripMenuItem();
            this.clearFile = new System.Windows.Forms.ToolStripMenuItem();
            this.transformation_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.toLog = new System.Windows.Forms.ToolStripMenuItem();
            this.toNormal = new System.Windows.Forms.ToolStripMenuItem();
            this.createFile = new System.Windows.Forms.ToolStripMenuItem();
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
            // column_bar
            // 
            this.column_bar.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.column_bar, "column_bar");
            this.column_bar.Maximum = 25;
            this.column_bar.Name = "column_bar";
            this.column_bar.Scroll += new System.EventHandler(this.column_bar_Scroll);
            // 
            // chart
            // 
            chartArea16.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea16);
            this.chart.IsSoftShadows = false;
            resources.ApplyResources(this.chart, "chart");
            this.chart.Name = "chart";
            this.chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series21.BorderColor = System.Drawing.Color.Black;
            series21.ChartArea = "ChartArea1";
            series21.Color = System.Drawing.SystemColors.InactiveCaption;
            series21.CustomProperties = "PointWidth=1";
            series21.Name = "Series1";
            this.chart.Series.Add(series21);
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
            chartArea17.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea17);
            resources.ApplyResources(this.chart1, "chart1");
            this.chart1.Name = "chart1";
            series22.BorderColor = System.Drawing.Color.Black;
            series22.BorderWidth = 2;
            series22.ChartArea = "ChartArea1";
            series22.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine;
            series22.Color = System.Drawing.Color.Maroon;
            series22.Name = "Series1";
            this.chart1.Series.Add(series22);
            // 
            // prob_grid
            // 
            chartArea18.Name = "ChartArea1";
            this.prob_grid.ChartAreas.Add(chartArea18);
            resources.ApplyResources(this.prob_grid, "prob_grid");
            this.prob_grid.Name = "prob_grid";
            series23.ChartArea = "ChartArea1";
            series23.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series23.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            series23.Name = "Series1";
            series24.ChartArea = "ChartArea1";
            series24.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series24.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            series24.Name = "Series2";
            this.prob_grid.Series.Add(series23);
            this.prob_grid.Series.Add(series24);
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
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.file_menu,
            this.transformation_menu,
            this.createFile});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // file_menu
            // 
            this.file_menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFile,
            this.clearFile});
            this.file_menu.Name = "file_menu";
            resources.ApplyResources(this.file_menu, "file_menu");
            // 
            // openFile
            // 
            this.openFile.Name = "openFile";
            resources.ApplyResources(this.openFile, "openFile");
            this.openFile.Click += new System.EventHandler(this.openFile_Click);
            // 
            // clearFile
            // 
            this.clearFile.Name = "clearFile";
            resources.ApplyResources(this.clearFile, "clearFile");
            this.clearFile.Click += new System.EventHandler(this.clearFile_Click);
            // 
            // transformation_menu
            // 
            this.transformation_menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toLog,
            this.toNormal});
            this.transformation_menu.Name = "transformation_menu";
            resources.ApplyResources(this.transformation_menu, "transformation_menu");
            // 
            // toLog
            // 
            this.toLog.Name = "toLog";
            resources.ApplyResources(this.toLog, "toLog");
            this.toLog.Click += new System.EventHandler(this.toLog_Click);
            // 
            // toNormal
            // 
            this.toNormal.Name = "toNormal";
            resources.ApplyResources(this.toNormal, "toNormal");
            this.toNormal.Click += new System.EventHandler(this.toNormal_Click);
            // 
            // createFile
            // 
            this.createFile.Name = "createFile";
            resources.ApplyResources(this.createFile, "createFile");
            this.createFile.Click += new System.EventHandler(this.createFile_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.a_value);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.probability_field);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.tabControl2);
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
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.RichTextBox variant;
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
        private System.Windows.Forms.ToolStripMenuItem file_menu;
        private System.Windows.Forms.ToolStripMenuItem openFile;
        private System.Windows.Forms.ToolStripMenuItem clearFile;
        private System.Windows.Forms.ToolStripMenuItem transformation_menu;
        private System.Windows.Forms.ToolStripMenuItem toLog;        
        private System.Windows.Forms.ToolStripMenuItem toNormal;
        private System.Windows.Forms.ToolStripMenuItem createFile;
    }
}

