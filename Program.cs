using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace homework3
{
    class Program

    {
        //Вычитание комплексных чисел ( задание 1(а))
        struct Complex
        {
            public double a, b;

            public override string ToString()
            {
                return $"{a} + {b}i";
            }
        }

        static Complex Sub(Complex x, Complex y)
        {
            Complex res;
            res.a = x.a - y.a;
            res.b = x.b - y.b;

            return res;

        }

        static void Main()
        {
            Complex s1;
            Console.WriteLine("enter first real part");
            s1.a = int.Parse(Console.ReadLine());
            Console.WriteLine("enter first imaginary part");
            s1.b = int.Parse(Console.ReadLine());
            Console.WriteLine($"first complex number is: {s1}");

            Complex s2;
            Console.WriteLine("enter second real part");
            s2.a = int.Parse(Console.ReadLine());
            Console.WriteLine("enter second imaginary part");
            s2.b = int.Parse(Console.ReadLine());
            Console.WriteLine($"second complex number is: {s2}");

            Complex s3 = Sub(s1, s2);
            Console.WriteLine($"result of the subtration is: {s3}");
            Console.ReadLine();

        }

    }
}
