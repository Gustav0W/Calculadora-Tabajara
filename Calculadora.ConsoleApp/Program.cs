﻿namespace Calculadora.ConsoleApp
{
    internal class Program
    {
        static int contadorHistorico = 0;
        static string[] historicoOperacoes = new string[100];
        static void Main(string[] args)
        {
            while (true)
            {
                string opcao = ExibirMenu();

                if (OpcaoSairEscolhida(opcao) == true)
                    break;

                else if (OpcaoTabuadaFoiEscolhida(opcao))
                    ExibirTabuada();

                else if (OpcaoHistoricoFoiEscolhida(opcao))
                    ExibirHistoricoOperacoes();

                else
                {
                    ExibirResultado(RealizarCalculo(opcao));
                }
            }
        }

        //Função/Método 
        static string ExibirMenu()
        {
            Console.Clear();

            Console.WriteLine("=================================");
            Console.WriteLine("    Calculadora Tabajara 2025    ");
            Console.WriteLine("=================================");

            Console.WriteLine("1- Somar");
            Console.WriteLine("2- Subtrair");
            Console.WriteLine("3- Multiplicar");
            Console.WriteLine("4- Divisão");
            Console.WriteLine("5- Tabuada");
            Console.WriteLine("6- Histórico");
            Console.WriteLine("S- Sair");

            Console.Write("Resposta: ");

            string opcao = Console.ReadLine().ToUpper();

            return opcao;
        }

        static bool OpcaoSairEscolhida(string opcao) 
        {
            bool opcaoSairFoiEscolhida = opcao == "S";

            return opcaoSairFoiEscolhida;
        }

        static bool OpcaoTabuadaFoiEscolhida(string opcao)
        {
           bool opcaoTabuadaFoiEscolhida = opcao == "S";

            return opcaoTabuadaFoiEscolhida;
        }

        static bool OpcaoHistoricoFoiEscolhida(string opcao)
        {
            bool opcaoHistoricoFoiEscolhida = opcao == "6";

            return opcaoHistoricoFoiEscolhida;
        }

        static void ExibirHistoricoOperacoes()
        {
            Console.WriteLine("================================");
            Console.WriteLine("     Histórico de operações     ");
            Console.WriteLine("================================");

            for (int contador = 0; contador < historicoOperacoes.Length; contador++)
            {
                string valorAtual = historicoOperacoes[contador];

                if (valorAtual != null)
                    Console.WriteLine(valorAtual);

                Console.WriteLine("============================");
                Console.WriteLine("Aperte ENTER para continuar");
                Console.ReadLine();
            }
        }
        static void ExibirTabuada()
        {
            Console.WriteLine("==========================");
            Console.WriteLine("          TABUADA         ");
            Console.WriteLine("==========================");


            Console.Write("Digite um número: ");
            int numeroTabuada = Convert.ToInt32(Console.ReadLine());

            for (int contador = 1; contador <= 10; contador++)
            {
                int resultadoTabuada = numeroTabuada * contador;

                Console.WriteLine($"{numeroTabuada} x {contador} = {resultadoTabuada}");

            }
            Console.ReadKey();
        }

        static decimal RealizarCalculo(string operacao)
        {
            Console.Write("Digite o primeiro número: ");
            decimal primeiroNumero = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            decimal segundoNumero = Convert.ToDecimal(Console.ReadLine());

            decimal resultado = 0;
            if (operacao == "1")
            {
                resultado = primeiroNumero + segundoNumero;
                historicoOperacoes[contadorHistorico] = $"{primeiroNumero} + {segundoNumero} = {resultado}";
            }
            else if (operacao == "2")
            {
                resultado = primeiroNumero - segundoNumero;
                historicoOperacoes[contadorHistorico] = $"{primeiroNumero} - {segundoNumero} = {resultado}";
            }
            else if (operacao == "3")
            {
                resultado = primeiroNumero * segundoNumero;
                historicoOperacoes[contadorHistorico] = $"{primeiroNumero} * {segundoNumero} = {resultado}";
            }
            else if (operacao == "4")
            {
                if (segundoNumero == 0)
                {
                    Console.WriteLine("Não da de dividir número por 0 patrão(oa)... Aperte Enter para tentar novamente");
                    Console.ReadLine();
                }
                resultado = primeiroNumero / segundoNumero;
                historicoOperacoes[contadorHistorico] = $"{primeiroNumero} / {segundoNumero} = {resultado}";
            }

            contadorHistorico++;
            return resultado;
        }

        static void ExibirResultado(decimal resultado)
        {
            Console.WriteLine("==========================");
            Console.WriteLine("Resultado: " + resultado.ToString("F2"));
            Console.WriteLine("==========================");

            Console.ReadLine();
        }

    }
}
