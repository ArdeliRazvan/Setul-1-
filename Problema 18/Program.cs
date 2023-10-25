using System.Threading.Channels;

int n, d = 2, p=0, k = 0;
Console.WriteLine("Introdu numarul pe care vrei sa-l descompui in factori primi");
n = int.Parse(Console.ReadLine());

     
        while (n > 1)
        {
            p = 0;
            while (n % d == 0)
            {
                p++;
                n /= d;
                k++;
            }

             if (p > 0)
             {
                Console.Write($"{d}^{p} x ");
             }           
             
             d++;
            if (n > 1 && d * d > n)
            {
                d = n;
            }
        }
