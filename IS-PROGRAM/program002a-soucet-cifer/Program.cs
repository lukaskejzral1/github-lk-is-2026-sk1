string again = "a";

// Řídící cyklus programu
// ToLower() převede vstup na malá písmena, takže program pokračuje při zadání "a" i "A"
// Jakýkoli jiný vstup program ukončí
while (again.ToLower() == "a")
{
    // Vymazání konzole
    Console.Clear();

    // Hlavička programu
    Console.WriteLine("*************************************");
    Console.WriteLine("****** Ciferný součet a součin ******");
    Console.WriteLine("*************************************");
    Console.WriteLine("*********** Lukáš Kejzral ***********");
    Console.WriteLine("*************************************");
    Console.WriteLine();
    Console.WriteLine();

    // Načtení první hodnoty
    Console.Write("Zadejte celé číslo: ");
    int number;
    while (!int.TryParse(Console.ReadLine(), out number))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte číslo znovu: ");
    }

    // Rekapitulace zadaných hodnot
    Console.WriteLine();
    Console.WriteLine("=============================");
    Console.WriteLine($"Zadané číslo: {number}");
    Console.WriteLine("=============================");
    Console.WriteLine();
    Console.WriteLine();

    // Příprava pomocných proměnných pro výpočet
    int numberBackup = number;
    int sum = 0;        // Neutrální hodnota pro sčítání je 0
    int product = 1;    // Neutrální hodnota pro násobení je 1
    int digit;          // Proměnná pro uložení právě zjištěné číslice

    // Ošetření záporných čísel (znaménko nemá vliv na číslice)
    if (number < 0)
    {
        number = -number;
    }

    // Zvláštní případ pro nulu (jediná číslice je 0, tedy součet i součin jsou 0)
    if (number == 0)
    {
        sum = 0;
        product = 0;
    }
    else
    {
        Console.WriteLine();
        Console.WriteLine("Průběh rozkladu čísla na číslice (zprava)");

        // Matematický rozklad čísla pomocí cyklu
        // Využíváme operaci modulo - určení zbytku po celočíselném dělení
        while (number > 0)
        {
            digit = number % 10;        // Modulo 10 - získáme poslední číslici
            sum = sum + digit;          // Přičtení číslice k celkovému součtu
            product = product * digit;  // Vynásobení celkového součinu touto číslicí
            Console.WriteLine($"Získaná číslice: {digit}");
            number = number / 10;       // Celočíselné dělení 10 odstraní poslední číslici
        }
    }

    // Výpis výsledků
    Console.WriteLine();
    Console.WriteLine("=============================");
    Console.WriteLine($"Součet číslic čísla {numberBackup} je {sum}.");
    Console.WriteLine($"Součin číslic čísla {numberBackup} je {product}.");
    Console.WriteLine("=============================");
    Console.WriteLine();

    // Dotaz směrem k uživateli na opakování
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a. Následně potvrďte klávesou Enter.");
    Console.WriteLine("Jakoukoli jinou klávesou program ukončíte.");
    Console.WriteLine();
    Console.Write("Chcete program spustit znovu? ");
    again = Console.ReadLine() ?? "";
}