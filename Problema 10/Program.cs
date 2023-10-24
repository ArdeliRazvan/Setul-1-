using System;

int n;
Console.WriteLine("Alegeti numarul n");
Console.Write("n= ");
n = int.Parse(Console.ReadLine());
Console.WriteLine("Daca numarul tau este prim vei primi 1, daca nu este prim vei primi 0");
Console.WriteLine(verificare_prim(n));

int verificare_prim(int x)
{
    if (x < 2) return 0;
    if (x == 2) return 1;
    if (x % 2 == 0) return 0;
    for (int d = 3; d * d <= x; d = d + 2)
        if (x % d == 0)
            return 0;
    return 1;
}