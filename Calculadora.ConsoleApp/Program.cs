﻿namespace Calculadora.ConsoleApp
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
                    ExibirMensagemErro();
                    continue;
                }

                double primeiroNumero = ObterNumeroCalculo("Digite o primeiro número:");
                double segundoNumero = ObterNumeroCalculo("Digite o segundo número:");

                double resultado = Calculo(operacao, primeiroNumero, segundoNumero);
                ExibirResultado(resultado);
            }
        }

        static string MostrarMenu()
        {
            Console.Clear();
            Console.WriteLine("Calculadora (Básica) 03/2024\nSelecione uma das opções abaixo:\n");
            Console.WriteLine("1- Adição.\n2- Subtração.\n3- Divisão.\n4- Multiplicação.\n5- Fechar.");
            return Console.ReadLine();
        }

        static bool OpcaoSaidaSelecionada(string opcao)
        {
            return opcao.Equals("S", StringComparison.OrdinalIgnoreCase);
        }

        static bool OpcaoInvalida(string opcao)
        {
            return opcao != "1" && opcao != "2" && opcao != "3" && opcao != "4" && opcao != "5";
        }

        private static void ExibirMensagemErro()
        {
            Console.WriteLine("Operação inválida, tente novamente...");
            Console.ReadLine();
        }

        static double ObterNumeroCalculo(string texto)
        {
            Console.WriteLine(texto);

            double numero;
            while (!double.TryParse(Console.ReadLine(), out numero))
            {
                Console.WriteLine("Entrada inválida. Digite um número válido.");
            }
            return numero;
        }

        static double Calculo(string operacao, double primeiroNumero, double segundoNumero)
        {
            double resultado = 0.0;

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
                    if (segundoNumero == 0)
                    {
                        Console.WriteLine("Erro: Divisão por zero não é permitida.");
                        break;
                    }
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
                    break;
            }

            return resultado;
        }

        static void ExibirResultado(double resultado)
        {
            Console.WriteLine("O resultado da operação é: " + resultado.ToString("F"));
            Console.WriteLine("Digite qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }
}