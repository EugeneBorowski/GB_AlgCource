using System;
using System.Collections.Generic;
using GBAlgCource.Lesson4;

namespace GBAlgCource.Lesson5
{
    public class Lessson5DFS : ILesson
    {
        public string Name => "dfs";
        public string Description => "5.2 Dfs search";
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

            Console.WriteLine("depth-first search value: ");
            var value = int.Parse(Console.ReadLine());
            Search(binaryTree, value);
        }
        public Node Search(Node node, int value)
        {
            var stack = new Stack<Node>();
            var tempNode = new Node(0);

            if (node.Value != null)
                stack.Push(node);
            PrintQueue(stack);

            while (stack.Count != 0)
            {
                tempNode = stack.Pop();
                if (tempNode.Value == value)
                    return tempNode;
                if(tempNode.Right != null)
                    stack.Push(tempNode.Right);
                if (tempNode.Left != null)
                    stack.Push(tempNode.Left);
                PrintQueue(stack);
            }

            return null;
            //var stack = new Stack<Node>();

            //if (node.Value != null)
            //    stack.Push(node);
            //PrintQueue(stack);
            //while (stack.Count != 0)
            //{
            //    if (stack.Peek().Value == value)
            //        return stack.Peek();
            //    else
            //    {
            //        if (stack.Peek().Right != null)
            //        {
            //            var tempNode = new Node(0);
            //            tempNode = stack.Peek().Right;
            //            stack.Push(tempNode);
            //        }
            //        if (stack.Peek().Left != null)
            //        {
            //            var tempNode = new Node(0);
            //            tempNode = stack.Peek().Left;
            //            stack.Push(tempNode);
            //        }
            //        else
            //        {
            //            while (stack.Peek().Right == null)
            //            {
            //                stack.Pop();
            //            }
            //        }
            //    }
            //    PrintQueue(stack);
            //}
            //return null;
        }
        static void PrintQueue(Stack<Node> stack)
        {
            Console.Write("Стек: ");
            foreach (var e in stack)
            {
                Console.Write(e.Value + " ");
            }
            Console.WriteLine("\n");
        }
    }
}
