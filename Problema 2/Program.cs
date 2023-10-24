using System;

int a, b, c;

double d, x1, x2;

Console.WriteLine("Atribuie valori lui a , b si c");
a = int.Parse(Console.ReadLine());
b = int.Parse(Console.ReadLine());
c = int.Parse(Console.ReadLine());
Console.WriteLine($"a = {a}, b = {b} si c = {c}");

d = b * b - 4 * a * c;

if (d == 0)
{
    Console.WriteLine("Radacinile sunt egale");
    x1 = -b / (2.0 * a);
    x2 = x1;
    Console.WriteLine($"Radacinile x1 = x2 = {x1}");
}
else if (d > 0)
{
    Console.WriteLine("Ambele radacini sunt reale si distincte");
    x1 = (-b + Math.Sqrt(d)) / (2 * a);
    x2 = (-b - Math.Sqrt(d)) / (2 * a);
    Console.WriteLine($"Radacinile sunt x1 = {x1} si x2 = {x2}");
}
else if (d < 0)
    Console.WriteLine("Radacinile sunt imaginare deci raspunsul este 42 :)");