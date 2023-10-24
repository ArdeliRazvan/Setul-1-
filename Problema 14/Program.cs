using System;

int n, rev, sum = 0, aux;
Console.Write("Scrie un numar ");
n = int.Parse(Console.ReadLine());
aux = n;

while (n > 0)
{
    rev = n % 10;
    sum = (sum * 10) + rev;
    n = n / 10;
}

if (aux == sum)
    Console.Write("Numarul este palindrom");
else
    Console.Write("Numarul nu este palindrom");