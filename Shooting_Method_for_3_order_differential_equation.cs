using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numerical_Methods_lab3_part2
{
    /// <summary>
    /// Реализация метода стрельбы (пристрелки) решения краевой задачи для ОДУ 3-ого порядка 
    /// u'''(x) = f(x, u(x), u'(x), u"(x));
    /// u'(a) = A; 
    /// u (b) = B;
    /// u'(b) = C;
    /// </summary>
    class ShootingMethod
    {
        /// <summary>
        /// Результат выполнения алгоритма метода стрельбы для краевой задачи второго порядка
        /// </summary>
        public enum ShootingMethodError
        {
            ERR0,   // нет ошибок
            ERR1,   // превышено число итераций
            ERR2  // ошибка входных данных
        }
        // входные параметры метода
        double
            a, b,   // начало и конец отрезка интегрирования
            eps,    // точность решения нелинейного уравнения phi(alpha)=0
            alpha0, alpha1, // начальные значения пристрелочных параметров
            A,      // константа краевого условия u'(a)=A
            B,      // константа краевого условия u(b)=B
            C;      // константа краевого условия u'(b)=C
        int
            N,      // начальное число отрезков интегрирования - входной параметр для метода Рунге-Кутта
            K;      // предельное число итераций в цикле поиска пристрелочного параметра alpha
        RightPart f;// функция f правой части исходного уравнения краевой задачи: u'''=f(x, u, u', u")


        public int N_output;    // количество отрезков разбиения, в результате решения
        public double[] X_ans { get; private set; } // узлы, к которых получено приближенное решение u(x)
        public double[] U_ans { get; private set; } // значения функции u(x) в узлах сетки X_ans[i]
        public ShootingMethodError ResultError { get; private set; }    // код результата выполнения метода стрельбы
        public int L { get; private set; }  // число выполненных итераций
        public double ResultAlpha { get; private set; }   // конечное значение пристрелочного параметра

        /// <summary>
        /// Единственный конструктор класса. Получает необходимые параметры, однозначно определяющие краевую задачу, 
        /// и вызывающий метод для решения данной задачи - метод пристрелки (стрельбы).
        /// 
        /// Решается нелинейное уравнение phi(alpha) = u'(a, alpha)-A.
        /// </summary>

        public ShootingMethod(RightPart f_, double a_, double b_, int N_, double eps_, int K_,
            double alpha0_, double alpha1_, double A_, double B_, double C_)
        {
            a = a_; b = b_; N = N_; eps = eps_; K = K_; alpha0 = alpha0_; alpha1 = alpha1_; A = A_; B = B_; C = C_;
            f = f_;
            RunMethod();
        }

        protected ShootingMethodError RunMethod()
        {
            ShootingMethodError result = ShootingMethodError.ERR0;

            double al0 = alpha0;    // предпоследнее полученное приближение значения параметра alpha
            double al1 = alpha1;    // последнее полученное приближение значения параметра alpha
            double F_u(double x, double u, double v, double w)
            {
                return v;
            }
            double F_v(double x, double u, double v, double w)
            {
                return w;
            }
            double F_w(double x, double u,double v, double w)
            {
                return f(x, u, v, w);
            }
            RightPart[] F = { F_u, F_v, F_w };
            double[] y0_RK0 = { B, C, al0}; // начальные условия для з.Коши с третьем нач. условием w(b)=al0
            double[] y0_RK1 = {B, C, al1 }; // начальные условия для з.Коши с третьем нач. условием w(b)=al1
            BackwardRungeKutta RK0 = new BackwardRungeKutta(F, a, b, y0_RK0, N, eps);   // подставляем 0е заданное приближение п-ра альфа в з. Коши
            BackwardRungeKutta RK1 = new BackwardRungeKutta(F, a, b, y0_RK1, N, eps);   // подставляем 1е заданное приближение п-ра альфа в з. Коши
            double
                    phi_al0 = RK0.y_arr2[0, 0] - A,
                    phi_al1 = RK1.y_arr2[0, 0] - A;
            double al2 = al1 - phi_al1 * (al1 - al0) / (phi_al1 - phi_al0); // метод секущих для вычисления след. приближения альфа
            double[] y0_RK2 = { B, C, al2 };
            BackwardRungeKutta RK2 = new BackwardRungeKutta(F, a, b, y0_RK2, N, eps);
            double phi = RK2.y_arr2[1, 0] - A;
            L++;    //одну итерацию метода стрельбы мы прошли вне основного цикла
            while (Math.Abs(phi) > eps && L < K)
            {
                L++;
                al0 = al1;
                al1 = al2;
                phi_al0 = phi_al1;
                phi_al1 = phi;
                al2 = al1 - phi_al1 * (al1 - al0) / (phi_al1 - phi_al0); // метод секущих для вычисления след. приближения альфа
                double[] y0 = { B, C, al2 };
                BackwardRungeKutta RK = new BackwardRungeKutta(F, a, b, y0, N, eps);
                phi = RK.y_arr2[1, 0] - A;
                if (phi <= eps || L >= K)
                {
                    N_output = RK.n_curr;
                    X_ans = new double[N_output];
                    U_ans = new double[N_output];
                    for (int i = 0; i < N_output; i++)
                    {
                        X_ans[i] = RK.x_arr2[i];
                        U_ans[i] = RK.y_arr2[0, i];
                    }
                }
            }
            if (phi > eps && L >= K)
                ResultError = ShootingMethodError.ERR1;
            if (L == 1)
            {
                N_output = RK2.n_curr;
                X_ans = new double[N_output];
                U_ans = new double[N_output];
                for (int i = 0; i < N_output; i++)
                {
                    X_ans[i] = RK2.x_arr2[i];
                    U_ans[i] = RK2.y_arr2[0, i];
                }
            }
            ResultAlpha = al2;
            return result;
        }
    }
}
