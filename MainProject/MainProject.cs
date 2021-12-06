using System;
using MainProject.Lesson_1;


namespace MainProject
{
    class MainProject
    {
        static void Main(string[] args)
        {
            //Задание 1-1
            Console.WriteLine("Задание 1");
            Console.WriteLine(Lesson1_1.IsPrime(7));
            Console.WriteLine(Lesson1_1.IsPrime(9));
            //Задание 1-3
            Console.WriteLine("Задание 3, число фибоначчи рекурсией и обычным методом");
            Console.WriteLine(Lesson1_3.GetFibonacci(10));
            Console.WriteLine(Lesson1_3.GetFibonacci2(10));
        }
    }
}
