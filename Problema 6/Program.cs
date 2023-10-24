using System;

int a, b, c;
Console.WriteLine("Introdu valori pentru laturile triunghiului");
Console.Write("Valoare pentru a =");
a = int.Parse(Console.ReadLine());
Console.Write("Valoare pentru b =");
b = int.Parse(Console.ReadLine());
Console.Write("Valoare pentru c =");
c = int.Parse(Console.ReadLine());

if (a < b + c && b < a + c && c < a + b)
    Console.WriteLine("Poate fi triunghi");
else Console.WriteLine("Nu poate fi triunghi");
