using System;

namespace MainProject.Lesson_1
{
    class Lesson1_1
    {
        public static string IsPrime(int number)
        {
            var d = 0;
            var i = 2;
            while (i < number)
            {
                if (number % i == 0)
                    d++;
                i++;
            }
            var result = d == 0 ? $"{number} простое" : $"{number} не простое";
            return result;
        }
    }
}