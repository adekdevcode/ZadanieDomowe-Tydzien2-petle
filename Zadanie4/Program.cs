//4. Napisz program, który po podaniu liczby całkowitej wyświetli piramidę liczb od 1 do podanej liczby w formie jak poniżej:
//    1
//    2 3
//    4 5 6
//    7 8 9 10

int n = 16;

int zmienna = 1;

for (int i = 1; i < n / 2; i++)
{
    for (int j = 0; j < i; j++)
    {
        if (zmienna > n)
            break;

        Console.Write(" " + zmienna);
        zmienna++;
    }
    Console.WriteLine();
}