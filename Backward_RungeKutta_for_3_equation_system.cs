using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numerical_Methods_lab3_part2
{
    public delegate double OneParamFunc(double x);
    public delegate double RightPart(double x, double y, double z, double w);

    public enum RungeKuttaError
    {
        ERR0,   //завершение в соответствии с назначенным условием о достижении заданной точности
        ERR1,   // процесс решения прекращен, т.к. с уменьшением шага погрешность не уменьшается
        ERR2,   //процесс решения прекращен, т.к. значение шага стало недопустимо малым 
        ERR3    //процесс решения прекращен, так как уменьшение шага было произведено более 20 раз
    }
    /// <summary>
    /// Метод Рунге-Кутта 4-ого порядка для приближенного решения задачи Коши для систем из 3 уравнений 
    /// с 3 начальными условиями, заданными в правом конце отрезка интегрирования (x=b)
    /// </summary>
    class BackwardRungeKutta
    {
        public RightPart[] F; //правая часть ОДУ, y'(x)=F
        public double a, b; //концы отрезка интегрирования
        public double[] y0;     //=y1(b) && y2(b) && y3(b)
        public int n0;          //начальное число отрезков интегрирования
        public int n_curr;      //число отрезков интегрирования на данном шаге
        public double h;        //текущий шаг
        public double eps0;     //заданное пользователем эпсилон
        public double[] eps_curr = new double[3];  //последнее полученное эпсилон
        public double[] x_arr0;
        public double[,] y_arr0;
        public double[] x_arr1;
        public double[,] y_arr1;
        public double[] x_arr2;
        public double[,] y_arr2;
        public int numOfCycles = 0; //число делений первоначального шага интегрирования
        public RungeKuttaError result;  // код результата работы метода
        public BackwardRungeKutta(RightPart[] f, double a_, double b_, double[] y0_, int n0_, double eps0_)
        {
            F = f;
            a = a_; b = b_; y0 = y0_; n0 = n0_; eps0 = eps0_;
            eps_curr[0] = eps_curr[1] = eps_curr[2] = 100000;
            result = RKsearch();
        }
        protected double FormNodes(int n)
        {
            n_curr = n;
            double hh = (b - a) / n;
            x_arr1 = x_arr2;
            y_arr1 = y_arr2;
            x_arr2 = new double[n + 1];
            y_arr2 = new double[3, n + 1];
            for (int i = 0; i <= n; i++)
                x_arr2[i] = a + hh * i;
            x_arr2[n] = b;
            y_arr2[0, n_curr] = y0[0];
            y_arr2[1, n_curr] = y0[1];
            y_arr2[2, n_curr] = y0[2];
            return hh;
        }
        protected void RKmethod()
        {
            for (int i = n_curr - 1; i >= 0; i--)
            {
                double x = x_arr2[i + 1];
                double[] y = {
                    this.y_arr2[0, i + 1],
                    this.y_arr2[1, i + 1],
                    this.y_arr2[2, i + 1]
                };
                double[] k1 = {
                    -h * F[0](x, y[0], y[1], y[2]),
                    -h * F[1](x, y[0], y[1], y[2]),
                    -h * F[2](x, y[0], y[1], y[2])
                };
                double x_h4 = x - 0.25 * h;
                double[] y_h__1 = {
                    y[0] + k1[0] * 0.25,
                    y[1] + k1[1] * 0.25,
                    y[2] + k1[2] * 0.25
                };
                double[] k2 = {
                    -h * F[0](x_h4, y_h__1[0], y_h__1[1], y_h__1[2]),
                    -h * F[1](x_h4, y_h__1[0], y_h__1[1], y_h__1[2]),
                    -h * F[2](x_h4, y_h__1[0], y_h__1[1], y_h__1[2])

                };
                double x_h2 = x - 0.5 * h;
                double[] y_h__2 = {
                    y[0] + k2[0] * 0.5,
                    y[1] + k2[1] * 0.5,
                    y[2] + k2[2] * 0.5

                };
                double[] k3 = {
                    -h * F[0](x_h2, y_h__2[0], y_h__2[1], y_h__2[2]),
                    -h * F[1](x_h2, y_h__2[0], y_h__2[1], y_h__2[2]),
                    -h * F[2](x_h2, y_h__2[0], y_h__2[1], y_h__2[2]),
                };
                double x_h = x - h;
                double[] y_h__3 = {
                    y[0] + k1[0] - 2 * k2[0] + k3[0],
                    y[1] + k1[1] - 2 * k2[1] + k3[1],
                    y[2] + k1[2] - 2 * k2[2] + k3[2],
                };
                double[] k4 = {
                    -h * F[0](x_h, y_h__3[0], y_h__3[1], y_h__3[2]),
                    -h * F[1](x_h, y_h__3[0], y_h__3[1], y_h__3[2]),
                    -h * F[2](x_h, y_h__3[0], y_h__3[1], y_h__3[2]),

                };
                for (int j = 0; j <= 2; j++)
                {
                    this.y_arr2[j, i] = y[j] + 1.0 / 6 * (k1[j] + 4 * k3[j] + k4[j]);
                }
            }
        }
        protected RungeKuttaError RKsearch()
        {
            RungeKuttaError err = RungeKuttaError.ERR0;
            h = FormNodes(n0);
            x_arr0 = x_arr2;
            RKmethod();
            y_arr0 = y_arr2;
            do
            {
                h = FormNodes(n_curr * 2);
                if (h + 1 == 1)
                {
                    err = RungeKuttaError.ERR2;
                }
                RKmethod();
                numOfCycles++;
                double eps1, eps2, eps3;
                Eps(out eps1, out eps2, out eps3);
                if (eps_curr[0] <= eps1 || eps_curr[1] <= eps2 || eps_curr[2] <= eps3)
                {
                    err = RungeKuttaError.ERR1;
                    break;
                }
                eps_curr[0] = eps1;
                eps_curr[1] = eps2;
                eps_curr[2] = eps3;
            }
            while ((eps_curr[0] > eps0 || eps_curr[1] > eps0 || eps_curr[2] > eps0) && numOfCycles <= 20);

            if ((eps_curr[0] > eps0 || eps_curr[1] > eps0 || eps_curr[2] > eps0) && numOfCycles > 20)
                err = RungeKuttaError.ERR3;
            return err;
        }
        protected void Eps(out double eps1, out double eps2, out double eps3)
        {
            eps1 = Math.Abs(y_arr1[0, 0] - y_arr2[0, 0]) / 3;
            eps2 = Math.Abs(y_arr1[1, 0] - y_arr2[1, 0]) / 3;
            eps3 = Math.Abs(y_arr1[2, 0] - y_arr2[2, 0]) / 3;

        }
    }
}

