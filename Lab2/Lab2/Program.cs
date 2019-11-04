using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {

            string A;
            string B;
            int a;
            int b;



            Console.WriteLine("Enter first integer");
            A = Console.ReadLine();
            a = Convert.ToInt32(A);
            Console.WriteLine("Enter second integer");
            B = Console.ReadLine();
            b = Convert.ToInt32(B);


            Console.WriteLine(a + "x" + b + "=" + a * b);
            Console.ReadLine();

        }
    }
}