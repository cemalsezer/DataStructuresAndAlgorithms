using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.LinkedList.SinglyLinkedList
{
    public class SinglyLindkedListNode<T>
    {
        public SinglyLindkedListNode<T> Next { get; set; }
        public T Value { get; set; }

        public SinglyLindkedListNode(T value)
        {
            Value = value;
        }

        public override string ToString()
        {
            return $"{Value}";
        }
    }
}
