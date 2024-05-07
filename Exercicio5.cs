namespace LePlaca;

public class Placa
{
    public static void Main()
    {
        Console.WriteLine("Digite uma placa: ");
        string placa = Console.ReadLine();
        int contaplaca = placa.Length;
        bool result = true;

        if (contaplaca != 7)
        {
            result = false;
        }

        for (int i = 0; i < contaplaca; i++)
        {
            if (i <= 2)
            {
                if (!Char.IsLetter(placa[i]))
                {
                    result = false;
                    break;
                }
            }

            if (i >= 3)
            {
                if (!Char.IsDigit(placa[i]))
                {
                    result = false;
                    break;
                }
            }
        }

        Console.WriteLine(result ? "Verdadeiro" : "Falso");
    }
}