using System;
using System.Collections.Generic;

namespace GB_AlgCource
{
    class Program
    {
        static List<ILesson> _lessons = new()
        {
            new Lesson1PrimeNumbers(),
            new Lesson2StrangeSum(),
            new Lesson3Fibonacci()
        };

        static void Main()
        {
            Console.WriteLine("Введите код задания для его запуска:");
            foreach (ILesson lesson in _lessons)
            {
                Console.WriteLine(string.Format($"Код:{lesson.Name,-10} ({lesson.Description})"));
            }

        }
    }
}
