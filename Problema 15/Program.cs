using System;
using System.Threading.Channels;

int a, b, c;
Console.WriteLine("Alege cele 3 numere pe care vrei sa le ordonezi");
Console.Write("a = ");
a = int.Parse(Console.ReadLine());
Console.Write("b = ");
b = int.Parse(Console.ReadLine());
Console.Write("c = ");
c = int.Parse(Console.ReadLine());

int[] vec = new int[3] { a, b, c };

Array.Sort(vec);
Console.Write("Numerele tale ordonate sunt ");
for (int i = 0; i < vec.Length; i++)
{
    Console.Write(vec[i] + " ");
}