using System;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> newStack = new Stack<string>();
            newStack.IsEmpty();
            newStack.Push("5");
            newStack.Push("Hello");
            newStack.Push("heya");
            newStack.Pop();
            newStack.Peek();
            newStack.Display();
            Console.WriteLine("##########################");
            SinglyLinkedList<int> newSll = new SinglyLinkedList<int>();
            newSll.Add(5);
            newSll.Add(6);
            newSll.Add(7);
            newSll.Add(3);
            newSll.Add(5);
            newSll.Delete(5);
            newSll.Display();



        }
    }
}
