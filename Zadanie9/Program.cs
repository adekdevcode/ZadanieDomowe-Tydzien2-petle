//9.Napisz program, który zamieni liczbę dziesiętną na liczbę binarną.

int n = 20;

string binary = "";

while(n > 0)
{
    if (n % 2 == 0)
    {
        binary += "0";
    }
    else
    {
        binary += "1";
    }

    n /= 2;
}

Console.WriteLine(binary);