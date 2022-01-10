using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace GBAlgCource.Lesson4
{
    internal class Lesson4HashTables : ILesson
    {
        public string Name => "hash";
        public string Description => "4.2 Хэш таблицы";

        public void Demo()
        {
            Start();
        }

        public void Start()
        {
            Hash();
        }

        private static void Hash()
        {
            var rand = new Random();
            var hashSet = new HashSet<string>();
            var arrayLen = 1500000;
            var array = new string[arrayLen];
            Console.WriteLine("\n" + $"Внимание! Идет генерация большого массива из {arrayLen} значений, может показаться что система зависла");

            for (int i = 0; i < arrayLen; i++)
            {
                array[i] = GenerateString();
            }
            Console.WriteLine($"Последний элемент массива: {array[arrayLen - 1]}");

            while (hashSet.Count != arrayLen)
            {
                hashSet.Add(GenerateString());
            }
            Console.WriteLine($"Последний элемент хэша: {hashSet.Last()}");

            string GenerateString() //Генератор рандомных строк
            {
                string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                var maxLen = rand.Next(5, 70);
                var result = "";
                for (int i = 0; i < maxLen; i++)
                {
                    result += chars[rand.Next(chars.Length)];
                }
                return result;
            }

            Console.WriteLine("Введите значение для поиска в массиве: ");
            var arrSearchString = Console.ReadLine();
            bool arrSearchTrigger = false;
            bool hashSearchTrigger = false;
            var sw = new Stopwatch();
            sw.Start();
            foreach (var e in array)
                if (e == arrSearchString)
                {
                    arrSearchTrigger = true;
                    break;
                }
            sw.Stop();
            if (arrSearchTrigger == false)
                Console.WriteLine("Элемент не найден");
            Console.WriteLine("Время поиска в массиве: " + sw.Elapsed.TotalMilliseconds + "ms");
            sw.Reset();
            Console.WriteLine("Введите значение для поиска в hashSet: ");
            var hashSearchString = Console.ReadLine();
            sw.Start();
            if (hashSearchString.Contains(hashSearchString))
                hashSearchTrigger = true;
            sw.Stop();
            if (hashSearchTrigger == false)
                Console.WriteLine("Элемент не найден");
            Console.WriteLine("Время поиска в хэшсете: " + sw.Elapsed.TotalMilliseconds + "ms");
        }
    }
}