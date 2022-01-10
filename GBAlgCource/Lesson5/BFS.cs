using System;
using System.Collections.Generic;
using GBAlgCource.Lesson4;

namespace GBAlgCource.Lesson5
{
    public class Lessson5BFS : ILesson
    {
        public string Name => "bfs";
        public string Description => "5.1 Bfs search";
        public void Demo()
        {
            Start();
        }

        public void Start()
        {
            var rand = new Random();
            var binaryTree = new Node(0);
            const int maxValue = 99;
            var maxCount = 10;
            for (int i = 1; i < maxCount; i++)
            {
                binaryTree.AddItem(rand.Next(maxValue));
            }

            Console.WriteLine("Сгенеренное дерево");
            binaryTree.PrintTree(0);
            Console.CursorLeft = 0;
            Console.CursorTop = +20;

            Console.WriteLine("breadth-first search value: ");
            var value = int.Parse(Console.ReadLine());
            Search(binaryTree, value);
            Console.ReadLine();
        }
        public Node Search(Node node, int value)
        {
            var queue = new Queue<Node>();

            if (node.Value != null)
                queue.Enqueue(node);
            PrintQueue(queue);
            while (queue.Count != 0)
            {
                if (queue.Peek().Value == value)
                {
                    //Console.Clear();
                    Console.WriteLine("Результат поиска в ширину:");
                    queue.Peek().PrintTree(0);
                    return queue.Peek();
                }

                if (queue.Peek().Left != null)
                {
                    var tempNode = new Node(0);
                    tempNode = queue.Peek().Left;
                    queue.Enqueue(tempNode);
                }

                if (queue.Peek().Right != null)
                {
                    var tempNode = new Node(0);
                    tempNode = queue.Peek().Right;
                    queue.Enqueue(tempNode);
                }

                queue.Dequeue();
                PrintQueue(queue);
            }
            Console.WriteLine("Элемент не найден");
            return null;
        }

        static void PrintQueue(Queue<Node> queue)
        {
            Console.Write("Очередь: ");
            foreach (var e in queue)
            {
                Console.Write(e.Value + " ");
            }

            Console.WriteLine("\n");
        }
    }
}