using System;
Console.WriteLine("ax + b = 0");
Console.Write("a = ");
int a = int.Parse(Console.ReadLine());
Console.Write("b = ");
int b = int.Parse(Console.ReadLine());
if (a == 0 && b != 0)
{
    Console.Write("Caz de nedeterminare");
}
else
{
    float x = (float)-b / a;
    Console.WriteLine($"x = {x}");
}