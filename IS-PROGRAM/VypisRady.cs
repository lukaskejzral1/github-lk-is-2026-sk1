Console.Write("first = ");
int first = int.Parse(Console.ReadLine());

Console.Write("last = ");
int last = int.Parse(Console.ReadLine());

Console.Write("step = ");
int step = int.Parse(Console.ReadLine());

Console.WriteLine();

if (step > 0)
{
    for (int i = first; i <= last; i += step)
    {
        Console.WriteLine(i);
    }
}
else if (step < 0)
{
    for (int i = first; i >= last; i += step)
    {
        Console.WriteLine(i);
    }
}
else
{
    Console.WriteLine("Krok nesmí být 0.");
}