using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public  class SortedSetAppExample
    {
        public static void UniqueNums()
        {
            var nums = new List<int>();
            var r = new Random();

            Console.WriteLine();
            for (int i = 0; i < 1000; i++)
            {
                nums.Add(r.Next(5, 15));
                Console.Write($"{nums[i],-3}");
            }
            Console.WriteLine();

            var uniequeNumsList = new SortedSet<int>(nums);

            Console.WriteLine();
            Console.WriteLine("\nUnique nums list\n");
            foreach (int i in uniequeNumsList)
            {
                Console.Write($"{i,-3}");
            }
            Console.WriteLine();
            Console.WriteLine("\nThere are {0} unique nums");
        }

        public static void SortedSetApp()
        {
            var A = new SortedSet<int>(RandomNums(2));
            //var A = new SortedSet<int>() { 1,2,3,4};
            var B = new SortedSet<int>(RandomNums(3));
            //var B = new SortedSet<int>() {1,2,5,6};

            Console.WriteLine();
            Console.WriteLine("A kümesi");
            foreach (var s in A)
            {
                Console.Write($"{s,5}");
            }
            Console.WriteLine();


            Console.WriteLine();
            Console.WriteLine("B kümesi");
            foreach (var s in B)
            {
                Console.Write($"{s,5}");
            }
            Console.WriteLine();

            A.UnionWith(B);
            //A.IntersectWith(B);
            //A.ExceptWith(B);
            //A.SymmetricExceptWith(B);

            Console.WriteLine();
            Console.WriteLine("A ve B Kümesinin Birleşimi");
            foreach (var s in A)
            {
                Console.Write($"{s,5}");
            }

            Console.WriteLine("\nToplam sayısı: {0}", A.Count);

        }

        public static List<int> RandomNums(int n)
        {
            var list = new List<int>();
            var r = new Random();
            for (int i = 0; i < n; i++)
                list.Add(r.Next(0, 1000));
            return list;

        }
    }
}
