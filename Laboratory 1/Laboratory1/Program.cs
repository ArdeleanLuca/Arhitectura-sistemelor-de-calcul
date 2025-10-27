        // Citim numarul de la tastatura
        Console.Write("Introduceti numarul: ");
        string numar = Console.ReadLine();

        // Citim baza initiala
        Console.Write("Introduceti baza initiala (2-16): ");
        int bazaInitiala = int.Parse(Console.ReadLine());

        // Citim baza finala
        Console.Write("Introduceti baza finala (2-16): ");
        int bazaFinala = int.Parse(Console.ReadLine());

        // Convertim numarul in baza 10 (intermediar)
        int valoareInBaza10 = Convert.ToInt32(numar, bazaInitiala);

        // Convertim baza 10 in baza finala
        string rezultat = Convert.ToString(valoareInBaza10, bazaFinala).ToUpper();

        // Afisam rezultatul
        Console.WriteLine($"Numarul {numar} din baza {bazaInitiala} este {rezultat} in baza {bazaFinala}");