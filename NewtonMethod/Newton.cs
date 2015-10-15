using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewtonMethod
{
    public class Newton
    {
        public static double Root(double Value, int n, double eps)
        {
            double xn, xo;
            xn = 0;
            xo = 1;
            double k = 1.0 / n;
            while (Math.Abs(xo - xn) > eps)
            {

                xn = k * ((n - 1) * xo + (Value / Pow(xo, n - 1)));
                xo = xn;
            }

            return xn;

        }
        static double Pow(double Value, int n)
        {
            if (n == 0) return 1;
            else
            {
                double numb = Value;
                for (int i = 0; i < n - 1; i++)
                {
                    numb = numb * Value;
                }
                return numb;
            }
        }
    }
}
