
namespace Calculadora;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("=========== CALCULADORA =============");
        Console.WriteLine("Insira dois valores (X e Y) e escolha uma operação");

        double num1, num2, result;

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

        string option = Console.ReadLine();
          
        switch(option)
        {
            case "1":
                result = num1 + num2;
                break;
            case "2":
                result = num1 - num2;
                break;
            case "3":
                result = num1 * num2;
                break;
            case "4":
                result = num1 / num2;
                break;
            default:
                Console.WriteLine("Default");
                break;
            
        }
        
        Console.WriteLine("Resultado: " + result);

        //Console.WriteLine("\nSoma: " + sum + "\nMultiplicação: " + mult + "\nSubtração: " + sub + "\nDivisão: " + div);

        Console.ReadKey();
    }
}