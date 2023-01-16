
namespace Numerical_Methods_lab3_part2
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.построитьГрафикиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьГрафикиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox_uB = new System.Windows.Forms.TextBox();
            this.textBox_uA = new System.Windows.Forms.TextBox();
            this.textBox_alpha1 = new System.Windows.Forms.TextBox();
            this.textBox_alpha0 = new System.Windows.Forms.TextBox();
            this.textBox_K = new System.Windows.Forms.TextBox();
            this.textBox_eps = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_N = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_b = new System.Windows.Forms.TextBox();
            this.textBox_a = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_uC = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox_alpha = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox_L = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox_err = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1534, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.построитьГрафикиToolStripMenuItem,
            this.очиститьГрафикиToolStripMenuItem});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // построитьГрафикиToolStripMenuItem
            // 
            this.построитьГрафикиToolStripMenuItem.Name = "построитьГрафикиToolStripMenuItem";
            this.построитьГрафикиToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.построитьГрафикиToolStripMenuItem.Text = "Построить графики";
            this.построитьГрафикиToolStripMenuItem.Click += new System.EventHandler(this.построитьГрафикиToolStripMenuItem_Click);
            // 
            // очиститьГрафикиToolStripMenuItem
            // 
            this.очиститьГрафикиToolStripMenuItem.Name = "очиститьГрафикиToolStripMenuItem";
            this.очиститьГрафикиToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.очиститьГрафикиToolStripMenuItem.Text = "Очистить графики";
            this.очиститьГрафикиToolStripMenuItem.Click += new System.EventHandler(this.очиститьГрафикиToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chart1);
            this.groupBox1.Location = new System.Drawing.Point(12, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1053, 685);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Графики";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Name = "Legend1";
            legend1.Title = "Цвета графиков";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(6, 22);
            this.chart1.Name = "chart1";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.Blue;
            series1.Legend = "Legend1";
            series1.LegendText = "точное решение";
            series1.Name = "Series1";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = System.Drawing.Color.Fuchsia;
            series2.Legend = "Legend1";
            series2.LegendText = "приближенное решение, полученное методом пристрелки";
            series2.Name = "Series2";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(1041, 657);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox_uC);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.textBox_uB);
            this.groupBox2.Controls.Add(this.textBox_uA);
            this.groupBox2.Controls.Add(this.textBox_alpha1);
            this.groupBox2.Controls.Add(this.textBox_alpha0);
            this.groupBox2.Controls.Add(this.textBox_K);
            this.groupBox2.Controls.Add(this.textBox_eps);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBox_N);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBox_b);
            this.groupBox2.Controls.Add(this.textBox_a);
            this.groupBox2.Location = new System.Drawing.Point(1071, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(455, 445);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Входные данные";
            // 
            // textBox_uB
            // 
            this.textBox_uB.Location = new System.Drawing.Point(99, 350);
            this.textBox_uB.Name = "textBox_uB";
            this.textBox_uB.Size = new System.Drawing.Size(100, 22);
            this.textBox_uB.TabIndex = 17;
            // 
            // textBox_uA
            // 
            this.textBox_uA.Location = new System.Drawing.Point(99, 309);
            this.textBox_uA.Name = "textBox_uA";
            this.textBox_uA.Size = new System.Drawing.Size(100, 22);
            this.textBox_uA.TabIndex = 16;
            // 
            // textBox_alpha1
            // 
            this.textBox_alpha1.Location = new System.Drawing.Point(99, 266);
            this.textBox_alpha1.Name = "textBox_alpha1";
            this.textBox_alpha1.Size = new System.Drawing.Size(100, 22);
            this.textBox_alpha1.TabIndex = 15;
            // 
            // textBox_alpha0
            // 
            this.textBox_alpha0.Location = new System.Drawing.Point(99, 224);
            this.textBox_alpha0.Name = "textBox_alpha0";
            this.textBox_alpha0.Size = new System.Drawing.Size(100, 22);
            this.textBox_alpha0.TabIndex = 14;
            // 
            // textBox_K
            // 
            this.textBox_K.Location = new System.Drawing.Point(170, 183);
            this.textBox_K.Name = "textBox_K";
            this.textBox_K.Size = new System.Drawing.Size(100, 22);
            this.textBox_K.TabIndex = 13;
            // 
            // textBox_eps
            // 
            this.textBox_eps.Location = new System.Drawing.Point(318, 145);
            this.textBox_eps.Name = "textBox_eps";
            this.textBox_eps.Size = new System.Drawing.Size(100, 22);
            this.textBox_eps.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 353);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 17);
            this.label9.TabIndex = 11;
            this.label9.Text = "u(b) = B =";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 309);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 17);
            this.label8.TabIndex = 10;
            this.label8.Text = "u\'(a) = A =";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 266);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "alpha1 =";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "alpha0 =";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "max число итераций =";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(302, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "eps (точность решения нелин. уравнения) =";
            // 
            // textBox_N
            // 
            this.textBox_N.Location = new System.Drawing.Point(237, 103);
            this.textBox_N.Name = "textBox_N";
            this.textBox_N.Size = new System.Drawing.Size(100, 22);
            this.textBox_N.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(222, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "N (число отрезков разбиения) =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "b = ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "a = ";
            // 
            // textBox_b
            // 
            this.textBox_b.Location = new System.Drawing.Point(69, 60);
            this.textBox_b.Name = "textBox_b";
            this.textBox_b.Size = new System.Drawing.Size(100, 22);
            this.textBox_b.TabIndex = 1;
            // 
            // textBox_a
            // 
            this.textBox_a.Location = new System.Drawing.Point(69, 26);
            this.textBox_a.Name = "textBox_a";
            this.textBox_a.Size = new System.Drawing.Size(100, 22);
            this.textBox_a.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 396);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 17);
            this.label10.TabIndex = 18;
            this.label10.Text = "u\'(b) = C =";
            // 
            // textBox_uC
            // 
            this.textBox_uC.Location = new System.Drawing.Point(99, 391);
            this.textBox_uC.Name = "textBox_uC";
            this.textBox_uC.Size = new System.Drawing.Size(100, 22);
            this.textBox_uC.TabIndex = 19;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox_alpha);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.textBox_L);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.textBox_err);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Location = new System.Drawing.Point(1072, 483);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(454, 234);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Выходные данные";
            // 
            // textBox_alpha
            // 
            this.textBox_alpha.Location = new System.Drawing.Point(98, 122);
            this.textBox_alpha.Name = "textBox_alpha";
            this.textBox_alpha.Size = new System.Drawing.Size(100, 22);
            this.textBox_alpha.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(11, 122);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 17);
            this.label12.TabIndex = 4;
            this.label12.Text = "alpha:";
            // 
            // textBox_L
            // 
            this.textBox_L.Location = new System.Drawing.Point(169, 74);
            this.textBox_L.Name = "textBox_L";
            this.textBox_L.Size = new System.Drawing.Size(100, 22);
            this.textBox_L.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 74);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(140, 17);
            this.label11.TabIndex = 2;
            this.label11.Text = "L (число итераций):";
            // 
            // textBox_err
            // 
            this.textBox_err.Location = new System.Drawing.Point(169, 30);
            this.textBox_err.Name = "textBox_err";
            this.textBox_err.Size = new System.Drawing.Size(100, 22);
            this.textBox_err.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(11, 33);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(122, 17);
            this.label13.TabIndex = 0;
            this.label13.Text = "Код завершения:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1534, 743);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Решение краевой задачи для ОДУ 3-ого порядка методом пристрелки";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem построитьГрафикиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очиститьГрафикиToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox_uC;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_uB;
        private System.Windows.Forms.TextBox textBox_uA;
        private System.Windows.Forms.TextBox textBox_alpha1;
        private System.Windows.Forms.TextBox textBox_alpha0;
        private System.Windows.Forms.TextBox textBox_K;
        private System.Windows.Forms.TextBox textBox_eps;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_N;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_b;
        private System.Windows.Forms.TextBox textBox_a;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox_alpha;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox_L;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox_err;
        private System.Windows.Forms.Label label13;
    }
}

