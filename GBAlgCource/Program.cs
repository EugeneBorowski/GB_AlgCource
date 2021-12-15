using System;
using System.Collections.Generic;
using GBAlgCource.Lesson3;

namespace GBAlgCource
{
    class Program
    {
        static List<ILesson> _lessons = new()
        {
            new Lesson11PrimeNumbers(),
            new Lesson12StrangeSum(),
            new Lesson13Fibonacci(),
            new Lesson3ClassStruct()
        };

        static void Main()
        {
            Console.WriteLine("Скисок доступных заданий:");
            foreach (ILesson lesson in _lessons)
            {
                Console.WriteLine(string.Format($"Код:{lesson.Name,-12} ({lesson.Description})"));
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
