namespace Valores;

public class Valores
{
    public static void Main()
    {
        Console.WriteLine("Digite um valor:");
        string input = Console.ReadLine();
        int valor1 = int.Parse(input);

        Console.WriteLine("Digite outro valor:");
        input = Console.ReadLine();
        int valor2 = int.Parse(input);

        Console.WriteLine(valor1 + valor2);
        Console.WriteLine(valor1 - valor2);
        Console.WriteLine(valor1 * valor2);

        if (valor2 > 0)
        {
            Console.WriteLine(valor1 / valor2);
        }
        
        Console.WriteLine((valor1 + valor2)/2);
    }
}