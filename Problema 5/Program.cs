using System;

Console.WriteLine("Introdu numarul n si a catea cifra este k");
Console.Write("n = ");
string n1 = (Console.ReadLine());
Console.Write("k = ");
int k = int.Parse(Console.ReadLine());

string n2 = string.Empty;
for (int i = n1.Length - 1; i >= 0; i--)
{
    n2 += n1[i];
}

Console.WriteLine($"Numarul de pe pozitia {k} este {n2[k]}");