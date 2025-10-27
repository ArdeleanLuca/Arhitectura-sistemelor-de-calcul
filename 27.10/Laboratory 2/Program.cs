using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.Write("Introduceti numarul: ");
        string numar = Console.ReadLine().ToUpper();

        Console.Write("Introduceti baza initiala (2-16): ");
        int b1 = int.Parse(Console.ReadLine());

        Console.Write("Introduceti baza finala (2-16): ");
        int b2 = int.Parse(Console.ReadLine());

        string rezultat = ConvertBazeVirgulaFix(numar, b1, b2);
        Console.WriteLine($"Rezultat: {rezultat}");
    }

    static string ConvertBazeVirgulaFix(string num, int b1, int b2)
    {
        string[] parti = num.Split('.');

        string parteInt = parti[0];
        string parteFrac = parti.Length > 1 ? parti[1] : "";

        // Partea intreaga in baza 10
        int int10 = Convert.ToInt32(parteInt, b1);

        // Partea fracționară în baza 10:
        double frac10 = 0;
        for (int i = 0; i < parteFrac.Length; i++)
        {
            int val = Convert.ToInt32(parteFrac[i].ToString(), b1);
            frac10 += val / Math.Pow(b1, i + 1);
        }

        // Din 10 în baza b2
        string intFinal = Convert.ToString(int10, b2).ToUpper();

        if (parteFrac == "") return intFinal;

        // Convertim partea fracționară
        StringBuilder fracFinal = new StringBuilder();
        double temp = frac10;

        for (int i = 0; i < 10; i++) // maxim 10 cifre după virgula
        {
            temp *= b2;
            int cifra = (int)temp;
            fracFinal.Append(ConvertToBaseChar(cifra));
            temp -= cifra;
            if (temp == 0) break;
        }

        return intFinal + "." + fracFinal.ToString();
    }

    static char ConvertToBaseChar(int v)
    {
        return (char)(v < 10 ? v + '0' : v - 10 + 'A');
    }
}