using System;

namespace oop_7_cs
{
    class Expression
    {
        private double a, c, d;
        private double result;
        public Expression()
        {
            a = 2;
            c = 2;
            d = 2;
        }
        public Expression(double a, double c, double d)
        {
            if (a == 1 || a == -1)
                throw new Exception("Помилка. Дiлення на нуль");
            if (d <= 0)
                throw new Exception("Помилка. Значення пiдлогарифмiчного виразу менше чи дорiвнює нулю");
            this.a = a;
            this.c = c;
            this.d = d;
        }

        public void Set_a(double a)
        {
            if (a == 1 || a == -1)
                throw new Exception("Помилка. Дiлення на нуль");
            this.a = a;
        }
        public void Set_c(double c)
        {
            this.c = c;
        }
        public void Set_d(double d)
        {
            if (d <= 0)
                throw new Exception("Помилка. Значення пiдлогарифмiчного виразу менше чи дорiвнює нулю");
            this.d = d;
        }

        private void Calculate()
        {
            result = (2 * c - Math.Log(d / 4)) / (a * a - 1);
        }

        public double GetResult()
        {
            Calculate();
            return result;
        }
    }
}
