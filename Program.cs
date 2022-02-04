using System;
using System.Linq;

namespace Project_04_NumericalIntegration
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            double a, b;

            Console.WriteLine("Please write the coefficients of polynomial function:");
            input = Console.ReadLine();
            Polynomial polynom = new Polynomial(input);

            Console.WriteLine("The function you've entered:");
            Console.WriteLine(polynom.ToString());

            bool go = true;
            do
            {
                Console.WriteLine("Please write the boundaries of integration: ");
                do
                {
                    Console.Write("a = ");
                    go = !double.TryParse(Console.ReadLine(), out a);
                } while (go);

                do
                {
                    Console.Write("b = ");
                    go = !double.TryParse(Console.ReadLine(), out b);
                } while (go);
                if(a > b)
                {
                    Console.WriteLine("b must be greater than a");
                }
            } while (a > b); 
            Console.WriteLine("Integration by trapezoidal method: " + polynom.GetIntegralTrapeze(a, b, 100));
            Console.WriteLine("Integration by Simpson's method: " + polynom.GetIntegralSimpson(a, b, 100));
        }
    }
}
