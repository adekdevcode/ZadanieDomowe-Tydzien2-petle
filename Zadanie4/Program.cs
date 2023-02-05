//4. Napisz program, który po podaniu liczby całkowitej wyświetli piramidę liczb od 1 do podanej liczby w formie jak poniżej:
//    1
//    2 3
//    4 5 6
//    7 8 9 10

Console.WriteLine("Podaj liczbę ");

int n = int.Parse(Console.ReadLine());

int num = 1;
Console.WriteLine();

for (int i = 1; i < n / 2; i++)
{
    for (int j = 0; j < i; j++)
    {
        if (num > n)
            break;

        Console.Write(" " + num);
        num++;
    }
    Console.WriteLine();
}