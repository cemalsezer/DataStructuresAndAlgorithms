using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.LinkedList.SinglyLinkedList
{
    public class SingleyLindkedListNode<T>
    {
        public SingleyLindkedListNode<T> Next { get; set; }
        public T Value { get; set; }

        public SingleyLindkedListNode(T value)
        {
            Value = value;
        }

        public override string ToString()
        {
            return $"{Value}";
        }
    }
}
