using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_4_1
{
    internal class Program
    {
        static int f(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else
            {
                return n + f(n - 1);
            }
        }
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Введите m: ");
                    int m = int.Parse(Console.ReadLine());

                    Console.WriteLine("Введите k: ");
                    int k = int.Parse(Console.ReadLine());

                    if (m < 1 && k < 1) throw new Exception("Оба числа введены некорректно");
                    if (m < 1) throw new Exception("Число m введено некорректно");
                    if (k < 1) throw new Exception("Число k введено некорректно");

                    int x = f(m) + f(2 * k);
                    Console.WriteLine($"Выражение = {x}");
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
