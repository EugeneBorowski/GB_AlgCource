using System;
using System.Text;
using GBAlgCource.Lesson2.Interface;

namespace GBAlgCource.Lesson2
{
    internal class Lesson2LinkedList : ILesson
    {
        public string Name => "linkedList";
        public string Description => "2. Двусвязный список";

        public void Demo()
        {
            Start();
        }

        public void Start()
        {
            var nodeSize = 10;
            var list = new LinkedList();
            for (var i = 1; i <= nodeSize; i++)
                list.AddNode(i);
            Console.WriteLine($"Размер списка: {list.GetCount()}");
            list.Print();
            Console.WriteLine("Добавление цифры 12 после 3 позиции");
            list.AddNodeAfter(list.FindNode(3), 12);
            list.Print();
            Console.WriteLine("Удаляем 1 позицию в списке");
            list.RemoveNode(1);
            list.Print();
        }

        public class LinkedList : ILinkedList
        {
            private Node FirstNode;
            private Node LastNode;

            public int GetCount()
            {
                if (FirstNode != null) //если нода пустая
                {
                    var i = 1; //+1 за первую ноду
                    if (FirstNode.NextNode == null)
                        return i;
                    var node = FirstNode.NextNode;
                    while (node.NextNode != null)
                    {
                        node = node.NextNode;
                        i++;
                    }

                    return ++i; //+1 за последнюю ноду
                }

                return 0;
            }

            public void AddNode(int value)
            {
                var newNode = new Node { Value = value };
                if (FirstNode == null) //Чек на первую ноду
                {
                    FirstNode = newNode;
                    LastNode = newNode;
                    return;
                }

                if (LastNode == null) //Чек на вторую ноду
                {
                    newNode.PrevNode = FirstNode;
                    FirstNode.NextNode = newNode;
                    LastNode = newNode;
                    return;
                }
                else //добавление в конец
                {
                    LastNode.NextNode = newNode;
                    newNode.PrevNode = LastNode;
                    LastNode = newNode;
                }
            }

            public void AddNodeAfter(Node node, int value)
            {
                if (node.NextNode == null) //Если нода пустая, просто добавляем
                {
                    AddNode(value);
                }
                else
                {
                    var newNode = new Node
                    {
                        Value = value,
                        NextNode = node.NextNode,
                        PrevNode = node
                    };
                    node.NextNode.PrevNode = newNode;
                    node.NextNode = newNode;
                }
            }

            public void RemoveNode(int index)
            {
                var node = FirstNode;
                var i = 1;
                while (index > i)
                {
                    if (node == null)
                        break;
                    node = node.NextNode;
                    i++;
                }

                if (node != null)
                    RemoveNode(node);
            }

            public void RemoveNode(Node node)
            {
                if (node.PrevNode == null) //если первый
                {
                    var newNode = node.NextNode;
                    newNode.PrevNode = null;
                    FirstNode = newNode;
                }
                else if (node.NextNode == null) //если последний
                {
                    var newNode = node.PrevNode;
                    newNode.NextNode = null;
                    LastNode = newNode;
                }
                else
                {
                    node.PrevNode.NextNode = node.NextNode;
                    node.NextNode.PrevNode = node.PrevNode;
                }
            }

            public Node FindNode(int searchValue)
            {
                var node = FirstNode;
                while (node != null)
                {
                    if (node.Value == searchValue)
                        return node;
                    node = node.NextNode;
                }

                return null;
            }

            public void Print()
            {
                if (FirstNode == null) return;

                var separator = "=";
                var sb = new StringBuilder();
                sb.Append(FirstNode.Value);
                var node = FirstNode;

                while (node.NextNode != null)
                {
                    node = node.NextNode;
                    sb.Append(separator + node.Value);
                }

                Console.WriteLine("Состав списка:");
                Console.WriteLine(sb.ToString() + "\n");
            }
        }
    }
}