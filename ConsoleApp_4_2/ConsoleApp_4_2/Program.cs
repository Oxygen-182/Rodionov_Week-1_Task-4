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
                Console.Write(n + " ");
            }
            if (n / 10 == 0) return;
            f(n / 10);
            Console.Write(n % 10 + " ");
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

                    if (a > b) throw new Exception("Число A не может быть больше B");
                    if (a <= 0 && b <= 0) throw new Exception("Числа не могут иметь значения меньше или равные нулю");
                    if (a <= 0) throw new Exception("Число A не может иметь значение меньше или равное нулю");
                    if (b <= 0) throw new Exception("Число B не может иметь значение меньше или равное нулю");

                    Console.WriteLine("\nЦифры натуральных чисел из интервала (AB) в прямом порядке:\n");

                    for (int i = a; i <= b; i++)
                    {
                        f(i);
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
