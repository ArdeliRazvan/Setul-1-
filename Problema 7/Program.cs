using System;

int a, b, c;
Console.WriteLine("Alege valorile lui a si b");
Console.Write("a =");
a = int.Parse(Console.ReadLine());
Console.Write("b =");
b = int.Parse(Console.ReadLine());
c = a;
a = b;
b = c;
Console.WriteLine($"Programul a facut swap a={a}  b={b} ");