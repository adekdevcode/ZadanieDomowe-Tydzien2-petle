//10.Napisz program, który znajdzie najmniejszą wspólną wielokrotność dla zadanych 2 liczb.

int value1 = 24;
int value2 = 36;
int multiplication = value1 * value2;

while (value1 != value2)
{
    if (value1 > value2)
    {
        value1 -= value2;
    }
    else
    {
        value2 -= value1;
    }
}

Console.WriteLine(multiplication / value1);