using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Point P1 = new Point(23, 34, 7);
            Point P2 = new Point(1, 5, -8);
            Point P3 = new Point(6, -5, 19);
            Point P4 = new Point(4, 0, -21);
            
            Vector vector1 = new Vector(P1, P2);
            Vector vector2 = new Vector(P3, P4);
            
            Vector vector_sum = vector1 + vector2;
            Vector vector_sub = vector1 - vector2;
            double multi_scal = vector1 * vector2;
            Vector multi_vect = vector1 | vector2;

            Console.WriteLine("Вектор 1:");
            vector1.ShowVector();
            Console.WriteLine("\nДлина вектора 1: " + vector1.GetLength());
            Console.WriteLine("\nВектор 2:");
            vector2.ShowVector();
            Console.WriteLine("\nДлина вектора 2: " + vector2.GetLength());
            
            Console.WriteLine("\nИскомый вектор после суммы веторов:");
            vector_sum.ShowVector();
            Console.WriteLine("\nИскомый вектор после разности веторов:");
            vector_sub.ShowVector();
            Console.WriteLine("\nСкалярное произведение веторов:");
            Console.WriteLine(multi_scal);
            Console.WriteLine("\nВекторное произведение веторов:");
            multi_vect.ShowVector();

            Console.ReadKey();
        }
    }
}
