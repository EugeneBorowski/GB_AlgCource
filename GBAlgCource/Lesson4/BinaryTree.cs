using System;

namespace GBAlgCource.Lesson4
{
    public class Lesson4BinaryTree : ILesson
    {
        public string Name => "binaryTree";
        public string Description => "4.1 Бинарное дерево";
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

            Console.WriteLine("Сгенеренная нода");
            binaryTree.PrintTree(0);

            Console.CursorLeft = 0;
            Console.CursorTop = +20;
            Console.WriteLine("Найти ноду со значением: ");
            var tempNode = binaryTree.GetNodeByValue(int.Parse(Console.ReadLine()));
            tempNode.PrintTree(0);

            Console.CursorLeft = 0;
            Console.CursorTop = +30;
            Console.WriteLine("Удалить ноду со значением: ");
            binaryTree.RemoveItem(int.Parse(Console.ReadLine()));
            Console.CursorLeft = 0;
            Console.CursorTop = +32;
            binaryTree.PrintTree(0);

            Console.ReadLine();
        }
    }
}