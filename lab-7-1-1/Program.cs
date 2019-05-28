using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog_4s_l7_1_1
{
    public interface IMeasurable
    {
        double Perimeter();
        double Area();
    }
    public interface ICircumcircleIncircle
    {
        double R { get; } // радіус описаного кола
        double r { get; } // радіус вписаного кола
    }
    class Square : IMeasurable, IComparable
    {
        int a;
        public Square(int a) { this.a = a; }
        public double Perimeter()
        {
            return a * 4;
        }
        public double Area()
        {
            return a * a;
        }
        public int CompareTo(object obj)
        {
            Square p = obj as Square;
            if (this.Perimeter() > p.Perimeter()) return 0;
            else return 1;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Square[] x = new Square[2];
            x[0] = new Square(15);
            x[1] = new Square(25);

            Console.WriteLine("Vidpovid: Pry a = 15, perimeter = {0}, area = {1}", x[0].Perimeter(), x[0].Area());
            Array.Sort(x);
            foreach (Square i in x) Console.WriteLine(" фігура має периметр в {1:f2} од ", i, i.Perimeter());
        }
    }
}
