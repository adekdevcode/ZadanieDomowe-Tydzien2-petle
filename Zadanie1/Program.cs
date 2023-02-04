//1.Napisz program, który sprawdzi ile jest liczb pierwszych w zakresie 0 –100

int counter = 0;

for (int i = 2; i <= 100; i++)
{
    bool isPrime = true;

    for (int j = 2; j <= Math.Sqrt(i); j++)
    {
        if (i % j == 0)
        {
            isPrime = false;
            break;
        }
        
    }
    
    if (isPrime)
        counter++;
}

Console.WriteLine($"Ilość liczb pierwszych w zakresie 0-100 wynosi : {counter}");