using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX3
{
    class Program
    {
        static void Main(string[] args)
        {
            int menu;
            double ValorProduto;
            double Desconto;
            double ValorTotal;

            Console.WriteLine("Digite o valor do produto");
            ValorProduto = double.Parse(Console.ReadLine());
                        
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("----------                                Indique a Condição Escolhida                                           ---------");
            Console.WriteLine("----------                                                                                                       ---------");
            Console.WriteLine("----------             Condição                       |                  Desconto                   |            ---------");
            Console.WriteLine("----------    À Vista (Cartão de crédito)             |                    10%                      |     [1]    ---------");
            Console.WriteLine("----------    À Vista (Dinheiro ou Cheque)            |                    5%                       |     [2]    ---------");
            Console.WriteLine("----------    Parcelado (2 Vezes)                     |           Valor Normal Sem Juros            |     [3]    ---------");
            Console.WriteLine("----------    Parcelado (3 Vezes ou Mais)             |        Valor Produto + 10% de Juros         |     [4]    ---------");
            Console.WriteLine("----------                                                                                                       ---------");
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------");
            menu = Int32.Parse(Console.ReadLine());

            switch (menu)
            {
                case 1:
                    ValorTotal = ValorProduto -(ValorProduto * 10 / 100);
                    Console.WriteLine("Valor total do produto é: " + ValorTotal);
                    break;

                case 2:
                    ValorTotal = ValorProduto - (ValorProduto * 5 / 100);
                    Console.WriteLine("Valor total do produto é: " + ValorTotal);
                    break;

                case 3:
                    ValorTotal = ValorProduto;
                    Console.WriteLine("Valor total do produto é: " + ValorTotal);
                    break;

                case 4:
                    ValorTotal = (ValorProduto * 10 / 100) + ValorProduto;
                    Console.WriteLine("Valor total do produto é: " + ValorTotal);
                    break;
            }
            Console.ReadKey();              
        }
    }
}
