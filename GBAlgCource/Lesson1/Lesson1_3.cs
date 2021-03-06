using System;

namespace GBAlgCource
{
    internal class Lesson13Fibonacci : ILesson
    {
        public string Name => "fib";
        public string Description => "1.3 Поиск числа фибоначчи";
        public void Demo()
        {
            int n = 9;
            Console.Write($"Число фибоначчи для числа {n}: ");
            Console.WriteLine(GetFibonacci2(n));
            n = 10;
            Console.Write($"Число фибоначчи для числа {n} рекурсивным способом: ");
            Console.WriteLine(GetFibonacciRec(n));
        }
        public void Start()
        {
            Console.Write("Введите число или оставьте ввод пустым что бы запустить демо режим:");
            string input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
                Demo();
            else
            {
                var n = int.Parse(input);
                Console.Write($"Число фибоначчи для числа {n}: ");
                Console.WriteLine(GetFibonacci2(n));
                Console.Write($"Число фибоначчи для числа {n} рекурсивным способом: ");
                Console.WriteLine(GetFibonacciRec(n));
            }
        }
        /// <summary>
        /// Метод вычисления числа фибоначчи
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int GetFibonacci2(int n)
        {
            var result = 0;
            var b = 1;
            int tmp;
            for (var i = 0; i < n; i++)
            {
                tmp = result;
                result = b;
                b += tmp;
            }
            return result;
        }
        /// <summary>
        /// Метод вычисления числа фибоначчи рекурсивным способом
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int GetFibonacciRec(int n)
        {
            if (n == 0 || n == 1) return n;
            return GetFibonacciRec(n - 1) + GetFibonacciRec(n - 2);
        }
    }
}