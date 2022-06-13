using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_2
{
    public class Polynomial
    {
        private readonly double[] _coefficients;

        //  Создание полинома на основе коэффициентов
        public Polynomial(params double[] coefficients)
        {
            _coefficients = coefficients;
        }
        //  Получение или установка значения коэффициента*полинома
        public double this[int n]
        {
            get { return _coefficients[n]; }
            set { _coefficients[n] = value; }
        }
        //  Степень полинома
        public int Order
        {
            get { return _coefficients.Length; }
        }

        // расчет значения полинома по схеме Горнера.
        public double Calculate(double x)
        {
            int n = _coefficients.Length - 1;
            double result = _coefficients[n];
            for (int i = n - 1; i >= 0; i--)
            {
                result = x * result + _coefficients[i];
            }
            return result;
        }
        //  Сложение полиномов
        public static Polynomial operator +(Polynomial pFirst, Polynomial pSecond)
        {
            int itemsCount = Math.Max(pFirst._coefficients.Length, pSecond._coefficients.Length);
            var result = new double[itemsCount];
            for (int i = 0; i < itemsCount; i++)
            {
                double a = 0;
                double b = 0;
                if (i < pFirst._coefficients.Length)
                {
                    a = pFirst[i];
                }
                if (i < pSecond._coefficients.Length)
                {
                    b = pSecond[i];
                }
                result[i] = a + b;
            }
            return new Polynomial(result);
        }
        //  Вычитание полиномов
        public static Polynomial operator -(Polynomial pFirst, Polynomial pSecond)
        {
            int itemsCount = Math.Max(pFirst._coefficients.Length, pSecond._coefficients.Length);
            var result = new double[itemsCount];
            for (int i = 0; i < itemsCount; i++)
            {
                double a = 0;
                double b = 0;
                if (i < pFirst._coefficients.Length)
                {
                    a = pFirst[i];
                }
                if (i < pSecond._coefficients.Length)
                {
                    b = pSecond[i];
                }
                result[i] = a - b;
            }
            return new Polynomial(result);
        }
        //  Умножение полиномов
        public static Polynomial operator *(Polynomial pFirst, Polynomial pSecond)
        {
            int itemsCount = pFirst._coefficients.Length + pSecond._coefficients.Length - 1;
            var result = new double[itemsCount];
            for (int i = 0; i < pFirst._coefficients.Length; i++)
            {
                for (int j = 0; j < pSecond._coefficients.Length; j++)
                {
                    result[i + j] += pFirst[i] * pSecond[j];
                }
            }

            return new Polynomial(result);
        }
        
        //  Вывод на экран многочлена
        public void PrintPolynomial()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < this._coefficients.Length; i++)
            {   if (this[i] != 0)
                {
                    if (i == 0)
                    {
                        sb.Append(this[i]);
                    }
                    else
                    {
                        if (this[i] > 0)
                        {
                            sb.Append("+" + this[i] + "*x^" + i);
                        }
                        else
                        {
                            sb.Append(this[i] + "*x^" + i);
                        }
                    }
                }
            }
            Console.WriteLine(sb);
        }
    }
}
