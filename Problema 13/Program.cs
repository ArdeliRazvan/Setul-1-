using System;

int y1, y2, k = 0;
Console.WriteLine("Alegeti intervalul de ani");
Console.Write("y1 = ");
y1 = int.Parse(Console.ReadLine());
Console.Write("y2 = ");
y2 = int.Parse(Console.ReadLine());

for (int i = y1; i <= y2; i++)
{
    if ((i % 400 == 0) || (i % 4 == 0 && i % 100 != 0))
        k++;
}
Console.WriteLine($"Intre ani {y1} si {y2} sunt {k} ani bisecti");