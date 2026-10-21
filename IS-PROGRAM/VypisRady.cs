string again = "a";

// Řídící cyklus programu
// ToLower() --> převede na LowerCase 
// Jakýkoliv jiný vstup programu ukončí
while (again.ToLower() == "a")
{

    Console.Clear();

    // Hlavička programu
    Console.WriteLine("************************************************************");
    Console.WriteLine("************************Výpis řady**************************");
    Console.WriteLine("************************************************************");
    Console.WriteLine("***********************Lukáš Kejzral************************");
    Console.WriteLine("************************************************************");

    //Vstup počáteční hodnoty
    Console.Write("Zadejte PRVNÍ číslo číselné řady (kladné celé číslo): ");
    int first;
    while (!int.TryParse(Console.ReadLine(), out first) || first <= 0)
    {
        Console.Write("Nezadali jste kladné celé číslo. Zadejte PRVNÍ číslo řady znovu: ");
    }

    //Vstup konečné hodnoty
    Console.Write("Zadejte POSLEDNÍ číslo číselné řady (kladné celé číslo): ");
    int last;
    while (!int.TryParse(Console.ReadLine(), out last) || last <= 0 || last < first)
    {
        Console.Write("Zadejte kladné celé číslo, které není menší než první číslo. Zadejte POSLEDNÍ číslo řady znovu: ");
    }

    //Vstup hodnoty kroku
    Console.Write("Zadejte diferenci (kladné celé číslo): ");
    int step;
    while (!int.TryParse(Console.ReadLine(), out step) || step <= 0)
    {
        Console.Write("Nezadali jste kladné celé číslo. Zadejte diferenci znovu: ");
    }

    //Výpis číselné řady
    Console.WriteLine();
    Console.WriteLine("Číselná řada:");
    for (int i = first; i <= last; i += step)
    {
        Console.Write(i);
        if (i + step <= last)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine();

    //dotaz 
    Console.WriteLine();
    Console.Write("Pokud chcete pokračovat v programu stiskněte klávesu A. Následně potvrďte klávesou ENTER.: ");
    again = Console.ReadLine() ?? "";
}
