//6.Napisz program, który dla liczb od 0 do 20 obliczy sumę wg wzoru:1 + ½+1 / 3 + ¼itd.

double suma = 0;

for (int i = 0; i < 20; i++)
{
    suma += 1.0 / (i + 1);
}

Console.WriteLine(suma);