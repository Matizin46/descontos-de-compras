using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desconto_compras
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double valorCompra = 0;
            int valorDesconto = 0;
            bool flag = false;

            try
            {

                while (!flag)
                {

                    //solicita o valor da compra
                    Console.WriteLine("Digite o valor da compra ou 'S' para sair");
                    string inputCompra = Console.ReadLine();

                    //Verifica se o usuario quer sair
                    if (inputCompra.ToUpper()== "S")
                    {
                        Console.WriteLine("Programa encerrado.");
                        return;
                    }

                    try
                    {

                        //converte o valor da compra para double
                        valorCompra = double.Parse(inputCompra);
                        flag = true;
                    }

                    catch (FormatException)
                    {
                        Console.WriteLine("Erro: Por favor, digite um valor numérico válido.");
                    }
                }
                //---------------------------------------------------------------------------------------------

                // Resetando a variável para outra entrada
                flag = false;
                //---------------------------------------------------------------------------------------------

                while (!flag)
                {

                    //Solicita a porcentagem do desconto
                    Console.WriteLine("Digite a porcentagem de desconto (0 a a 100) ou 'S' para sair: ");
                    String inputDesconto = Console.ReadLine();

                    //Verifica se o usuário quer sair 
                    if (inputDesconto.ToUpper() == "S")
                    {
                        Console.WriteLine("Programa encerrado.");
                        return;
                    }
                    try
                    {
                        // Converte a porcentagem de desconto para int
                        valorCompra = int.Parse(inputDesconto);

                        //Verifica se o desconto está entre 0 e 100
                        if(valorDesconto < 0 ||  valorDesconto > 100)
                        {
                            Console.WriteLine("Erro: Por favor digite um valor numérico valido.");
                            continue;
                        }

                        flag = true;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Erro: Por favor, digite um valor numérico válido.");
                    }


                }

                // Calcula o valor final com desconto
                double valorFinal = valorCompra - (valorCompra * (valorDesconto / 100.0));
                Console.WriteLine($"Valor final com desconto: {valorFinal:C}");
            }
            finally
            {
                Console.WriteLine("Operação concluída.");
                Console.ReadLine();
            }
        }
    }
}