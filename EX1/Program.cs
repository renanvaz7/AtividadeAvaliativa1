using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX1
{
    class Program
    {
        static void Main(string[] args)
        {
            int Idade = 1;
            string Sexo;
            string Nome;
            int TotalPessoasMasculino = 0;
            int TotalPessoasFeminino = 0;
            int QtdServicoMilitar = 0;

            while (Idade > 0)
            {
                Console.WriteLine("Digite a idade");
                Idade = Int32.Parse(Console.ReadLine());

                if (Idade >= 0)
                {
                    break;
                }
                Console.WriteLine("Digite um nome");
                Nome = Console.ReadLine();

                Console.WriteLine("Digite o sexo\n" +
                    "[0] - Masculino    [1] - Feminino");
                Sexo = Console.ReadLine();                

                if (Sexo.Equals(0))
                {
                    TotalPessoasMasculino = TotalPessoasMasculino + 1;
                }
                else
                {
                    TotalPessoasFeminino = TotalPessoasFeminino + 1;
                }

                if (Idade > 17)
                {
                    QtdServicoMilitar = QtdServicoMilitar + 1;
                }
            }
            Console.WriteLine("O número de Homens é: " + TotalPessoasMasculino);
            Console.WriteLine("O número de Mulheres é: " + TotalPessoasFeminino);
            Console.WriteLine("O número de pessoas que podem prestar serviço militar obrigatório é: " + QtdServicoMilitar);

            Console.ReadKey();
        }
    }
}
