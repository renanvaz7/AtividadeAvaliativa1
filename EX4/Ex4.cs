using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace EX4
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList Divisores = new ArrayList();
            int entrada;
            int i;            

            Console.WriteLine("Entre com um valor");
            entrada = Int32.Parse(Console.ReadLine());

            Console.Clear();

            for (i = 1; i <= entrada; i++)
            {
                if (entrada % i == 0)
                {
                    Divisores.Add(i);                    
                }
            }
            foreach (Object obj in Divisores)
            {
                Console.WriteLine("{0} ", obj);
            }
            Console.ReadKey();
        }
    }
}
