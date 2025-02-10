
namespace Calculadora;

public class Program
{
    public static void Main()
    {
        bool isProgramRunning = true;

        while(isProgramRunning)
        {
            Console.WriteLine("=========== CALCULADORA =============");
            Console.WriteLine("Insira dois valores (X e Y) e escolha uma operação");

            double num1, num2;

            Console.WriteLine("X: ");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Y: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(
                "Escolha a operação:\n"+
                "1 - Soma\n" +
                "2 - Subtração\n" + 
                "3 - Multiplicação\n" + 
                "4 - Divisão\n");

            int option = Convert.ToInt32(Console.ReadLine());
            double result = 0; 

            if(option == 1)
            {
                result = num1 + num2;
            }
            else if(option == 2)
            {
                result = num1 - num2;
            }
            else if(option == 3)
            {
                result = num1 * num2;
            }
            else if(option == 4)
            {
                if(num2 != 0)
                {
                    result = num1 / num2;
                }
                else
                {
                    Console.WriteLine("Não é possível dividir um número por zero!");
                }
            }
            else
            {
                Console.WriteLine("Operação inválida");
            }

            Console.WriteLine("\nResultado: " + result + "\n");

            Console.WriteLine("\nDeseja realizar outra operação (s/n)?");
            string response = Console.ReadLine();
            if(response != "s"){
                isProgramRunning = false;
            }
        }

        Console.WriteLine("Obrigado por usar a calculadra!");
    }
}