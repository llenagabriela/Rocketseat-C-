using System.Linq;

namespace Caracteres;

public class Palavras
{
    public static void Main()
    {
        Console.WriteLine("Digite uma ou mais palavras: ");
        string input = Console.ReadLine();
        int ContaCaractere = input.Length;

        Console.WriteLine(ContaCaractere);
    }
}