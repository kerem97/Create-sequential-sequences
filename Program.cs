using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    class Program
    {
        static void Main(string[] args)
        {
            Random uret = new Random();
            int[] dizi = new int[10];
            int tmp;
            for (int i = 0; i < 10; i++)
            {
                dizi[i] = uret.Next(500);
                Console.Write(" " + dizi[i]);

                for (int k = 0; k < 10 - 1; k++)
                {
                    if (dizi[i] < dizi[k])
                    {
                        tmp = dizi[i];
                        dizi[i] = dizi[k];
                        dizi[k] = tmp;
                    }
                }
            }                                                   
            Console.WriteLine("\n\n Sıralı Dizi \n");
            for (int i = 0; i < 10; i++)
            {
                Console.Write("\t {0} ", dizi[i]);
            }            
            Console.ReadKey();
        }
    }
}
