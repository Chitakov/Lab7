using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_1
{
    public class Vector
    {
        public Point P1 { set; get; }
        public Point P2 { set; get; }
        public double X { set; get; }
        public double Y { set; get; }
        public double Z { set; get; }

        // конструктор без параметров 
        private Vector() { }
        //констркутор с помощью 2 точек
        public Vector(Point a, Point b)
        {
            P1 = a;
            P2 = b;
            X = b.x - a.x;
            Y = b.y - a.y;
            Z = b.z - a.z;
        }
        //констркутор с помощью 3 координат
        public Vector(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        //длина вектора
        public double GetLength()
        {
            return Math.Sqrt(X * X + Y * Y + Z * Z);
        }

        //операция сложения
        public static Vector operator +(Vector l, Vector r)
        {
            return new Vector(l.X + r.X, l.Y + r.Y, l.Z + r.Z);
        }

        //вычитание векторов
        public static Vector operator -(Vector l, Vector r)
        {
            return new Vector(l.X - r.X, l.Y - r.Y, l.Z - r.Z);
        }

        //вычисление скалярного произведения двух векторов
        public static double operator *(Vector l, Vector r)
        {
            return (l.X * r.X + l.Y * r.Y + l.Z * r.Z);
        }
        //вычисление векторного произведения двух векторов
        public static Vector operator |(Vector l, Vector r)
        {
            return new Vector(l.Y * r.Z - l.Z * r.Y, l.Z * r.X - l.X * r.Z, l.X * r.Y - l.Y * r.X);
        }

        // вывод координат вектора
        public void ShowVector()
        {
            Console.WriteLine("(x; y; z) = ({0}; {1}; {2});", X, Y, Z);
        }
        public override string ToString()
        {
            return string.Format("({0}; {1}; {2})", X, Y, Z);
        }
    }
}
