using System;

int n, d;
Console.WriteLine("Alegeti valoare pentru numarul n");
Console.Write("n =");
n = int.Parse(Console.ReadLine());

for (d = 1; d <= n; d++)
{

    if (n % d == 0)

        Console.Write($"{d} ");

}