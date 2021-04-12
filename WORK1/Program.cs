using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WORK1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.17 a
            Console.WriteLine("Введите число x1");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число x2");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Math.Sqrt(x1 * x1 + x2 * x2);
            Console.WriteLine("Ответ" + x1*x2);
            

            //1.17 b
            Console.WriteLine("Введите число a1");
            double a1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число a2");
            double a2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число a3");
            double a3 = Convert.ToDouble(Console.ReadLine());
            double a4 = (a1 * a2 + a1 * a3 + a2 * a3);
            Console.WriteLine("Ответ" + a4);
            

            //1.17 в
            Console.WriteLine("Введите число v0");
            double v0 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число t");
            double t = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число d");
            double d = Convert.ToDouble(Console.ReadLine());
            double d1 = v0 * t + (d * t / 2);
            Console.WriteLine("Ответ" + d1);
            

            //1.17 г
            Console.WriteLine("Введите число m");
            double m = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число v");
            double v = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число g");
            double g = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число h");
            double h = Convert.ToDouble(Console.ReadLine());
            double h1 = m * v + (g * h / 2);
            Console.WriteLine("Ответ" + h1);
            

            //1.17 д
            Console.WriteLine("Введите число r1");
            double r1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число r2");
            double r2 = Convert.ToDouble(Console.ReadLine());
            double r = 1 / r1 + 1 / r2;
            Console.WriteLine("Ответ" + r);
           

            //1.17 е
            Console.WriteLine("Введите число m2");
            double m2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число g1");
            double g1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число Cosa");
            double cosa = Convert.ToDouble(Console.ReadLine());
            double q2 = m2 * g1 * cosa;
            Console.WriteLine("Ответ" + 1234);
            Console.ReadKey();



































        }
    }
}
