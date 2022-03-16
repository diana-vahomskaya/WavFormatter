namespace WavSin
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Signal = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Ampl = new System.Windows.Forms.TextBox();
            this.Freq = new System.Windows.Forms.TextBox();
            this.Phas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Array = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.Button();
            this.FREQ_DIS = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.FreqGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Freq_Second = new System.Windows.Forms.TextBox();
            this.WAVCreator = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Signal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FreqGraph)).BeginInit();
            this.SuspendLayout();
            // 
            // Signal
            // 
            chartArea3.AxisX.Interval = 10D;
            chartArea3.Name = "ChartArea1";
            this.Signal.ChartAreas.Add(chartArea3);
            legend3.Enabled = false;
            legend3.Name = "Legend1";
            this.Signal.Legends.Add(legend3);
            this.Signal.Location = new System.Drawing.Point(26, 22);
            this.Signal.Name = "Signal";
            series3.BorderWidth = 2;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Color = System.Drawing.Color.DarkRed;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.Signal.Series.Add(series3);
            this.Signal.Size = new System.Drawing.Size(1141, 334);
            this.Signal.TabIndex = 0;
            this.Signal.Text = "chart1";
            // 
            // Ampl
            // 
            this.Ampl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Ampl.Location = new System.Drawing.Point(235, 415);
            this.Ampl.Name = "Ampl";
            this.Ampl.Size = new System.Drawing.Size(100, 23);
            this.Ampl.TabIndex = 1;
            this.Ampl.Text = "3";
            // 
            // Freq
            // 
            this.Freq.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Freq.Location = new System.Drawing.Point(235, 456);
            this.Freq.Name = "Freq";
            this.Freq.Size = new System.Drawing.Size(100, 23);
            this.Freq.TabIndex = 2;
            this.Freq.Text = "0.2";
            // 
            // Phas
            // 
            this.Phas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Phas.Location = new System.Drawing.Point(235, 499);
            this.Phas.Name = "Phas";
            this.Phas.Size = new System.Drawing.Size(100, 23);
            this.Phas.TabIndex = 3;
            this.Phas.Text = "5";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(60, 418);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Амплитуда";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(60, 459);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Частота (Гц)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(60, 502);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Фаза";
            // 
            // Array
            // 
            this.Array.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Array.Location = new System.Drawing.Point(235, 538);
            this.Array.Name = "Array";
            this.Array.Size = new System.Drawing.Size(100, 23);
            this.Array.TabIndex = 7;
            this.Array.Text = "128";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(60, 541);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Последовательность";
            // 
            // Start
            // 
            this.Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Start.Location = new System.Drawing.Point(1063, 459);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(94, 35);
            this.Start.TabIndex = 9;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // FREQ_DIS
            // 
            this.FREQ_DIS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.FREQ_DIS.Location = new System.Drawing.Point(235, 584);
            this.FREQ_DIS.Name = "FREQ_DIS";
            this.FREQ_DIS.Size = new System.Drawing.Size(100, 23);
            this.FREQ_DIS.TabIndex = 10;
            this.FREQ_DIS.Text = "1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(60, 587);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Частота дискретизации";
            // 
            // FreqGraph
            // 
            chartArea4.Name = "ChartArea1";
            this.FreqGraph.ChartAreas.Add(chartArea4);
            legend4.Enabled = false;
            legend4.Name = "Legend1";
            this.FreqGraph.Legends.Add(legend4);
            this.FreqGraph.Location = new System.Drawing.Point(430, 378);
            this.FreqGraph.Name = "FreqGraph";
            series4.BorderWidth = 2;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Color = System.Drawing.Color.Green;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.FreqGraph.Series.Add(series4);
            this.FreqGraph.Size = new System.Drawing.Size(578, 258);
            this.FreqGraph.TabIndex = 12;
            this.FreqGraph.Text = "chart1";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(1042, 415);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(152, 17);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "Зависимость от частоты";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(60, 630);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Частота2 (Гц)";
            // 
            // Freq_Second
            // 
            this.Freq_Second.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Freq_Second.Location = new System.Drawing.Point(235, 627);
            this.Freq_Second.Name = "Freq_Second";
            this.Freq_Second.Size = new System.Drawing.Size(100, 23);
            this.Freq_Second.TabIndex = 14;
            this.Freq_Second.Text = "0,4";
            // 
            // WAVCreator
            // 
            this.WAVCreator.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.WAVCreator.Location = new System.Drawing.Point(1042, 529);
            this.WAVCreator.Name = "WAVCreator";
            this.WAVCreator.Size = new System.Drawing.Size(131, 40);
            this.WAVCreator.TabIndex = 16;
            this.WAVCreator.Text = "Create Wav";
            this.WAVCreator.UseVisualStyleBackColor = true;
            this.WAVCreator.Click += new System.EventHandler(this.WAVCreator_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 669);
            this.Controls.Add(this.WAVCreator);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Freq_Second);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.FreqGraph);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.FREQ_DIS);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Array);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Phas);
            this.Controls.Add(this.Freq);
            this.Controls.Add(this.Ampl);
            this.Controls.Add(this.Signal);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Signal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FreqGraph)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart Signal;
        private System.Windows.Forms.TextBox Ampl;
        private System.Windows.Forms.TextBox Freq;
        private System.Windows.Forms.TextBox Phas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Array;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.TextBox FREQ_DIS;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataVisualization.Charting.Chart FreqGraph;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Freq_Second;
        private System.Windows.Forms.Button WAVCreator;
    }
}

