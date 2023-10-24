using System;

int a, b, d, n, k = 0, aux;

Console.WriteLine("Alegeti capetele intervalului cu conditia a<b");
Console.Write("a = ");
a = int.Parse(Console.ReadLine());
Console.Write("b = ");
b = int.Parse(Console.ReadLine());
Console.WriteLine("Alege n-ul");
Console.Write("n = ");
n = int.Parse(Console.ReadLine());
if (a > b)
{
    aux = a;
    a = b;
    b = aux;

}
for (int i = a; i <= b; i++)
{
    if (i % n == 0)
        k++;
}
Console.WriteLine($"Ai gasit {k} numere intregi divizibile cu {n}");
