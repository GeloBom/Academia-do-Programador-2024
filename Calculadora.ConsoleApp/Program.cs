namespace Calculadora.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
             while (true) 
            {
                Console.Clear();

                Console.WriteLine("Calculadora (Básica) 03/2024\nSelecione uma das opções abaixo:\n");


                Console.WriteLine("1- Adição.\n2- Subtração.\n3- Divisão.\n4- Multiplicação.\n5- Fechar.");

                string operacao = Console.ReadLine();

                if (operacao == "S" || operacao == "s")
                    break;

                if (operacao != "1" && operacao!= "2" && operacao != "3" && operacao != "4" && operacao !="s" && operacao != "S" ) 
                {
                    Console.WriteLine("Operação invalida, Tente novamente...");
                    Console.ReadLine();

                    continue;
                }

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
                        Console.WriteLine("Você está Somando.\n");
                        resultado = primeiroNumero + segundoNumero;
                        break;

                    case "2":
                        Console.WriteLine("Você está Subtraindo.\n");
                        resultado = primeiroNumero - segundoNumero;
                        break;

                    case "3":
                        while (segundoNumero == 0) 
                        {
                            Console.WriteLine("Segundo número inválido, Digite um valor maior que Zero, tente novamente!\n");
                            
                            Console.WriteLine("Digite o segundo número novamente\n");

                            segundoNumero = Convert.ToDouble(Console.ReadLine()); 
                        }
                        Console.WriteLine("Você está dividindo\n");
                        resultado = primeiroNumero / segundoNumero;
                        break;
                    
                    case "4":
                        Console.WriteLine("Você está Multiplicando.\n");
                        resultado = primeiroNumero * segundoNumero;
                        break;
                }

                Console.WriteLine("O resultado da operação é: " + resultado.ToString("F2"));

                Console.WriteLine("Digite qualquer tecla para continuar...\n");
                Console.ReadKey();
                }
        }
    }
}