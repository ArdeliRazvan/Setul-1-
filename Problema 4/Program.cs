using System;
Console.WriteLine("Scrie anul pe care vrei sa il verifici");
Console.Write("y = ");
int y = int.Parse(Console.ReadLine());
if (y % 400 == 0 || (y % 4 == 0 && y % 100 != 0))
{
    Console.WriteLine($"Anul {y} este unul bisect");
}
else
    Console.WriteLine($"Anul {y} nu este unul bisect");

