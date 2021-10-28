using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculation;

namespace ConsoleAppCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            tutu:
            Console.WriteLine("Unesite prvi broj: ");
            double a;
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Unesite drugi broj: ");
            double b;
            b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Odaberite opciju: ");
            Console.WriteLine("1.  Zbrajanje");
            Console.WriteLine("2.  Mnoezenje");
            Console.WriteLine("3.  Oduzimanje");
            Console.WriteLine("4.  Dijeljenje");
            Console.WriteLine("5. Izlaz");
            Calculator Calculator = new Calculator();
            int i;
            i = Convert.ToInt32(Console.ReadLine());
            switch(i)
            {
                case 1:
                    double c = Calculator.Add(a, b);
                    Console.WriteLine("Rjesenje je: " + c);
                    break;


                case 2:
                    double c2 = Calculator.Multiply(a, b);
                    Console.WriteLine("Rjesenje je: " + c2);
                    break;

                case 3:
                    double c3 = Calculator.Substract(a, b);
                    Console.WriteLine("Rjesenje je: " + c3);
                    break;

                case 4:
                    double c4 = Calculator.Divide(a, b);
                    Console.WriteLine("Rjesenje je: " + c4);
                    break;

                default:
                    break;
            }

            Console.ReadLine();
        }
    }
}
