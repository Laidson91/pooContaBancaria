using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace pooContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaEstudante conta = new ContaEstudante();
            conta.Correntista.Nome = "Laidson Saturnino";
            int menu = 0;
            while(menu != 4)
            {
                Console.WriteLine("Menu de opções");
                Console.WriteLine("1 - Exibir dados do correntista");
                Console.WriteLine("2 - Retirada");
                Console.WriteLine("3 - Depositar");
                Console.Write("Opção: ");
                menu = Convert.ToInt32(Console.ReadLine());
                if (menu == 1)
                {
                    conta.ExibirDadosBancarios();
                }
                if (menu == 2)
                {
                    try
                    {
                        Console.Write("Valor para retirada: ");
                        Double valor = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Saldo restante: " + conta.Retirar(valor));
                    }
                    catch (Exception erro)
                    {
                        Console.WriteLine("Ops!!!! Algo deu errado.");
                        Console.WriteLine("Error: " + erro.Message);
                    }
                }
                if (menu == 3)
                {
                    try
                    {
                        Console.Write("valor para deposito: ");
                        Double valor = Convert.ToDouble(Console.ReadLine());
                        conta.Depositar(valor);
                        Console.WriteLine("Saldo atual: " + conta.Saldo);
                    }
                    catch (Exception erro)
                    {
                        Console.WriteLine("Ops!!!!! Algo deu errado.");
                        Console.WriteLine("Error: " + erro.Message);
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
