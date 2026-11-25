// program005a-max-min
// Generátor pseudonáhodných čísel + hledání maxima a minima
// + vykreslení přesýpacích hodin z hvězdiček podle nalezeného maxima.
// Rozšíření (DÚ): počet výskytů maxima/minima a pozice všech maximálních/minimálních prvků.

Console.OutputEncoding = System.Text.Encoding.UTF8;

string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("****************************************");
    Console.WriteLine("********* Maximum a minimum ************");
    Console.WriteLine("****************************************");
    Console.WriteLine();

    // ---------- VSTUPY (ošetřené pomocí TryParse) ----------

    // Počet čísel – musí být kladné celé číslo
    Console.Write("Zadejte počet generovaných čísel (celé číslo > 0): ");
    int n;
    while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
    {
        Console.Write("Nezadali jste kladné celé číslo. Zadejte počet čísel znovu: ");
    }

    // Dolní mez
    Console.Write("Zadejte dolní mez (celé číslo): ");
    int lowerBound;
    while (!int.TryParse(Console.ReadLine(), out lowerBound))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte dolní mez znovu: ");
    }

    // Horní mez – nesmí být menší než dolní mez
    Console.Write("Zadejte horní mez (celé číslo): ");
    int upperBound;
    while (!int.TryParse(Console.ReadLine(), out upperBound) || upperBound < lowerBound)
    {
        Console.Write($"Zadejte celé číslo větší nebo rovno {lowerBound}: ");
    }

    // ---------- GENERÁTOR ----------

    int[] myArray = new int[n];
    Random randomNumber = new Random();

    Console.WriteLine();
    Console.WriteLine("Náhodná čísla:");
    for (int i = 0; i < n; i++)
    {
        // Next(a, b) generuje čísla z intervalu <a; b), proto upperBound + 1
        myArray[i] = randomNumber.Next(lowerBound, upperBound + 1);
        Console.Write($"{myArray[i]}; ");
    }
    Console.WriteLine();

    // ---------- HLEDÁNÍ MAXIMA A MINIMA ----------

    // Na začátku považujeme za maximum i minimum první prvek pole
    int max = myArray[0];
    int min = myArray[0];
    int posMax = 0;
    int posMin = 0;

    // Procházíme zbytek pole; ostrá nerovnost (> a <) zajistí,
    // že si zapamatujeme pozici PRVNÍHO výskytu
    for (int i = 1; i < n; i++)
    {
        if (myArray[i] > max)
        {
            max = myArray[i];
            posMax = i;
        }
        if (myArray[i] < min)
        {
            min = myArray[i];
            posMin = i;
        }
    }

    Console.WriteLine();
    Console.WriteLine($"Maximum: {max}");
    Console.WriteLine($"Pozice prvního maxima: {posMax}");
    Console.WriteLine($"Minimum: {min}");
    Console.WriteLine($"Pozice prvního minima: {posMin}");

    // ---------- ROZŠÍŘENÍ: VŠECHNY VÝSKYTY MAXIMA A MINIMA ----------

    // Druhým průchodem polem spočítáme výskyty a pozice si
    // průběžně skládáme do textového řetězce
    int countMax = 0;
    int countMin = 0;
    string positionsMax = "";
    string positionsMin = "";

    for (int i = 0; i < n; i++)
    {
        if (myArray[i] == max)
        {
            countMax++;
            positionsMax += i + "; ";
        }
        if (myArray[i] == min)
        {
            countMin++;
            positionsMin += i + "; ";
        }
    }

    Console.WriteLine();
    if (countMax > 1)
    {
        Console.WriteLine($"Maximum {max} se vyskytuje {countMax}x.");
        Console.WriteLine($"Pozice všech maxim: {positionsMax}");
    }
    else
    {
        Console.WriteLine($"Maximum {max} se vyskytuje pouze jednou.");
    }

    if (countMin > 1)
    {
        Console.WriteLine($"Minimum {min} se vyskytuje {countMin}x.");
        Console.WriteLine($"Pozice všech minim: {positionsMin}");
    }
    else
    {
        Console.WriteLine($"Minimum {min} se vyskytuje pouze jednou.");
    }

    // ---------- PŘESÝPACÍ HODINY ----------

    Console.WriteLine();
    if (max >= 3)
    {
        // Výška obrazce = max řádků, šířka nejširšího řádku = max hvězdiček.
        // Šířka řádku i:  |max - 1 - 2*i| + 1
        //   - liché max (např. 5): 5, 3, 1, 3, 5  -> uprostřed jedna hvězdička
        //   - sudé max  (např. 6): 6, 4, 2, 2, 4, 6 -> uprostřed dva řádky se dvěma hvězdičkami
        for (int i = 0; i < max; i++)
        {
            int stars = Math.Abs(max - 1 - 2 * i) + 1;

            // Každá hvězdička zabírá 2 znaky ("* "), proto je odsazení
            // (max - stars) / 2 hvězdiček = (max - stars) mezer
            int spaces = max - stars;

            // Barvy: horní polovina žlutá (písek nahoře), dolní tmavě žlutá
            // (nasypaný písek), nejužší místo uprostřed červeně
            if (stars <= 2)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else if (i < max / 2)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
            }

            for (int s = 0; s < spaces; s++)
            {
                Console.Write(" ");
            }
            for (int h = 0; h < stars; h++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
        Console.ResetColor();
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Maximum je menší než 3, obrazec se nevykreslí.");
        Console.ResetColor();
    }

    // ---------- OPAKOVÁNÍ PROGRAMU ----------

    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadKey().KeyChar.ToString();
}
