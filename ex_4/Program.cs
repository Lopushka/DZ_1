// Без вывода "0".
Console.Write("Give give me a number_A: ");
int numderA = Convert.ToInt32(Console.ReadLine());


for (int even = 1; even <= numderA; even++)
{
    if (even % 2 == 0)
    {
        Console.WriteLine($"even numbers: {even} ");
    }
}



// если нужено вывести "0"
// Console.Write("Give give me a number_A: ");

// int numderA = Convert.ToInt32(Console.ReadLine());


// for (int even = 0; even <= numderA; even++)
// {
//     if (even % 2 == 0)
//     {
//         Console.WriteLine($"even numbers: {even} ");
//     }
// }





