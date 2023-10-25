using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema21;

class Program
{

    static void Main(string[] args)
    {
        Random rand = new Random();
        int guess = 0;
        string welcome = "Ma gandesc la un numar intre 1 si 1024";
        int num = rand.Next(1, 1024);
        Console.WriteLine(welcome);


        int i = 0;

        while (guess != num)
        {
            try
            {
                guess = Convert.ToInt32(Console.ReadLine());

                if (guess > num)
                {
                    Console.WriteLine($"Este {guess} prea mare");
                }
                if(guess < num)
                {
                    Console.WriteLine($"Este {guess} prea mic");
                }
            }

            catch
            {
                Console.WriteLine("Trebuie sa fie numar.");
                i--;
            }


            i++;
        }
        Console.WriteLine($"Bravo, raspunsul este {guess} , ti a {i}  incercari");
        Console.ReadLine();
    }
}