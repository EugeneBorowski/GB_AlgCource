using System;

namespace GBAlgCource
{
    internal class Lesson11PrimeNumbers : ILesson
    {
        public string Name => "prime";
        public string Description => "1.1 Поиск простого числа";
        public void Demo()
        {
            int n = 7;
            Console.WriteLine($"Является ли {n} простым числом?");
            Console.WriteLine(IsPrime(n));
            n = 9;
            Console.WriteLine($"Является ли {n} простым числом?");
            Console.WriteLine(IsPrime(n));
        }

        public void Start()
        {
            Console.Write("Введите число или оставьте ввод пустым что бы запустить демо режим:");
            var input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
                Demo();
            else
            {
                var n = int.Parse(input);
                Console.WriteLine($"Является ли {n} простым числом?");
                Console.WriteLine(IsPrime(n));
            }
        }
        /// <summary>
        /// Метод вычисления простого числа
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        private static string IsPrime(int number)
        {
            var d = 0;
            var i = 2;
            while (i < number)
            {
                if (number % i == 0)
                    d++;
                i++;
            }
            var result = d == 0 ? $"Число {number} простое" : $"Число {number} не простое";
            return result;
        }
    }
}