using System;
Console.WriteLine("Introdu numarul n si numarul k");
Console.Write("n = ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("k = ");
int k = int.Parse(Console.ReadLine());

if (n % k == 0)
    Console.WriteLine($"Numarul {n} se divide cu {k}");
else Console.WriteLine($"Numarul {n} nu se divide cu {k}");

