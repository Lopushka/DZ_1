Console.Write("\nGive give me a number_A: ");
int numderA = Convert.ToInt32(Console.ReadLine());
Console.Write("\nGive give me a number_B: ");
int numderB = Convert.ToInt32(Console.ReadLine());
Console.Write("\nGive give me a number_С: ");
int numderС = Convert.ToInt32(Console.ReadLine());
int MaxNamder = numderA;

if (numderB > MaxNamder)

    MaxNamder = numderB;

if (numderС > MaxNamder)

    MaxNamder = numderС;

Console.WriteLine($"\nMax: {MaxNamder}");