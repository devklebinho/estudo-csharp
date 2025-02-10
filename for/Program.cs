namespace Aula14;

public class Program
{
    public static void Main()
    {
        /*
        Console.WriteLine("=========== Tabuada de Multiplicação ===========");
        Console.WriteLine("Digite um número para saber a tabuada: ");
        int numero = Convert.ToInt32(Console.ReadLine());
        for(int i = 0; i <= 10; i++)
        {
            Console.WriteLine(numero + " x " + i + " = " + numero * i);
        }
        */
        Console.WriteLine("=========== Matriz de Multiplicação ===========");
        
        for(int i = 1; i <= 10; i++)
        {
            for(int j = 1; j <= 10; j++)
            {
                // O valor 5 representa quantos espaços terá entre cada valor impresso
                Console.Write($"{i * j, 5}");
            }
            Console.WriteLine();
        }
    }
}