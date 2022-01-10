using System;
using GBAlgCource.Lesson4.Interface;

namespace GBAlgCource.Lesson4
{
    public class Node : ITree
        {
            public int? Value { get; set; }
            public Node Left { get; set; }
            public Node Right { get; set; }

            public Node(int value)
            {
                Value = null;
                Left = Right = null;
            }

            public void AddItem(int value)
            {
                if (Value == null)
                    Value = value;
                else
                {
                    if (Value > value)
                    {
                        if (Left == null)
                            Left = new Node(0);
                        Left.AddItem(value);
                    }
                    else if (Value < value)
                    {
                        if (Right == null)
                            Right = new Node(0);
                        Right.AddItem(value);
                    }
                    else
                    {
                        var rand = new Random();
                        Console.WriteLine($"Нода со значением {value} уже существует,");
                        var newValue = rand.Next(99);
                        Console.WriteLine($"Будет создана новая нода со значением {newValue}");
                        AddItem(newValue);
                    }
                }
            }
            public void RemoveItem(int value)
            {
                if (Value == null)
                    return;
                if (Value > value)
                    if (Left == null)
                        return;
                    else if (Left.Value == value)
                        Left = null;
                    else
                        Left.RemoveItem(value);
                if (Value < value)
                    if (Right == null)
                        return;
                    else if (Right.Value == value)
                        Right = null;
                    else
                        Right.RemoveItem(value);
            }
            public Node GetNodeByValue(int value)
            {
                if (Value == null)
                    return null;
                switch (Value.Value.CompareTo(value))
                {
                    case 1: return Left.GetNodeByValue(value);
                    case -1: return Right.GetNodeByValue(value);
                    case 0: return this;
                    default: return null;
                }
            }
            public void PrintTree(int baseLevel)
            {
                if (baseLevel == 0)
                    if (Value != null)
                    {
                        Console.CursorLeft = Console.WindowWidth / 2 - Value.Value.ToString().Length / 2;
                        DrawValue(Value);
                    }

                if (Left != null)
                {
                    var currCursor = Console.GetCursorPosition();
                    baseLevel++;
                    DrawLeft();
                    Left.PrintTree(baseLevel);
                    Console.SetCursorPosition(currCursor.Left, currCursor.Top);
                    baseLevel--;
                }

                if (Right != null)
                {
                    var currCursor = Console.GetCursorPosition();
                    baseLevel++;
                    DrawRight();
                    Right.PrintTree(baseLevel);
                    Console.SetCursorPosition(currCursor.Left, currCursor.Top);
                }

                void DrawLeft()
                {
                    Console.CursorLeft -= Value.ToString().Length + Left.Value.ToString().Length + 3;
                    Console.CursorTop += 2;
                    DrawValue(Left.Value);
                    var currCursor = Console.GetCursorPosition();
                    Console.CursorTop--;
                    Console.Write("/");
                    Console.CursorTop--;
                    Console.Write("__");
                    Console.SetCursorPosition(currCursor.Left, currCursor.Top);
                }
                void DrawRight()
                {
                    Console.Write("___");
                    Console.CursorTop++;
                    Console.Write("\\");
                    Console.CursorTop++;
                    DrawValue(Right.Value);
                }
                void DrawValue(int? value)
                {
                    Console.Write($"{value}");
                }
            }
        }
}
