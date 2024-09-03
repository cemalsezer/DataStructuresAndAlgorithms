using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructures.Tree.BinaryTree;

namespace DataStructures.Tree.BinarySearchTree
{
    public class BinarySearchTree<T> : IEnumerable<T>
        where T: IComparable
    {
        public Node<T> Root { get; set; }
        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
        public BinarySearchTree()
        {
            
        }
        public BinarySearchTree(IEnumerable<T> collection)
        {
            foreach(var item in collection)
            {
                Add(item);
            }
        }
        public void Add(T value)
        {
            if(value ==null)
            {
                throw new ArgumentNullException();
            }
            var newNode = new Node<T>(value);
            if(Root == null)
            {
                Root = newNode;
            }
            else
            {
                var current = Root;
                Node<T> parent;
                while(true)
                {
                    parent = current;
                    //Sol-alt ağaç
                    if(value.CompareTo(current.Value)<0)
                    {
                        current = current.Left;
                        if(current==null)
                        {
                            parent.Left = newNode;
                            break;
                        }
                    }
                    //Sağ-alt ağaç
                    else
                    {
                        current=current.Right;
                        if(current==null)
                        {
                            parent.Right= newNode;
                            break;
                        }

                    }
                }
            }
        }
    }
}
