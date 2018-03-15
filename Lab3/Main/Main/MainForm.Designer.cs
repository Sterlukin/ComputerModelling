namespace Main
{
    partial class MainForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numUDInterv = new System.Windows.Forms.NumericUpDown();
            this.numUDSample = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBoxMx = new System.Windows.Forms.TextBox();
            this.txtBoxDx = new System.Windows.Forms.TextBox();
            this.txtBoxPirson = new System.Windows.Forms.TextBox();
            this.txtBoxKolmog = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDInterv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDSample)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea7.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.chart1.Legends.Add(legend7);
            this.chart1.Location = new System.Drawing.Point(213, 27);
            this.chart1.Name = "chart1";
            series7.ChartArea = "ChartArea1";
            series7.Legend = "Legend1";
            series7.Name = "Series1";
            this.chart1.Series.Add(series7);
            this.chart1.Size = new System.Drawing.Size(399, 300);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // chart2
            // 
            chartArea8.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea8);
            legend8.Name = "Legend1";
            this.chart2.Legends.Add(legend8);
            this.chart2.Location = new System.Drawing.Point(618, 27);
            this.chart2.Name = "chart2";
            series8.ChartArea = "ChartArea1";
            series8.Legend = "Legend1";
            series8.Name = "Series1";
            this.chart2.Series.Add(series8);
            this.chart2.Size = new System.Drawing.Size(402, 300);
            this.chart2.TabIndex = 1;
            this.chart2.Text = "chart2";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.numUDSample);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.numUDInterv);
            this.panel1.Location = new System.Drawing.Point(1, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(206, 81);
            this.panel1.TabIndex = 2;
            // 
            // numUDInterv
            // 
            this.numUDInterv.Location = new System.Drawing.Point(139, 13);
            this.numUDInterv.Name = "numUDInterv";
            this.numUDInterv.Size = new System.Drawing.Size(59, 20);
            this.numUDInterv.TabIndex = 3;
            this.numUDInterv.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // numUDSample
            // 
            this.numUDSample.Location = new System.Drawing.Point(139, 49);
            this.numUDSample.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numUDSample.Name = "numUDSample";
            this.numUDSample.Size = new System.Drawing.Size(59, 20);
            this.numUDSample.TabIndex = 4;
            this.numUDSample.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Кол-во интервалов:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Объём выборки:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Данные:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(59, 114);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(102, 34);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "Рассчитать";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtBoxKolmog);
            this.panel2.Controls.Add(this.txtBoxPirson);
            this.panel2.Controls.Add(this.txtBoxDx);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtBoxMx);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(1, 179);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(206, 148);
            this.panel2.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Статистические данные:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Дисперсия:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Мат.ожидание:";
            // 
            // txtBoxMx
            // 
            this.txtBoxMx.Location = new System.Drawing.Point(105, 15);
            this.txtBoxMx.Name = "txtBoxMx";
            this.txtBoxMx.ReadOnly = true;
            this.txtBoxMx.Size = new System.Drawing.Size(93, 20);
            this.txtBoxMx.TabIndex = 8;
            // 
            // txtBoxDx
            // 
            this.txtBoxDx.Location = new System.Drawing.Point(105, 51);
            this.txtBoxDx.Name = "txtBoxDx";
            this.txtBoxDx.ReadOnly = true;
            this.txtBoxDx.Size = new System.Drawing.Size(93, 20);
            this.txtBoxDx.TabIndex = 9;
            // 
            // txtBoxPirson
            // 
            this.txtBoxPirson.Location = new System.Drawing.Point(105, 87);
            this.txtBoxPirson.Name = "txtBoxPirson";
            this.txtBoxPirson.ReadOnly = true;
            this.txtBoxPirson.Size = new System.Drawing.Size(93, 20);
            this.txtBoxPirson.TabIndex = 10;
            // 
            // txtBoxKolmog
            // 
            this.txtBoxKolmog.Location = new System.Drawing.Point(105, 123);
            this.txtBoxKolmog.Name = "txtBoxKolmog";
            this.txtBoxKolmog.ReadOnly = true;
            this.txtBoxKolmog.Size = new System.Drawing.Size(93, 20);
            this.txtBoxKolmog.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "Пирсон:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 15);
            this.label8.TabIndex = 12;
            this.label8.Text = "Колмогоров:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 503);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Name = "MainForm";
            this.Text = "Lab3";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDInterv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDSample)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numUDSample;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numUDInterv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxDx;
        private System.Windows.Forms.TextBox txtBoxMx;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBoxKolmog;
        private System.Windows.Forms.TextBox txtBoxPirson;
    }
}

