using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Tree.BinaryTree
{
    public class BinaryTree<T> where T:IComparable
    {
        public List<Node<T>> list {  get; private set; }
        public BinaryTree()
        {
            list = new List<Node<T>>();
        }
        public List<Node<T>> InOrder(Node<T> root)
        {
            if(!(root == null))
            {
                InOrder(root.Left);
                list.Add(root);
                InOrder(root.Right);    
            }
            return list;
        }
    }
}
