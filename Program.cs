namespace Calculadora
{
    
    class Program
    {

         static void Main()
         {
            Menu();
         }

        public static void Menu ()
        {
            
            Console.WriteLine("Menu");
            Console.WriteLine("1 - Somar");
            Console.WriteLine("2 - Subtrair");
            Console.WriteLine("3 - Multiplicar");
            Console.WriteLine("4 - Dividir");
            Console.WriteLine("5 - Resto Da Divisão");
            Console.WriteLine("6 - Potenciação"); 
            Console.WriteLine("0 - Sair");

            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    somar();
                    Menu();
                    break;
                case "2":
                    Subtrair();
                    Menu();
                    break;
                case "3":
                    Multiplicar();
                    Menu();
                    break;
                case "4":
                    Dividir();
                    Menu();
                    break;
                case "5":
                    Resto();
                    Menu();
                    break;
                case "6":
                    potenciar();
                    Menu();
                    break;
                case "0":
                    break;
                default:
                    Menu();
                    break;
                

            }  
            Console.ReadKey();

        }

        static void somar()
        {
           decimal valor1, valor2, resultadoDaSoma;
           Console.WriteLine("Digite o primeiro valor: ");
           valor1 = decimal.Parse(Console.ReadLine());
           Console.WriteLine("Digite o segundo valor: ");
           valor2 = decimal.Parse(Console.ReadLine());

           resultadoDaSoma = valor1 + valor2;

           Console.WriteLine($"O resultado da soma é: {resultadoDaSoma}"); 
        }

        static void Subtrair()
        {
            decimal valor1, valor2, resultadoDaSubtracao;
            Console.WriteLine("Digite o primeiro valor: ");
            valor1 = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            valor2 = decimal.Parse(Console.ReadLine());

            resultadoDaSubtracao = valor1 - valor2;

            Console.WriteLine($"O resultado da subtração é: {resultadoDaSubtracao}"); 
        }   

        static void Multiplicar()
        {
            decimal valor1, valor2, resultadoDaMultiplicacao;
            Console.WriteLine("Digite o primeiro valor: ");
            valor1 = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            valor2 = decimal.Parse(Console.ReadLine());

            resultadoDaMultiplicacao = valor1 * valor2;

            Console.WriteLine($"O resultado da multiplicação é: {resultadoDaMultiplicacao}"); 
        }

        static void Dividir()
        {
            decimal dividendo, divisor, resultadoDaDivisao;
            Console.WriteLine("Digite o primeiro valor: ");
            dividendo = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            divisor = decimal.Parse(Console.ReadLine());

            if(divisor != 0)
            {
              resultadoDaDivisao = dividendo / divisor;
              Console.WriteLine($"O resultado da divisão é: {resultadoDaDivisao}");
            }
            else 
              Console.WriteLine("Não é possivel divisão por zero");
        }
           
        static void Resto()
        {
            decimal dividendo, divisor, resultadoDoRestoDaDivisao;
            Console.WriteLine("Digite o primeiro valor: ");
            dividendo = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            divisor = decimal.Parse(Console.ReadLine());

            resultadoDoRestoDaDivisao = dividendo % divisor;

            Console.WriteLine($"O resultado do resto da divisão é: {resultadoDoRestoDaDivisao}"); 
        }
        
           
        static void potenciar()
        {
            double base1, expoente, resultadoDaPotenciacao;
            Console.WriteLine("Digite a base: ");
            base1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o expoente: ");
            expoente = double.Parse(Console.ReadLine());

            resultadoDaPotenciacao = Math.Pow(base1, expoente);

            Console.WriteLine($"O resultado da potenciação é: {resultadoDaPotenciacao}"); 
        }
    }
}
