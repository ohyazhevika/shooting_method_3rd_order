using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Numerical_Methods_lab3_part2
{
    public partial class Form1 : Form
    {
        double
            a, b,
            eps,
            alpha0,
            alpha1,
            A,
            B,
            C;
        int
            N,
            K;
        double F_x_y_dy1(double x, double y, double dy, double dy2)
        {
            return 9 * y / Math.Pow(x, 3) + dy / Math.Pow(x, 2) - dy2 / x;
        }
        double Y1(double x)
        {
            return Math.Pow(x, 3);
        }
        
        public Form1()
        {
            InitializeComponent();
            textBox_err.Enabled = false;
            textBox_L.Enabled = false;
            textBox_alpha.Enabled = false;
        }

        private void построитьГрафикиToolStripMenuItem_Click(object sender, EventArgs e)

        {
            if (textBox_a.Text == "" || textBox_b.Text == "" || textBox_eps.Text == "" || textBox_alpha0.Text == "" || textBox_alpha1.Text == "" ||
                textBox_uA.Text == "" || textBox_uB.Text == "" || textBox_uC.Text == "" || textBox_N.Text == "" || textBox_K.Text == "")
            {
                MessageBox.Show("Заполните все поля для входных параметров!", "Внимание!");
                return;
            }
            a = Convert.ToDouble(textBox_a.Text);
            b = Convert.ToDouble(textBox_b.Text);
            eps = Convert.ToDouble(textBox_eps.Text);
            alpha0 = Convert.ToDouble(textBox_alpha0.Text);
            alpha1 = Convert.ToDouble(textBox_alpha1.Text);
            A = Convert.ToDouble(textBox_uA.Text);
            B = Convert.ToDouble(textBox_uB.Text);
            C = Convert.ToDouble(textBox_uC.Text);
            N = Convert.ToInt32(textBox_N.Text);
            K = Convert.ToInt32(textBox_K.Text);
            ShootingMethod SM = new ShootingMethod(F_x_y_dy1, a, b, N, eps, K, alpha0, alpha1, A, B, C);
            ClearSeries();
            ClearOutputTextBoxes();

            for (int i = 0; i < SM.N_output; i++)
            {
                double x = SM.X_ans[i];
                this.chart1.Series[1].Points.AddXY(x, SM.U_ans[i]);
                this.chart1.Series[0].Points.AddXY(x, Y1(x));
            }
            textBox_err.Text = Convert.ToString(SM.ResultError);
            textBox_alpha.Text = Convert.ToString(SM.ResultAlpha);
            textBox_L.Text = Convert.ToString(SM.L);
        }

        private void очиститьГрафикиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearSeries();
            ClearOutputTextBoxes();
        }
        private void ClearSeries()
        {
            for (int i = 0; i < 2; i++)
                this.chart1.Series[i].Points.Clear();
        }
        private void ClearOutputTextBoxes()
        {
            textBox_err.Text = "";
            textBox_L.Text = "";
            textBox_alpha.Text = "";
        }
    }
}
