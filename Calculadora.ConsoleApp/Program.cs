namespace Calculadora.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
             while (true) 
            {
                Console.Clear();

                Console.WriteLine("Calculadora (Básica) 03/2024");

                Console.WriteLine("Digite 1 para Adicionar");
                Console.WriteLine("Digite 2 para Subtrair");
                Console.WriteLine("Digite 3 para Dividir");
                Console.WriteLine("Digite 4 para Multiplicar");
                Console.WriteLine("Digite S para sair");

                string operacao = Console.ReadLine();

                if (operacao == "S")
                    break;

                Console.WriteLine("Digite o primeiro numero");

                string primeiroNumeroString = "";

                primeiroNumeroString = Console.ReadLine();

                int primeiroNumero = Convert.ToInt32(primeiroNumeroString);

                Console.WriteLine("Digite o segundo número:");

                string segundoNumeroString = Console.ReadLine();

                int segundoNumero = Convert.ToInt32(segundoNumeroString);

                int resultado = 0;
                //criterio 4.
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
                        Console.WriteLine("Você está Subtraindo.");
                        resultado = primeiroNumero * segundoNumero;
                        break;
                }

                Console.WriteLine("O resultado da operação é: " + resultado);

                string resposta = Console .ReadLine();

                }
        }
    }
}