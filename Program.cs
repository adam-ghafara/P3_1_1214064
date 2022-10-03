using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_1_1214064
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N;
            Console.Write("INPUT: N -> ");
            N = int.Parse(Console.ReadLine());
            if (N > 10)
            {
                Console.WriteLine("Hanya dapat masukkan Input hingga 10");
                Console.Read();

            }
            else
            {
                Console.WriteLine($"ANAK AYAM TURUN {N}");
                for (int n = N; n >= 1; n--)
                {
                    if (n == 1)
                    {
                        Console.WriteLine($"Anak Ayam Turunlah {n}, mati satu tinggallah induknya.");
                    }
                    else
                    {
                        Console.WriteLine($"Anak Ayam Turunlah {n}, mati satu tinggallah {n - 1}.");
                    }
                }
                Console.Read();
            }
        }
    }
}
