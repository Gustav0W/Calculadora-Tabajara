﻿namespace Calculadora.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string opcao;

            while (true)
            {
                Console.Clear();

                Console.WriteLine("=================================");
                Console.WriteLine("    Calculadora Tabajara 2025    ");
                Console.WriteLine("=================================");

                Console.WriteLine("1- Somar");
                Console.WriteLine("2- Subtrair");
                Console.WriteLine("3- Multiplicar");
                Console.WriteLine("4- Divisão");
                Console.WriteLine("S- Sair");

                Console.Write("Resposta: ");
                opcao = Console.ReadLine().ToUpper();
                if (opcao == "S")
                {
                    break;
                }
                Console.Write("Digite o primeiro número: ");
                string primeiroNumeroString = Console.ReadLine();
                decimal primeiroNumero = Convert.ToDecimal(primeiroNumeroString);

                Console.Write("Digite o segundo número: ");
                string segundoNumeroString = Console.ReadLine();
                decimal segundoNumero = Convert.ToDecimal(segundoNumeroString);

                decimal resultado = 0;

                if (opcao == "1")
                {
                    resultado = primeiroNumero + segundoNumero;
                }
                else if (opcao == "2")
                {
                    resultado = primeiroNumero - segundoNumero;
                }
                else if (opcao == "3")
                {
                    resultado = primeiroNumero * segundoNumero;
                }
                else if (opcao == "4")
                {
                    resultado = primeiroNumero / segundoNumero;
                }
                    Console.WriteLine("==========================");
                Console.WriteLine("Resultado: " + resultado.ToString("F2"));
                Console.WriteLine("==========================");
                Console.Write("Deseja continuar ?(S/N): ");
                string opcaoContinuar = Console.ReadLine().ToUpper();
                
                if (opcaoContinuar != "S")
                {
                    break;
                }

            }
        }
    }
}
