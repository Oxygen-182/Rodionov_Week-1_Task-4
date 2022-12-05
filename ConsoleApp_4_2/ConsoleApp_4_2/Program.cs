using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_4_2
{
    internal class Program
    {
        static void f(int n)
        {
            if (n % 10 == n)
            {
                Console.WriteLine(n);
            }
            if (n / 10 == 0) return;
            f(n / 10);
            Console.WriteLine(n % 10);
        }
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.Write("Введите A: ");
                    int a = int.Parse(Console.ReadLine());

                    Console.Write("Введите B: ");
                    int b = int.Parse(Console.ReadLine());

                    if (a > b) throw new Exception("Число A не может быт больше B");

                    Console.WriteLine("\nЦифры натуральных чисел из интервала (AB) в прямом порядке:\n");

                    for (int i = a; i <= b; i++)
                    {
                        f(i);
                        Console.WriteLine();
                    }

                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"{ex.Message}\n\n");
                }
            }
        }
    }
}
