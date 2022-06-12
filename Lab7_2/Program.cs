using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Polynomial p1 = new Polynomial(1, 2, 3);
            Polynomial p2 = new Polynomial(10, 20, 0, 40);
            Polynomial sum = new Polynomial();
            Polynomial sub = new Polynomial();
            Polynomial multi = new Polynomial();

            Console.WriteLine("Многочлен 1:");
            p1.PrintPolynomial();
            Console.WriteLine("Многочлен 2:");
            p2.PrintPolynomial();
            Console.WriteLine();

            sum = p1 + p2;
            Console.WriteLine("Сумма:");
            sum.PrintPolynomial();
            sub = p1 - p2;
            Console.WriteLine("Разность:");
            sub.PrintPolynomial();
            Console.WriteLine("Произведение:");
            multi = p1 * p2;
            multi.PrintPolynomial();
            Console.WriteLine();

            Console.WriteLine("Введите чему равен x:");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Результат многочлена 1 при x = " + x);
            Console.WriteLine(p1.Calculate(x));
            Console.WriteLine("Результат многочлена 2 при x = " + x);
            Console.WriteLine(p2.Calculate(x));
            Console.ReadLine();
        }
    }
}
