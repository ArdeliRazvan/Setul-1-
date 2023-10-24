using System;

string n1;
Console.WriteLine("Alegeti numarul n");
Console.Write("n= ");
n1 = Console.ReadLine();
string n2 = string.Empty;
for (int i = n1.Length - 1; i >= 0; i--)
{
    n2 += n1[i];
}
Console.WriteLine($"Inversul numarului dat este {n2}");
