using DataStructures.LinkedList.DoublyLinkedList;
using DataStructures.LinkedList.SinglyLinkedList;
using System.Collections;

namespace Apps
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }

        private static void StackApp()
        {
            var charset = new char[] { 'a', 'b', 'c', 'd', 'e' };
            var stack1 = new DataStructures.Stack.Stack<char>();
            var stack2 = new DataStructures.Stack.Stack<char>();
            foreach (char c in charset)
            {
                Console.WriteLine(c);
                stack1.Push(c);
                stack2.Push(c);
            }
            Console.WriteLine("Peek");
            Console.WriteLine($"Stack1:{stack1.Peek()}");
            Console.WriteLine($"Stack2:{stack2.Peek()}");

            Console.WriteLine("\nCount");
            Console.WriteLine($"Stack1:{stack1.Count}");
            Console.WriteLine($"Stack2:{stack2.Count}");


            Console.WriteLine("\nPop");
            Console.WriteLine($"Stack1:{stack1.Pop()} has been removed");
            Console.WriteLine($"Stack2:{stack2.Pop()} has been removed");
        }

        private static void DbLinkedListApp()
        {
            var list = new DoublyLinkedList<int>();
            list.AddFirst(1);
            list.AddFirst(2);

            list.AddLast(11);
            list.AddLast(22);

            list.AddAfter(list.Head.Next, new DoublyLinkedListNode<int>(13));

            Console.WriteLine();
        }

        private static void SinglyLinkedListApp()
        {
            var linkedList = new SinglyLinkedList<int>();
            linkedList.AddFirst(1);
            linkedList.AddFirst(2);
            linkedList.AddFirst(3);

            linkedList.AddLast(4);
            linkedList.AddLast(5);

            linkedList.AddAfter(linkedList.Head.Next, 32);
            linkedList.AddAfter(linkedList.Head.Next.Next, 33);
        }
    }
}
