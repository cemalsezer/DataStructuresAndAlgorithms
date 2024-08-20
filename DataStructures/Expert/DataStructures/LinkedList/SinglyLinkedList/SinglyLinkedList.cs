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
        public bool isHeadNull => Head == null;

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

        public void AddAfter(SingleyLindkedListNode<T> node, T value)
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

            var newNode = new SingleyLindkedListNode<T>(value);
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
    }
}
