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
    Console.WriteLine("******* Pravoúhlý trojúhelník *******");
    Console.WriteLine("*************************************");
    Console.WriteLine("*********** Lukáš Kejzral ***********");
    Console.WriteLine("*************************************");
    Console.WriteLine();
    Console.WriteLine();

    // Vstupem programu je délka odvěsny (přirozené číslo)
    // Trojúhelník je rovnoramenný pravoúhlý, obě odvěsny mají stejnou délku
    Console.Write("Zadejte délku odvěsny (přirozené číslo): ");
    int leg;
    while (!int.TryParse(Console.ReadLine(), out leg) || leg < 1)
    {
        Console.Write("Nezadali jste přirozené číslo. Zadejte délku odvěsny znovu: ");
    }

    // Rekapitulace zadaných hodnot
    Console.WriteLine();
    Console.WriteLine("=============================");
    Console.WriteLine($"Délka odvěsny: {leg}");
    Console.WriteLine("=============================");
    Console.WriteLine();

    // Vykreslení vyplněného trojúhelníku s pravým úhlem vlevo dole
    // V prvním řádku je jedna hvězdička, v každém dalším o jednu více
    Console.WriteLine("Vyplněný trojúhelník:");
    for (int row = 1; row <= leg; row++)
    {
        for (int column = 1; column <= row; column++)
        {
            Console.Write("* ");
        }
        Console.WriteLine();
    }

    // Vykreslení obvodu trojúhelníku
    // Hvězdička se vypíše na začátku řádku, na konci řádku (přepona) a v posledním řádku (základna)
    Console.WriteLine();
    Console.WriteLine("Obvod trojúhelníku:");
    for (int row = 1; row <= leg; row++)
    {
        for (int column = 1; column <= row; column++)
        {
            if (column == 1 || column == row || row == leg)
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
