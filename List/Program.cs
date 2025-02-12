namespace Aula17;

public class Program
{
    public static void Main()
    {
        string separator = "-------------------------";

        //1. Declaração com inicialização de valores
        List<string> fruits = new List<string>()
        {
            "Manga",
            "Abacate",
            "Pera"
        };
        
        //2. Acessar os valores
        Console.WriteLine(fruits[2]);
        Console.WriteLine(separator);


        //3. Adicionar Elementos
        fruits.Add("Limão");
        fruits.Add("Laranja");

        foreach(string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }
        
        Console.WriteLine(separator);
        //4. 
    }
}