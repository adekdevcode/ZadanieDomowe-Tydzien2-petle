//2.Napisz program,w którym za pomocą pętli do...while znajdziesz wszystkie liczby parzyste z zakresu 0 –1000.

int n = 0;

do
{
    if (n % 2 == 0)
    {
        Console.Write($"{n}, ");
    }
    n++;
} while (n <= 1000);