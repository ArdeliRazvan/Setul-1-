using System;

int a, b;
Console.WriteLine("Alege valorile lui a si b");
Console.Write("a =");
a = int.Parse(Console.ReadLine());
Console.Write("b =");
b = int.Parse(Console.ReadLine());
a = a + b;
b = a - b;
a = a - b;

Console.WriteLine($"Programul a facut swap a={a}  b={b} ");