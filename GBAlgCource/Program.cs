using System;
using System.Collections.Generic;

namespace GBAlgCource
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
            Console.WriteLine("Скисок доступных заданий:");
            foreach (ILesson lesson in _lessons)
            {
                Console.WriteLine(string.Format($"Код:{lesson.Name,-10} ({lesson.Description})"));
            }

            Console.Write("Введите код задания для его запуска: ");
            var startLessonName = Console.ReadLine();

            foreach (ILesson lesson in _lessons)
            {
                if (lesson.Name == startLessonName)
                    lesson.Start();
            }
        }
    }
}
