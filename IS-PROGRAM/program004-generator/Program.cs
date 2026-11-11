string again = "a";

// Generátor pseudonáhodných čísel + počty kladných/záporných/nulových a sudých/lichých čísel
// Řídící cyklus programu
// ToLower() převede vstup na malá písmena, takže program pokračuje při zadání "a" i "A"
// Jakýkoli jiný vstup program ukončí
while (again.ToLower() == "a")
{
    // Vymazání konzole
    Console.Clear();

    // Hlavička programu
    Console.WriteLine("*************************************");
    Console.WriteLine("** Generátor + třídění čísel ******");
    Console.WriteLine("*************************************");
    Console.WriteLine("*********** Lukáš Kejzral ***********");
    Console.WriteLine("*************************************");
    Console.WriteLine();
    Console.WriteLine();

    // Načtení počtu čísel (musí být alespoň 1)
    Console.Write("Zadejte počet čísel (celé kladné číslo): ");
    int count;
    while (!int.TryParse(Console.ReadLine(), out count) || count < 1)
    {
        Console.Write("Nezadali jste celé kladné číslo. Zadejte počet znovu: ");
    }

    // Načtení dolní meze
    Console.Write("Zadejte dolní mez (celé číslo): ");
    int lowerBound;
    while (!int.TryParse(Console.ReadLine(), out lowerBound))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte dolní mez znovu: ");
    }

    // Načtení horní meze (nesmí být menší než dolní mez)
    Console.Write("Zadejte horní mez (celé číslo): ");
    int upperBound;
    while (!int.TryParse(Console.ReadLine(), out upperBound) || upperBound < lowerBound)
    {
        Console.Write("Nezadali jste celé číslo, nebo je menší než dolní mez. Zadejte horní mez znovu: ");
    }

    // Rekapitulace zadaných hodnot
    Console.WriteLine();
    Console.WriteLine("=============================");
    Console.WriteLine($"Počet čísel: {count}; Dolní mez: {lowerBound}; Horní mez: {upperBound};");
    Console.WriteLine("=============================");
    Console.WriteLine();

    // Generování čísel do pole
    // Metoda Next(min, max) vrací čísla v intervalu <min, max), proto k horní mezi přičítáme 1
    // Výpočet probíhá v typu long, aby nedošlo k přetečení, když je horní mez int.MaxValue
    Random random = new Random();
    int[] numbers = new int[count];
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = (int)random.NextInt64(lowerBound, (long)upperBound + 1);
    }

    // Výpis vygenerovaných čísel
    Console.WriteLine("Vygenerovaná čísla:");
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.WriteLine();
    Console.WriteLine();

    // Počítadla pro kladná, záporná a nulová čísla a pro sudá a lichá čísla
    int positiveCount = 0;
    int negativeCount = 0;
    int zeroCount = 0;
    int evenCount = 0;
    int oddCount = 0;

    // Průchod polem a vyhodnocení každého čísla
    for (int i = 0; i < numbers.Length; i++)
    {
        // Kladné, záporné nebo nulové
        if (numbers[i] > 0)
        {
            positiveCount++;
        }
        else if (numbers[i] < 0)
        {
            negativeCount++;
        }
        else
        {
            zeroCount++;
        }

        // Sudé nebo liché (zbytek po dělení 2 je u sudých čísel vždy 0, i u záporných)
        if (numbers[i] % 2 == 0)
        {
            evenCount++;
        }
        else
        {
            oddCount++;
        }
    }

    // Výpis výsledků
    Console.WriteLine("=============================");
    Console.WriteLine($"Kladných čísel: {positiveCount}");
    Console.WriteLine($"Záporných čísel: {negativeCount}");
    Console.WriteLine($"Nulových čísel: {zeroCount}");
    Console.WriteLine("-----------------------------");
    Console.WriteLine($"Sudých čísel: {evenCount}");
    Console.WriteLine($"Lichých čísel: {oddCount}");
    Console.WriteLine("=============================");

    // Dotaz směrem k uživateli na opakování
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a. Následně potvrďte klávesou Enter.");
    Console.WriteLine("Jakoukoli jinou klávesou program ukončíte.");
    Console.WriteLine();
    Console.Write("Chcete program spustit znovu? ");
    again = Console.ReadLine() ?? "";
}
