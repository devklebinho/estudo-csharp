using System;

namespace Aula09;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("================ Operadores Lógicos ======================");

        bool isLogged = true;
        bool hasAdminAccess = false;

        Console.WriteLine("\nInformações do Usuário: ");
        Console.WriteLine("Usuádio logado: " + isLogged);
        Console.WriteLine("Acesso ao painel de administrador " + hasAdminAccess);
        Console.WriteLine("Permissões");

        //Operador (||) - OU
        if (isLogged || hasAdminAccess)
        {
            Console.WriteLine("Acesso ao sistema concedido");
        }
        else
        {
            Console.WriteLine("Acesso ao sistema negado");
        }


        //Operador (&&) - E
        if (isLogged && hasAdminAccess)
        {
            Console.WriteLine("Acesso ao painel do administrador concedido");
        }
        else
        {
            Console.WriteLine("Acesso ao painel do administrador negado");
        }


        //Operador (!) - NÃO 
        if (!isLogged)// isLogged == False
        {
            Console.WriteLine("Usuário não logado, faça login");
        }
        else
        {
            Console.WriteLine("Usuário está logado");
        }

        Console.ReadKey();//Espera alguma tecla
    }
}