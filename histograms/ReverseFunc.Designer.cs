namespace histograms
{
    partial class ReverseFunc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.spanel1 = new System.Windows.Forms.Panel();
            this.slabel6 = new System.Windows.Forms.Label();
            this.sample_beta = new System.Windows.Forms.TextBox();
            this.slabel5 = new System.Windows.Forms.Label();
            this.sample_size = new System.Windows.Forms.TextBox();
            this.slabel4 = new System.Windows.Forms.Label();
            this.sample_lambda = new System.Windows.Forms.TextBox();
            this.slabel3 = new System.Windows.Forms.Label();
            this.Create_btn = new System.Windows.Forms.Button();
            this.Clear_btn = new System.Windows.Forms.Button();
            this.spanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // spanel1
            // 
            this.spanel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.spanel1.Controls.Add(this.Clear_btn);
            this.spanel1.Controls.Add(this.Create_btn);
            this.spanel1.Controls.Add(this.slabel6);
            this.spanel1.Controls.Add(this.sample_beta);
            this.spanel1.Controls.Add(this.slabel5);
            this.spanel1.Controls.Add(this.sample_size);
            this.spanel1.Controls.Add(this.slabel4);
            this.spanel1.Controls.Add(this.sample_lambda);
            this.spanel1.Controls.Add(this.slabel3);
            this.spanel1.Location = new System.Drawing.Point(12, 12);
            this.spanel1.Name = "spanel1";
            this.spanel1.Size = new System.Drawing.Size(497, 297);
            this.spanel1.TabIndex = 14;
            // 
            // slabel6
            // 
            this.slabel6.AutoSize = true;
            this.slabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.slabel6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.slabel6.Location = new System.Drawing.Point(197, 191);
            this.slabel6.Name = "slabel6";
            this.slabel6.Size = new System.Drawing.Size(45, 25);
            this.slabel6.TabIndex = 14;
            this.slabel6.Text = " β =";
            this.slabel6.Visible = false;
            // 
            // sample_beta
            // 
            this.sample_beta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.sample_beta.Location = new System.Drawing.Point(253, 193);
            this.sample_beta.Name = "sample_beta";
            this.sample_beta.Size = new System.Drawing.Size(62, 24);
            this.sample_beta.TabIndex = 13;
            // 
            // slabel5
            // 
            this.slabel5.AutoSize = true;
            this.slabel5.Font = new System.Drawing.Font("Times New Roman", 13.2F);
            this.slabel5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.slabel5.Location = new System.Drawing.Point(12, 33);
            this.slabel5.Name = "slabel5";
            this.slabel5.Size = new System.Drawing.Size(398, 25);
            this.slabel5.TabIndex = 12;
            this.slabel5.Text = "Введіть параметри для генерації вибірки";
            this.slabel5.Visible = false;
            // 
            // sample_size
            // 
            this.sample_size.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.sample_size.Location = new System.Drawing.Point(253, 85);
            this.sample_size.Name = "sample_size";
            this.sample_size.Size = new System.Drawing.Size(93, 24);
            this.sample_size.TabIndex = 8;
            // 
            // slabel4
            // 
            this.slabel4.AutoSize = true;
            this.slabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.slabel4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.slabel4.Location = new System.Drawing.Point(197, 152);
            this.slabel4.Name = "slabel4";
            this.slabel4.Size = new System.Drawing.Size(39, 25);
            this.slabel4.TabIndex = 11;
            this.slabel4.Text = "λ =";
            this.slabel4.Visible = false;
            // 
            // sample_lambda
            // 
            this.sample_lambda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.sample_lambda.Location = new System.Drawing.Point(253, 154);
            this.sample_lambda.Name = "sample_lambda";
            this.sample_lambda.Size = new System.Drawing.Size(62, 24);
            this.sample_lambda.TabIndex = 9;
            // 
            // slabel3
            // 
            this.slabel3.AutoSize = true;
            this.slabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.slabel3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.slabel3.Location = new System.Drawing.Point(81, 85);
            this.slabel3.Name = "slabel3";
            this.slabel3.Size = new System.Drawing.Size(166, 20);
            this.slabel3.TabIndex = 10;
            this.slabel3.Text = "Обсяг вибірки(N) =";
            this.slabel3.Visible = false;
            // 
            // Create_btn
            // 
            this.Create_btn.Location = new System.Drawing.Point(17, 245);
            this.Create_btn.Name = "Create_btn";
            this.Create_btn.Size = new System.Drawing.Size(109, 39);
            this.Create_btn.TabIndex = 15;
            this.Create_btn.Text = "Створити";
            this.Create_btn.UseVisualStyleBackColor = true;
            this.Create_btn.Click += new System.EventHandler(this.Create_btn_Click);
            // 
            // Clear_btn
            // 
            this.Clear_btn.Location = new System.Drawing.Point(374, 245);
            this.Clear_btn.Name = "Clear_btn";
            this.Clear_btn.Size = new System.Drawing.Size(109, 39);
            this.Clear_btn.TabIndex = 16;
            this.Clear_btn.Text = "Очистити";
            this.Clear_btn.UseVisualStyleBackColor = true;
            this.Clear_btn.Click += new System.EventHandler(this.Clear_btn_Click);
            // 
            // ReverseFunc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 321);
            this.Controls.Add(this.spanel1);
            this.Name = "ReverseFunc";
            this.Text = "Обернена функція";
            this.spanel1.ResumeLayout(false);
            this.spanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel spanel1;
        private System.Windows.Forms.Label slabel6;
        private System.Windows.Forms.TextBox sample_beta;
        private System.Windows.Forms.Label slabel5;
        private System.Windows.Forms.TextBox sample_size;
        private System.Windows.Forms.Label slabel4;
        private System.Windows.Forms.TextBox sample_lambda;
        private System.Windows.Forms.Label slabel3;
        private System.Windows.Forms.Button Clear_btn;
        private System.Windows.Forms.Button Create_btn;
    }
}