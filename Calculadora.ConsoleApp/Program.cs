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

                Console.WriteLine("1- Adição.\n2- Subtração.\n3- Divisão.\n4- Multiplicação.\n5- Fechar.");

                string operacao = Console.ReadLine();

                if (operacao == "S")
                    break;

                Console.WriteLine("Digite o primeiro numero");
                
                // refatoração pedaço de codigo (int -> double)

                string primeiroNumeroString = Console.ReadLine();

                double primeiroNumero = Convert.ToDouble(primeiroNumeroString);

                Console.WriteLine("Digite o segundo número:");

                string segundoNumeroString = Console.ReadLine();

                double segundoNumero = Convert.ToDouble(segundoNumeroString);

                double resultado = 0.0;
                
                //criterio 04. refatoração (if -> switch +( 4 operações basicas))
              
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
                        resultado = primeiroNumero * segundoNumero;
                        break;
                }

                Console.WriteLine("O resultado da operação é: " + resultado.ToString("F2"));

                Console.WriteLine("Digite qualquer tecla para continuar...");
                Console.ReadKey();
                }
        }
    }
}