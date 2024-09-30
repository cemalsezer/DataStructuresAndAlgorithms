using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.LinkedList.SinglyLinkedList
{
    public class SinglyLinkedList<T>
    {
        public SinglyLindkedListNode<T> Head{ get; set; }
        public bool isHeadNull => Head == null;

        public void AddFirst(T value)
        {
            var newNode= new SinglyLindkedListNode<T>(value);
            newNode.Next = Head;
            Head = newNode;
        }

        public void AddLast(T value)
        {
            var newNode = new SinglyLindkedListNode<T>(value);
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

        public void AddAfter(SinglyLindkedListNode<T> node, T value)
        {
            if(node == null)
            {
                throw new ArgumentException();    
            }
            if(Head == null)
            {
                AddFirst(value);
                return;
            }

            var newNode = new SinglyLindkedListNode<T>(value);
            var current = Head;
            while (current.Next != null)
            {
                if (current.Equals(node))
                {
                    newNode.Next= current.Next;
                    current.Next = newNode;
                    return;
                }
                current = current.Next;
            }
            throw new ArgumentException("The reference node is not in this list.");
        }
        public T RemoveFirst()
        {
           if (isHeadNull)
           {
                throw new Exception("Linked list is empty!");
           }
           var firstValue = Head.Value;
           Head = Head.Next;
           return firstValue;
        }

    }
}
