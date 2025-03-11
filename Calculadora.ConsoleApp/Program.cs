namespace Calculadora.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int sessao = -1;
            string[] operacoes = new string[100];

            while (true)
            {
                sessao++;
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


                if (opcao == "S")
                {
                    break;
                }
                else if (opcao == "5")
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
                    continue;
                }
                else if (opcao == "6")
                {
                    foreach(var item in operacoes)
                    {
                        if (item is not null)
                            Console.WriteLine(item);
                    }
                    Console.ReadKey();
                    continue;
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
                    operacoes[sessao] = $"{primeiroNumero} + {segundoNumero} = {resultado}";
                }
                else if (opcao == "2")
                {
                    resultado = primeiroNumero - segundoNumero;
                    operacoes[sessao] = $"{primeiroNumero} - {segundoNumero} = {resultado}";
                }
                else if (opcao == "3")
                {
                    resultado = primeiroNumero * segundoNumero;
                    operacoes[sessao] = $"{primeiroNumero} * {segundoNumero} = {resultado}";
                }
                else if (opcao == "4")
                {
                    if (segundoNumero == 0)
                    {
                        Console.WriteLine("Não da de dividir número por 0 patrão(oa)... Aperte Enter para tentar novamente");
                        Console.ReadLine();
                        continue;
                    }
                    resultado = primeiroNumero / segundoNumero;
                    operacoes[sessao] = $"{primeiroNumero} / {segundoNumero} = {resultado}";
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
