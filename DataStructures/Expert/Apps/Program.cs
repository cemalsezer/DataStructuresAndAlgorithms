using DataStructures.LinkedList.SinglyLinkedList;
using System.Collections;

namespace Apps
{
    internal class Program
    {
        static void Main(string[] args)
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
