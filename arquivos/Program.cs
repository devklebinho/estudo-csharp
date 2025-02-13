namespace Aula18;
using System;
using System.IO;


public class Program
{
    public static void Main()
    {
        //1. Criar um arquivo
        /*
        string content = "Olá mundo";

        File.WriteAllText("file.txt", content);// nome do arquivo.extensão , conteúdo

        Console.WriteLine("Arquivo criado com sucesso");
        */
        //2. Criar um arquivo num local específico

        string path = @"C:\\Users\\Biblioteca\\Documents\\Trabalhos"; //utiliza-se o @ para que o \ seja considerado uma string

        // Obtém o caminho da Área de Trabalho do usuário
        string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);

        // Define o caminho do arquivo
        string filePath = Path.Combine(desktopPath, "arquivo.txt");

        // Escreve a palavra "Conteúdo" no arquivo
        File.WriteAllText(filePath, "Conteúdo");

        Console.WriteLine($"Arquivo criado em: {filePath}");

        Console.ReadKey();
    }
}
