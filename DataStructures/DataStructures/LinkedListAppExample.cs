using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class LinkedListAppExample
    {
        public static void Cities()
        {
            var cities = new LinkedList<string>();
            cities.AddFirst("Ankara");
            cities.AddFirst("Trabzon");
            cities.AddLast("İzmir");
            cities.AddAfter(cities.Find("Ankara"),"Çorum");
            cities.AddBefore(cities.First.Next.Next, "Sivas");


            Console.WriteLine();
            Console.WriteLine("Gidiş güzergahı");
            Console.WriteLine();
            var item = cities.First;
            while(item != null)
            {
                Console.WriteLine(item.Value);
                item = item.Next;
            }

            Console.WriteLine();
            Console.WriteLine("Dönüş güzergahı");
            Console.WriteLine();

            var reverseItem = cities.Last;
            while(reverseItem != null)
            {
                Console.WriteLine(reverseItem.Value);
                reverseItem = reverseItem.Previous;
            }
        }
    }
}
