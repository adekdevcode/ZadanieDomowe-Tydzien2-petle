//9.Napisz program, który zamieni liczbę dziesiętną na liczbę binarną.

int decimalNumber = 20;

string binaryReverse = "";
string binaryResult = "";

while (decimalNumber > 0)
{
    binaryReverse += decimalNumber % 2;
    decimalNumber /= 2;
}

int binaryLength = binaryReverse.Length - 1;

while (binaryLength >= 0)
{
    binaryResult += binaryReverse[binaryLength];
    binaryLength--;
}

Console.WriteLine(binaryResult);