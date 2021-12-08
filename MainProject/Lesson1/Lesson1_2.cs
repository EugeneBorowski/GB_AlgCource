﻿using System;

namespace GB_AlgCource
{
    internal class Lesson2StrangeSum : ILesson
    {
        public string Name => "strSum";
        public string Description => "1.2 Поиск странной суммы чисел";
        public void Demo()
        {
            var array = new[] { 1, 2, 3, 4, 5 };
            Console.WriteLine($"Странный метод вычисления суммы чисел {string.Join(' ',array)}");
            Console.WriteLine($"Сумма чисел: {StrangeSum(array)}");
        }
        public void Start(string input)
        {

        }
        /// <summary>
        /// Метод вычисления странной суммы
        /// </summary>
        /// <param name="inputArray"></param>
        /// <returns></returns>
        public static int StrangeSum(int[] inputArray)
        {
            int sum = 0;
            for (int i = 0; i < inputArray.Length; i++)
            {
                for (int j = 0; j < inputArray.Length; j++)
                {
                    for (int k = 0; k < inputArray.Length; k++)
                    {
                        int y = 0;

                        if (j != 0)
                        {
                            y = k / j;
                        }

                        sum += inputArray[i] + i + k + j + y;
                    }
                }
            }
            return sum;
        }
    }
}