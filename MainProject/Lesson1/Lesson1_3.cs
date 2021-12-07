using System;

namespace MainProject.Lesson_1
{
    public class Lesson1_3
    {
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

        public static int GetFibonacci(int n)
        {
            if (n == 0 || n == 1) return n;
            return GetFibonacci(n - 1) + GetFibonacci(n - 2);
        }
    }
}