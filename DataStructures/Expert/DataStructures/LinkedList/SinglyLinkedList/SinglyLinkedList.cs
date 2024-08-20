using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.LinkedList.SinglyLinkedList
{
    public class SinglyLinkedList<T>
    {
        public SingleyLindkedListNode<T> Head{ get; set; }

        public void AddFirst(T value)
        {
            var newNode= new SingleyLindkedListNode<T>(value);
            newNode.Next = Head;
            Head = newNode;
        }

        public void AddLast(T value)
        {
            var newNode = new SingleyLindkedListNode<T>(value);
            if(Head == null)
            {
                Head= newNode;
                return;
            }

            var current = Head;
            while(current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
        }
    }
}
