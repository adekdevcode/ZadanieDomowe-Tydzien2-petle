//8.Napisz program, który odwróci wprowadzony przez użytkownika ciągznaków. Np.
//
//Testowe dane:
//Abcdefg
//Rezultat
//Gfedcba

string word = "Abcdefg";


string reversedWord = "";

for (int i = word.Length; i > 0; i--)
{
    reversedWord += word[i - 1];
}

Console.WriteLine(char.ToUpper(reversedWord[0]) + reversedWord.ToLower().Substring(1));