using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ex23
{
    class Program
    {
        //Разработать асинхронный метод для вычисления факториала числа.
        //В методе Main выполнить проверку работы метода.
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число для вычисления его факториала");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.Write("!{0} = ", n);
            FactorialAsync(n);
            Console.ReadKey();
        }

        static void Factorial(int n)
        {
            int s = 1;
            for (int i = 1; i <= n; i++)
            {
                s *= i;
                Thread.Sleep(50);
            }
            Console.WriteLine(s);
        }

        static async void FactorialAsync(int n)
        {
            await Task.Run(() => Factorial(n));
        }
    }
}
