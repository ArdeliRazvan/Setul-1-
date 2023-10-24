using System;
using System.Threading.Channels;
using static System.Runtime.InteropServices.JavaScript.JSType;

int a, b, c, d, e;
Console.WriteLine("Alege cele 5 numere pe care vrei sa le ordonezi");
Console.Write("a = ");
a = int.Parse(Console.ReadLine());
Console.Write("b = ");
b = int.Parse(Console.ReadLine());
Console.Write("c = ");
c = int.Parse(Console.ReadLine());
Console.Write("d = ");
d = int.Parse(Console.ReadLine());
Console.Write("e = ");
e = int.Parse(Console.ReadLine());


static void swap(ref int a, ref int b)
{
    int tmp = a;
    a = b;
    b = tmp;
}

if (a > b)
    swap(ref a, ref b);

if (b > c)
{
    swap(ref c, ref b);

    if (a > b)
        swap(ref a, ref b);
}

if (c > d)
{
    swap(ref c, ref d);
    if (a > b)
        swap(ref a, ref b);
    if (b > c)
        swap(ref b, ref c);
    if (a > b)
        swap(ref a, ref b);
}

if (d > e)
{
    swap(ref d, ref e);
    if (c > d)
        swap(ref c, ref d);
    if (b > c)
        swap(ref b, ref c);
    if (a > b)
        swap(ref a, ref b);

}
Console.WriteLine($"{a}, {b}, {c}, {d}, {e}");