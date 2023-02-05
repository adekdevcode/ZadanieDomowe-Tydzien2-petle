//8.Napisz program, który odwróci wprowadzony przez użytkownika ciągznaków. Np.
//
//Testowe dane:
//Abcdefg
//Rezultat
//Gfedcba

using System.Text;

string word = "Abcdefg";

StringBuilder sb = new StringBuilder();

for (int i = word.Length; i > 0; i--)
{
    sb.Append(word[i - 1]);
}

Console.WriteLine(sb[0].ToString().ToUpper() + sb.ToString().ToLower().Substring(1));