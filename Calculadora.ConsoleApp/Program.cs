namespace Calculadora.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int primeiroNumero;
            int segundoNumero;
            string opcao;

            while (true)
            {
                Console.Clear();

                Console.WriteLine("=================================");
                Console.WriteLine("    Calculadora Tabajara 2025    ");
                Console.WriteLine("=================================");

                Console.WriteLine("1- Somar");
                Console.WriteLine("2- Subtrair");
                Console.WriteLine("S- Sair");

                Console.Write("Resposta: ");
                opcao = Console.ReadLine();
                string opcaoValidada = opcao.ToUpper();

                if (opcaoValidada == "S")
                {
                    break;
                }
                Console.Write("Digite o primeiro número: ");
                primeiroNumero = Convert.ToInt32(Console.ReadLine());

                Console.Write("Digite o segundo número: ");
                segundoNumero = Convert.ToInt32(Console.ReadLine());

                int resultado = 0;

                if (opcao == "1")
                {
                    resultado = primeiroNumero + segundoNumero;
                }
                else if (opcao == "2")
                {
                    resultado = primeiroNumero - segundoNumero;
                }
                    Console.WriteLine("==========================");
                Console.WriteLine("Resultado: " + resultado);
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
