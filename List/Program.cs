namespace Aula17;

public class Program
{
    public static void Main()
    {
        string separator = "-------------------------";
        Console.WriteLine(separator);

        //1. Declaração com inicialização de valores
        List<string> fruits = new List<string>()
        {
            "Manga",
            "Abacate",
            "Pera"
        };
        
        //função para exibir o conteúdo da lista
        void ShowList()
        {
            foreach(string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }               
        }
     
        ShowList();
        Console.WriteLine(separator);

        //2. Acessar os valores
        Console.WriteLine($"fruta na posição 3: {fruits[2]}");
        Console.WriteLine(separator);


        //3. Adicionar Elementos
        fruits.Add("Limão");
        fruits.Add("Laranja");

        ShowList();
        Console.WriteLine(separator);

        //4. Remover elementos
        fruits.Remove("Limão");
        ShowList();
        Console.WriteLine(separator);

        //5. Contagem de Elementos
        Console.WriteLine($"Quantidade de Frutas: {fruits.Count}");
        Console.WriteLine(separator);

        //6. Modificar um elemento
        fruits[2] = "Maracujá";
        ShowList();
        Console.WriteLine(separator);
       
        //7. Limpar a lista
        fruits.Clear();
        ShowList();
        Console.WriteLine("Lista Fruits vazia; Nº de itens: " + fruits.Count);
        Console.WriteLine(separator);


        //8. Declaração sem inicializar
        List<int> numbers = new List<int>();
        Console.WriteLine($"Lista Numbers vazia; Nº de itens: {numbers.Count}\n");
    }
}