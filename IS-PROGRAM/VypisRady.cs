int ReadInt(string name)
{
    while (true)
    {
        Console.Write($"{name} = ");
        if (int.TryParse(Console.ReadLine(), out int value))
            return value;
        Console.WriteLine("Neplatné číslo, zkuste to znovu.");
    }
}

int first = ReadInt("first");
int last = ReadInt("last");

int step = ReadInt("step");
while (step == 0)
{
    Console.WriteLine("Krok nesmí být 0.");
    step = ReadInt("step");
}

Console.WriteLine();

if (step > 0)
{
    for (long i = first; i <= last; i += step)
        Console.WriteLine(i);
}
else
{
    for (long i = first; i >= last; i += step)
        Console.WriteLine(i);
}