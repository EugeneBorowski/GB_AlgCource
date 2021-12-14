using System;
using System.Diagnostics;

namespace GBAlgCource.Lesson3
{
    internal class Lesson3ClassStruct : ILesson
    {
        public string Name => "classStruct";
        public string Description => "3. Сравнение производительности class и struct";

        public void Demo()
        {
            CalcDistance.DoCalcDistance(100000);
            CalcDistance.DoCalcDistance(200000);
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
                CalcDistance.DoCalcDistance(n);
            }
        }

        struct PointStructDouble
        {
            public double X;
            public double Y;
        }

        class PointClassDouble
        {
            public double X;
            public double Y;
        }

        class CalcDistance
        {
            public static void DoCalcDistance(int count)
            {
                PointStructDouble[] pointStructArray = new PointStructDouble[count];
                PointClassDouble[] pointClassArray = new PointClassDouble[count];
                FillArrays(count, pointStructArray, pointClassArray);

                Console.WriteLine($"Сравнение скорости для {count} случайных элементов, вывод в тактах таймера");
                var sw = new Stopwatch();
                sw.Start();
                for (int i = 0; i < pointStructArray.Length - 1; i++)
                {
                    PointStructDistance(pointStructArray[i], pointStructArray[i + 1]);
                }

                sw.Stop();
                double structDistanceTime = sw.ElapsedTicks;

                sw.Restart();
                for (int i = 0; i < pointClassArray.Length - 1; i++)
                {
                    PointClassDistance(pointClassArray[i], pointClassArray[i + 1]);
                }

                sw.Stop();
                double classDistanceTime = sw.ElapsedTicks;
                var ratio = classDistanceTime / structDistanceTime;
                Console.WriteLine("Количество точек | PointStructDouble | PointClassDouble | Ratio");
                Console.WriteLine(string.Format("{0,-17}| {1,-18}| {2,-17}| {3:N3}", count, structDistanceTime,
                    classDistanceTime, ratio));

                void FillArrays(int count, PointStructDouble[] pointStructArray, PointClassDouble[] pointClassArray)
                {
                    var maxValue = Double.MaxValue - 1;
                    for (var i = 0; i < count; i++)
                    {
                        Random rand = new();
                        pointStructArray[i].X = rand.NextDouble() * maxValue;
                        rand = new Random();
                        pointStructArray[i].Y = rand.NextDouble() * maxValue;
                        pointClassArray[i] = new PointClassDouble();
                        rand = new Random();
                        pointClassArray[i].X = rand.NextDouble() * maxValue;
                        rand = new Random();
                        pointClassArray[i].Y = rand.NextDouble() * maxValue;
                    }
                }
            }

            static double PointStructDistance(PointStructDouble pointOne, PointStructDouble pointTwo)
            {
                double x = pointOne.X - pointTwo.X;
                double y = pointOne.Y - pointTwo.Y;
                return Math.Sqrt((x * x) + (y * y));
            }

            static double PointClassDistance(PointClassDouble pointOne, PointClassDouble pointTwo)
            {
                double x = pointOne.X - pointTwo.X;
                double y = pointOne.Y - pointTwo.Y;
                return Math.Sqrt((x * x) + (y * y));
            }
        }
    }
}