//3.Napisz program, który zaimplementuje ciąg Fibonacciego i wyświetli go na ekranie.

int n = 10;
int a = 0;
int b = 1;

Console.WriteLine(a);

for (int i = 0; i <= n; i++)
{
    Console.WriteLine(b);
    b += a;
    a = b - a;
}