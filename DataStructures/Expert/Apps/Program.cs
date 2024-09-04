using DataStructures.LinkedList.DoublyLinkedList;
using DataStructures.LinkedList.SinglyLinkedList;
using DataStructures.Tree.BinarySearchTree;
using DataStructures.Tree.BinaryTree;
using System.Collections;

namespace Apps
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FindMinAndMaxValue();
        }

        private static void FindMinAndMaxValue()
        {
            var BST = new BinarySearchTree<int>(new int[] { 23, 16, 45, 3, 22, 37, 99 });
            new BinaryTree<int>().InOrder(BST.Root).ForEach(node => Console.Write(node + " "));
            Console.WriteLine();

            Console.WriteLine($"Minimum value :{BST.FindMin(BST.Root)}");
            Console.WriteLine($"Maximum value :{BST.FindMax(BST.Root)}");
        }

        private static void LevelOrderNonRecursiveTraversal()
        {
            var BST = new BinarySearchTree<int>(new int[] { 23, 16, 45, 3, 22, 37, 99 });
            var bt = new BinaryTree<int>();

            bt.PreOrder(BST.Root)
                .ForEach(node => Console.Write($"{node,-3} "));

            Console.WriteLine();

            bt.PreOrderNonRecursiveTraversal(BST.Root)
                .ForEach(node => Console.Write($"{node,-3} "));

            Console.WriteLine();


            bt.LevelOrderNonRecursiveTraversal(BST.Root)
                .ForEach(node => Console.Write($"{node,-3} "));
        }

        private static void PreOrderNonRecursiveApp()
        {
            var BST = new BinarySearchTree<int>(new int[] { 23, 16, 45, 3, 22, 37, 99 });
            var bt = new BinaryTree<int>();

            bt.PreOrder(BST.Root)
                .ForEach(node => Console.Write($"{node,-3} "));

            Console.WriteLine();

            bt.PreOrderNonRecursiveTraversal(BST.Root)
                .ForEach(node => Console.Write($"{node,-3} "));
        }

        private static void InOrderNonRecursiveApp()
        {
            var BST = new BinarySearchTree<int>(new int[] { 23, 16, 45, 3, 22, 37, 99 });
            var bt = new BinaryTree<int>();

            bt.InOrder(BST.Root).ForEach(node => Console.Write($"{node,-3} "));

            Console.WriteLine();
            bt.InOrderNonRecursiveTraversal(BST.Root)
                .ForEach(node => Console.Write($"{node,-3} "));
        }

        private static void PostOrderApp()
        {
            var BST = new BinarySearchTree<int>(new int[] { 23, 16, 45, 3, 22, 37, 99 });
            var bt = new BinaryTree<int>();

            bt.InOrder(BST.Root).ForEach(node => Console.Write($"{node,-3} "));

            Console.WriteLine();
            bt.ClearList();

            bt.PreOrder(BST.Root).ForEach(node => Console.Write($"{node,-3} "));

            Console.WriteLine();
            bt.ClearList();

            bt.PostOrder(BST.Root).ForEach(node => Console.Write($"{node,-3} "));
        }

        private static void PreOrderApp()
        {
            var BST = new BinarySearchTree<int>(new int[] { 23, 16, 45, 3, 22, 37, 99 });
            new BinaryTree<int>().InOrder(BST.Root).ForEach(node => Console.Write(node + " "));

            Console.WriteLine();

            new BinaryTree<int>().PreOrder(BST.Root).ForEach(node => Console.Write(node + " "));
        }

        private static void InOrderApp()
        {
            var BST = new BinarySearchTree<int>(new int[] { 23, 16, 45, 3, 22, 37, 99 });
            new BinaryTree<int>().InOrder(BST.Root).ForEach(node => Console.Write(node + " "));
        }

        private static void QueueApp()
        {
            var numbers = new int[] { 10, 20, 30 };
            var q1 = new DataStructures.Queue.Queue<int>();
            var q2 = new DataStructures.Queue.Queue<int>(DataStructures.Queue.QueueType.LinkedList);

            foreach (int num in numbers)
            {
                Console.WriteLine(num);
                q1.EnQueue(num);
                q2.EnQueue(num);
            }

            Console.WriteLine($"q1 Count: {q1.Count}");
            Console.WriteLine($"q2 Count: {q2.Count}");

            Console.WriteLine($"q1 Peek: {q1.Peek()}");
            Console.WriteLine($"q2 Peek: {q2.Peek()}");

            Console.WriteLine($"q1 DeQueue: {q1.DeQueue()} has been removed from q1");
            Console.WriteLine($"q2 DeQueue: {q2.DeQueue()} has been removed from q2");

            Console.WriteLine($"q1 Count: {q1.Count}");
            Console.WriteLine($"q2 Count: {q2.Count}");

            Console.WriteLine($"q1 Peek: {q1.Peek()}");
            Console.WriteLine($"q2 Peek: {q2.Peek()}");
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
