using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Задание_23
{
    //Разработать асинхронный метод для вычисления факториала числа. В методе Main выполнить проверку работы метода.
    class Program
    {
        static void Factorial(int n)
        {
            Console.WriteLine("Factorial начал работу");
            int nF = 1;
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = i + 1;
                nF = nF * array[i];
                Console.WriteLine($"{array[i]}! = {nF}");
                Thread.Sleep(100);
            }
            Console.WriteLine($"Факториал введенного числа: {n}! = {nF}");
            Console.WriteLine("Factorial окончил работу");
        }
        static void NumberSquare(int n)
        {
            Console.WriteLine("NumberSquare начал работу");
            int nS = 0;
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = i + 1;
                nS = array[i] * array[i];
                Console.WriteLine($"{array[i]}*{array[i]} = {nS}");
                Thread.Sleep(100);
            }
            Console.WriteLine($"Квадрат введенного числа: {n}*{n} = {nS}");
            Console.WriteLine("NumberSquare окончил работу");
        }
        static async Task FactorialAsync(int n)
        {
            Console.WriteLine("FactorialAsync начал работу");
            await Task.Run(() => Factorial(n));
            Console.WriteLine("FactorialAsync окончил работу");
        }
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите целое неотрицательное число:");
                int n = Convert.ToInt32(Console.ReadLine());
                FactorialAsync(n);
                NumberSquare(n);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("Main окончил работу");
            Console.ReadKey();
        }
    }
}
