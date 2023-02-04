//7.Napisz program, który dla liczby zadanej przez użytkownika narysuje diament o krótszej przekątnej o długości wprowadzonej przez użytkownika i wg wzoru:

//    ***************************************** 

int n = 10;

for (int i = 1; i < n; i++)
{
    for (int j = i; j < n; j++)
    {
        Console.Write(" ");
    }

    for (int k = 1; k < i; k++)
    {
        Console.Write("*");
    }

    for (int f = 1; f <= i; f++)
    {
        Console.Write("*");
    }

    Console.WriteLine();
}

for (int i = 1; i <= n; i++)
{
    for (int j = 1; j < i; j++)
    {
        Console.Write(" ");
    }

    for (int k = i; k < n; k++)
    {
        Console.Write("*");
    }

    for (int f = i; f <= n; f++)
    {
        Console.Write("*");
    }

    Console.WriteLine();
}