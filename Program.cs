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
            Console.WriteLine($"ANAK AYAM TURUN {N}");
            for (int n = N; n >= 1; n--)
            {
                for (int n2 = N; n2 >= 1; n2--)
                    {
                        Console.WriteLine($"Anak Ayam Turunlah {n}, mati satu tinggallah {n2}. "); break;
                    }
            }
            Console.Read();
        }
    }
}
