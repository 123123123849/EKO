using System;

namespace set
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            Console.WriteLine("Введите длины сторон треугольника ");
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());

            Class1 Tr = new Class1(a, b);
            Console.WriteLine("Площадь : " +Tr.met());
            Console.ReadKey();
        }
    }
}
