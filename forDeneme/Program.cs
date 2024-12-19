/* APPLICATION 1
using System;

namespace forExample1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");
            }
        }
    }
}
*/

//-------------------------------------------------------------------------------------------------

/* APLICATION 2
using System;
namespace forExample2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
*/

//-------------------------------------------------------------------------------------------------

/* APLICATION 3
using System;
namespace forExample3
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 20; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine($"{i} çift sayıdır.");
                }
            }
        }
    }
}
*/

//-------------------------------------------------------------------------------------------------

/* APLICATION 4

using System;
namespace forExample4
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 50;
            int y = 150;
            int toplam = 0;
            for (int i = x; i <= y; i++)
            {
                toplam += i;
            }
            Console.WriteLine($"Toplam: {toplam}");
        }
    }
}
*/

//-------------------------------------------------------------------------------------------------

/* APLICATION 5
using System;
namespace forExample5
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            int y = 120;
            int ciftToplam = 0;
            int tekToplam = 0;
            for (int i = x; i <= y; i++)
            {
                if (i % 2 == 0)
                    ciftToplam += i;
                else 
                    tekToplam += i;
            }
            Console.WriteLine($"1 ile 120 arasındaki çift sayıların toplamı: {ciftToplam}");
            Console.WriteLine($"1 ile 120 arasındaki tek sayıların toplamı: {tekToplam}");

        }
    }
}
*/