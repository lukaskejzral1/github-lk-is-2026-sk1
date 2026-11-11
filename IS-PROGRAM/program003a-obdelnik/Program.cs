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
    Console.WriteLine("************* Obdélník **************");
    Console.WriteLine("*************************************");
    Console.WriteLine("*********** Lukáš Kejzral ***********");
    Console.WriteLine("*************************************");
    Console.WriteLine();
    Console.WriteLine();

    // Načtení strany a (šířka) - přirozené číslo, tedy alespoň 1
    Console.Write("Zadejte délku strany a - šířku (přirozené číslo): ");
    int a;
    while (!int.TryParse(Console.ReadLine(), out a) || a < 1)
    {
        Console.Write("Nezadali jste přirozené číslo. Zadejte stranu a znovu: ");
    }

    // Načtení strany b (výška) - přirozené číslo, tedy alespoň 1
    Console.Write("Zadejte délku strany b - výšku (přirozené číslo): ");
    int b;
    while (!int.TryParse(Console.ReadLine(), out b) || b < 1)
    {
        Console.Write("Nezadali jste přirozené číslo. Zadejte stranu b znovu: ");
    }

    // Rekapitulace zadaných hodnot
    Console.WriteLine();
    Console.WriteLine("=============================");
    Console.WriteLine($"Strana a (šířka): {a}; Strana b (výška): {b};");
    Console.WriteLine("=============================");
    Console.WriteLine();

    // Vykreslení vyplněného obdélníku
    // Vnější cyklus řídí řádky (výška b), vnitřní cyklus znaky v řádku (šířka a)
    // Za každý znak přidáváme mezeru, aby čtverec nevypadal na konzoli jako obdélník
    Console.WriteLine("Vyplněný obdélník:");
    for (int row = 0; row < b; row++)
    {
        for (int column = 0; column < a; column++)
        {
            Console.Write("* ");
        }
        Console.WriteLine();
    }

    // Vykreslení pouze obvodu obdélníku
    // Hvězdička se vypíše jen na prvním a posledním řádku a na prvním a posledním sloupci
    Console.WriteLine();
    Console.WriteLine("Obvod obdélníku:");
    for (int row = 0; row < b; row++)
    {
        for (int column = 0; column < a; column++)
        {
            if (row == 0 || row == b - 1 || column == 0 || column == a - 1)
            {
                Console.Write("* ");
            }
            else
            {
                Console.Write("  ");
            }
        }
        Console.WriteLine();
    }

    // Dotaz směrem k uživateli na opakování
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a. Následně potvrďte klávesou Enter.");
    Console.WriteLine("Jakoukoli jinou klávesou program ukončíte.");
    Console.WriteLine();
    Console.Write("Chcete program spustit znovu? ");
    again = Console.ReadLine() ?? "";
}
