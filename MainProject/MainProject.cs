using System;
using System.Threading.Channels;
using MainProject.Lesson_1;


namespace MainProject
{
    class MainProject
    {
        static void Main()
        {
            //Задание 1-1
            Console.WriteLine("Задание 1");
            Console.WriteLine(Lesson1_1.IsPrime(7));
            Console.WriteLine(Lesson1_1.IsPrime(9));
            //Задание 1-2
            Console.WriteLine("Задание 2, сложность O(N^3)");
            var l1_2 = new[] { 1, 2, 3, 4, 5 };
                Console.WriteLine(Lesson1_2.StrangeSum(l1_2));
            //Задание 1-3
            Console.WriteLine("Задание 3, число фибоначчи рекурсией и обычным методом");
            Console.WriteLine(Lesson1_3.GetFibonacci(10));
            Console.WriteLine(Lesson1_3.GetFibonacci2(10));
        }
    }
}
