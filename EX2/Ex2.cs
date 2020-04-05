using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX2
{
    class Program
    {
        static void Main(string[] args)
        {
            int Celsius;
            double Fahrenheit;

            Console.WriteLine("Digite a temperatura em Celsius");
            Celsius = Int32.Parse(Console.ReadLine());

            Fahrenheit = (9 * Celsius + 160) / 5;

            Console.WriteLine("A temperatura em Fahrenheit é: " + Fahrenheit);

            Console.ReadKey();
        }
    }
}
