namespace Aula16;

public class Program
{
    public static void Main()
    {
        string separator = "-----------------------";

        //1. Declaração de Array inicializada com valores
        string[] fruits = {"Jaca", "Cajá", "Caju", "Carambola"};
        Console.WriteLine(fruits);


        //2. Acessar os valores (através dos índices)
        //Console.WriteLine(fruits[0]);// primeiro item, índice zero
        Console.WriteLine(separator);
        foreach(string fruit in fruits)//fruit é o item, funciona como índice
        {
            Console.WriteLine(fruit);
        }

        //3. Contagem de índices (quantidade de elementos)
        Console.WriteLine(separator);
        Console.WriteLine("Quantidade de índices: " + fruits.Length);

        //4. Alterar os valores
        Console.WriteLine(separator);
        Console.WriteLine("Valor antes da alteração: " + fruits[1]);
        fruits[1] = "Abacate";
        Console.WriteLine("Valor depois da alteração: " + fruits[1]);

        Console.WriteLine(separator);

        //5. Declaração sem inicializar (array estático com quantidade fixa de elementos)
        int[] numbers = new int[3];
        numbers[0] = 10;
        numbers[1] = 20;
        numbers[2] = 30;
        foreach(int elemento in numbers)
        {
            Console.WriteLine(elemento);
        }

    }
}