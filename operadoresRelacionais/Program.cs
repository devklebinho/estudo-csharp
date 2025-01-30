Console.WriteLine("=================== Operadores Relacionais ===================");
Console.WriteLine("Digite o 1° número: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite o 2° número: ");
int y = Convert.ToInt32(Console.ReadLine());

string result;

//Operador de Igualdade (==)
if (x == y)
{
    result = "X é igual a Y";
}
else
{
    result = "X NÃO é igual a Y";
}

Console.WriteLine("Igualdade (==): " + result);

//Operador de diferença (!=)
if (x != y)
{
    result = "X é diferente de Y";
}
else
{
    result = "X NÃO é diferente de Y";
}

Console.WriteLine("Diferença (!=): " + result);

//Operador Maior que (>)
if(x > y)
{
    result = "X é maior que Y";
}
else
{
    result = "X NÃO é maior que Y";
}

Console.WriteLine("Maior que (>): " + result);

//Operador Menor que (<)
if(x < y)
{
    result = "X é menor que Y";
}
else
{
    result = "X NÃO é menor que Y";
}

Console.WriteLine("Menor que (<):" + result);

//Operador Maior ou igual (>=)
if(x >= y)
{
    result = "x é MAIOR ou IGUAL a y";
}
else
{
    result = "x NÂO é MAIOR ou IGUAL a y";
}

Console.WriteLine("Maior ou Igual (>=): " + result);

//Operador Menor ou igual
if(x <= y)
{
    result = "x é Menor ou IGUAL a y";
}
else
{
    result = "x NÂO é Menor ou IGUAL a y";
}

Console.WriteLine("Menor ou igual (<=): " + result);

