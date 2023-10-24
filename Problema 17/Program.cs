using System;

int a, b;

Console.WriteLine("Terog scrie cele doua numere pentru care vrei sa afli cmmdc si cmmmc");
Console.Write("a = ");
a = int.Parse(Console.ReadLine());
Console.Write("b = ");
b = int.Parse(Console.ReadLine());

static int euclid(int x, int y)
{
    if (x == 0)
        return y;
    else
        return euclid(y % x, x);
}

Console.WriteLine("Cmmdc este = " + euclid(a, b));
Console.WriteLine("Cmmmc este = " + a / euclid(a, b) * b);