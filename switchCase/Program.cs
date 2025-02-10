namespace Aula11;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("=======Dias da Semana======");
        Console.WriteLine("Digite um número de 1 a 7: ");
        int dayOfWeek = Convert.ToInt32(Console.ReadLine());

        switch(dayOfWeek)
        {
            case 1:
                Console.WriteLine("Domingo");
                break;
            case 2:
                Console.WriteLine("Segunda");
                break;
            case 3:
                Console.WriteLine("Terça");
                break;
            case 4:
                Console.WriteLine("Quarta");
                break;
            case 5:
                Console.WriteLine("Quinta");
                break;
            case 6: 
                Console.WriteLine("Sexta");
                break;
            case 7:
                Console.WriteLine("Sábado");
                break;
            default:
                Console.WriteLine("Dia escolhido inválido");
                break;
        }

        /*
        é possível também utilizar dois "cases" juntos:

        case 4:
        case 5:
            Console.WriteLine("Uma linha para dois casos");
            break;
        */
        
    }
}