﻿namespace RandomLab1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.buttonCount = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUDSequencySize = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUDSectionsNumber = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numeriUDSampleSize = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBoxCm3 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBoxMx = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBoxDx = new System.Windows.Forms.TextBox();
            this.txtBoxCm2 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtBoxRh = new System.Windows.Forms.TextBox();
            this.txtBoxRb = new System.Windows.Forms.TextBox();
            this.txtBoxPirson = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtBoxKolmogorov = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtBoxR = new System.Windows.Forms.TextBox();
            this.lblSeriesHypotize = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUDSequencySize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUDSectionsNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeriUDSampleSize)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCount
            // 
            this.buttonCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCount.Location = new System.Drawing.Point(80, 152);
            this.buttonCount.Name = "buttonCount";
            this.buttonCount.Size = new System.Drawing.Size(131, 35);
            this.buttonCount.TabIndex = 0;
            this.buttonCount.Text = "Рассчитать";
            this.buttonCount.UseVisualStyleBackColor = true;
            this.buttonCount.Click += new System.EventHandler(this.buttonCountClick);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(269, 32);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(383, 312);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(658, 30);
            this.chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(383, 314);
            this.chart2.TabIndex = 2;
            this.chart2.Text = "chart2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(369, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Гистограмма частот";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(697, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(301, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Статистическая ф-ия распределения";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.numericUDSequencySize);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.numericUDSectionsNumber);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.numeriUDSampleSize);
            this.panel1.Location = new System.Drawing.Point(12, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(251, 114);
            this.panel1.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(16, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Размер послед-ти:";
            // 
            // numericUDSequencySize
            // 
            this.numericUDSequencySize.Location = new System.Drawing.Point(174, 78);
            this.numericUDSequencySize.Name = "numericUDSequencySize";
            this.numericUDSequencySize.Size = new System.Drawing.Size(58, 20);
            this.numericUDSequencySize.TabIndex = 8;
            this.numericUDSequencySize.Value = new decimal(new int[] {
            64,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(16, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Участки разбиения:";
            // 
            // numericUDSectionsNumber
            // 
            this.numericUDSectionsNumber.Location = new System.Drawing.Point(174, 42);
            this.numericUDSectionsNumber.Name = "numericUDSectionsNumber";
            this.numericUDSectionsNumber.Size = new System.Drawing.Size(58, 20);
            this.numericUDSectionsNumber.TabIndex = 7;
            this.numericUDSectionsNumber.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(16, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Объём выборки:";
            // 
            // numeriUDSampleSize
            // 
            this.numeriUDSampleSize.Location = new System.Drawing.Point(174, 9);
            this.numeriUDSampleSize.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numeriUDSampleSize.Name = "numeriUDSampleSize";
            this.numeriUDSampleSize.Size = new System.Drawing.Size(58, 20);
            this.numeriUDSampleSize.TabIndex = 7;
            this.numeriUDSampleSize.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(92, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Данные";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(77, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 18);
            this.label7.TabIndex = 7;
            this.label7.Text = "Характеристики";
            this.label7.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.txtBoxCm3);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txtBoxMx);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtBoxDx);
            this.panel2.Controls.Add(this.txtBoxCm2);
            this.panel2.Location = new System.Drawing.Point(12, 232);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(251, 112);
            this.panel2.TabIndex = 8;
            this.panel2.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(16, 81);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 17);
            this.label11.TabIndex = 12;
            this.label11.Text = "Нач.3-й момент:";
            // 
            // txtBoxCm3
            // 
            this.txtBoxCm3.Location = new System.Drawing.Point(146, 81);
            this.txtBoxCm3.Name = "txtBoxCm3";
            this.txtBoxCm3.Size = new System.Drawing.Size(100, 20);
            this.txtBoxCm3.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(16, 55);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 17);
            this.label10.TabIndex = 11;
            this.label10.Text = "Нач.2-й момент:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(16, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 17);
            this.label9.TabIndex = 10;
            this.label9.Text = "Дисперсия:";
            // 
            // txtBoxMx
            // 
            this.txtBoxMx.Location = new System.Drawing.Point(146, 3);
            this.txtBoxMx.Name = "txtBoxMx";
            this.txtBoxMx.Size = new System.Drawing.Size(100, 20);
            this.txtBoxMx.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(16, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = "Мат.ожидание:";
            // 
            // txtBoxDx
            // 
            this.txtBoxDx.Location = new System.Drawing.Point(146, 29);
            this.txtBoxDx.Name = "txtBoxDx";
            this.txtBoxDx.Size = new System.Drawing.Size(100, 20);
            this.txtBoxDx.TabIndex = 10;
            // 
            // txtBoxCm2
            // 
            this.txtBoxCm2.Location = new System.Drawing.Point(146, 55);
            this.txtBoxCm2.Name = "txtBoxCm2";
            this.txtBoxCm2.Size = new System.Drawing.Size(100, 20);
            this.txtBoxCm2.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lblSeriesHypotize);
            this.panel3.Controls.Add(this.txtBoxR);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.txtBoxRh);
            this.panel3.Controls.Add(this.txtBoxRb);
            this.panel3.Controls.Add(this.txtBoxPirson);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.txtBoxKolmogorov);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Location = new System.Drawing.Point(12, 378);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(640, 162);
            this.panel3.TabIndex = 9;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(263, 83);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(34, 18);
            this.label16.TabIndex = 7;
            this.label16.Text = "Rh:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(263, 19);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(34, 18);
            this.label15.TabIndex = 6;
            this.label15.Text = "Rb:";
            // 
            // txtBoxRh
            // 
            this.txtBoxRh.Location = new System.Drawing.Point(419, 81);
            this.txtBoxRh.Name = "txtBoxRh";
            this.txtBoxRh.ReadOnly = true;
            this.txtBoxRh.Size = new System.Drawing.Size(100, 20);
            this.txtBoxRh.TabIndex = 5;
            // 
            // txtBoxRb
            // 
            this.txtBoxRb.Location = new System.Drawing.Point(419, 16);
            this.txtBoxRb.Name = "txtBoxRb";
            this.txtBoxRb.ReadOnly = true;
            this.txtBoxRb.Size = new System.Drawing.Size(100, 20);
            this.txtBoxRb.TabIndex = 4;
            // 
            // txtBoxPirson
            // 
            this.txtBoxPirson.Location = new System.Drawing.Point(132, 17);
            this.txtBoxPirson.Name = "txtBoxPirson";
            this.txtBoxPirson.ReadOnly = true;
            this.txtBoxPirson.Size = new System.Drawing.Size(100, 20);
            this.txtBoxPirson.TabIndex = 3;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(12, 16);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 18);
            this.label14.TabIndex = 2;
            this.label14.Text = "Пирсон:";
            // 
            // txtBoxKolmogorov
            // 
            this.txtBoxKolmogorov.Location = new System.Drawing.Point(132, 52);
            this.txtBoxKolmogorov.Name = "txtBoxKolmogorov";
            this.txtBoxKolmogorov.ReadOnly = true;
            this.txtBoxKolmogorov.Size = new System.Drawing.Size(100, 20);
            this.txtBoxKolmogorov.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(12, 54);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(111, 18);
            this.label13.TabIndex = 0;
            this.label13.Text = "Колмогоров:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(266, 357);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 18);
            this.label12.TabIndex = 10;
            this.label12.Text = "Критерии";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(263, 51);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(25, 18);
            this.label17.TabIndex = 8;
            this.label17.Text = "R:";
            // 
            // txtBoxR
            // 
            this.txtBoxR.Location = new System.Drawing.Point(419, 49);
            this.txtBoxR.Name = "txtBoxR";
            this.txtBoxR.ReadOnly = true;
            this.txtBoxR.Size = new System.Drawing.Size(100, 20);
            this.txtBoxR.TabIndex = 9;
            // 
            // lblSeriesHypotize
            // 
            this.lblSeriesHypotize.AutoSize = true;
            this.lblSeriesHypotize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSeriesHypotize.Location = new System.Drawing.Point(263, 114);
            this.lblSeriesHypotize.Name = "lblSeriesHypotize";
            this.lblSeriesHypotize.Size = new System.Drawing.Size(0, 18);
            this.lblSeriesHypotize.TabIndex = 10;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 550);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.buttonCount);
            this.Name = "MainForm";
            this.Text = "Генератор случайных чисел";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUDSequencySize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUDSectionsNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeriUDSampleSize)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCount;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUDSequencySize;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUDSectionsNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numeriUDSampleSize;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtBoxCm3;
        private System.Windows.Forms.TextBox txtBoxMx;
        private System.Windows.Forms.TextBox txtBoxDx;
        private System.Windows.Forms.TextBox txtBoxCm2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtBoxKolmogorov;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtBoxPirson;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtBoxRh;
        private System.Windows.Forms.TextBox txtBoxRb;
        private System.Windows.Forms.TextBox txtBoxR;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblSeriesHypotize;
    }
}

