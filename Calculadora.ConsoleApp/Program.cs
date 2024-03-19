namespace Calculadora.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string operacao = MostrarMenu();

                if (OpcaoSaidaSelecionada(operacao))
                    break;

                if (OpcaoInvalida(operacao))
                {
                    Console.WriteLine("Operação inválida, tente novamente...");
                    Console.ReadLine();
                    continue;
                }

                double primeiroNumero = ObterNumeroCalculo("Digite o primeiro número:");
                double segundoNumero = ObterNumeroCalculo("Digite o segundo número:");

                double resultado = 0.0;

                resultado = Calculo(operacao, primeiroNumero, segundoNumero, resultado);
            }
        }

        static string MostrarMenu()
        {
            Console.Clear();

            Console.WriteLine("Calculadora (Básica) 03/2024");

            Console.WriteLine("1- Adição.\n2- Subtração.\n3- Divisão.\n4- Multiplicação.\nS- Fechar.");

            string operacao = Console.ReadLine();

            return operacao;
        }

        static bool OpcaoSaidaSelecionada(string opcao)
        {
            bool opcaoSaidaSelecionada = opcao == "S" || opcao == "s";

            return opcaoSaidaSelecionada;
        }

        static bool OpcaoInvalida(string opcao)
        {
            bool opcaoInvalida = opcao != "1" && opcao != "2" && opcao != "3" && opcao != "4" && opcao != "S" && opcao != "s";
            return opcaoInvalida;
        }

        static double ObterNumeroCalculo(string texto)
        {
            Console.WriteLine(texto);

            double numero = Convert.ToDouble(Console.ReadLine());
            return numero;
        }

        static double Calculo(string operacao, double primeiroNumero, double segundoNumero, double resultado)
        {
            switch (operacao)
            {
                case "1":
                    Console.WriteLine("Você está Somando.");
                    resultado = primeiroNumero + segundoNumero;
                    break;

                case "2":
                    Console.WriteLine("Você está Subtraindo.");
                    resultado = primeiroNumero - segundoNumero;
                    break;

                case "3":
                    Console.WriteLine("Você está dividindo");
                    resultado = primeiroNumero / segundoNumero;
                    break;

                case "4":
                    Console.WriteLine("Você está Multiplicando.");

                    if (primeiroNumero == 0)
                    {
                        Console.WriteLine("Insira um número válido maior que 0. Tecle uma tecla para tentar novamente...");
                        Console.ReadKey();
                        break;
                    }

                    resultado = primeiroNumero * segundoNumero;

                    Console.WriteLine("O resultado da operação é: " + resultado.ToString("F"));
                    Console.WriteLine("Digite qualquer tecla para continuar...");
                    Console.ReadKey();

                    break;
            }
            return resultado;
        }
    }
}