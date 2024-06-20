using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class SortedListExamples
    {
        public static void Basics()
        {
            var list = new SortedList()
            {
                {1,"Bir" },
                {2, "İki" },
                {3, "Üç" }

            };
            foreach (DictionaryEntry entry in list)
            {
                Console.WriteLine($"{entry.Key} {entry.Value}");
            }

            Console.WriteLine(list[3]);
            Console.WriteLine(list.GetByIndex(1));

        }

        public static void BookContents()
        {
            var bookContents = new SortedList()
            {
                {1, "Intro"},
                {5, "Variables"},
                {15, "Operators"}
            };
            Console.WriteLine("Contents");
            Console.WriteLine(new string('-',25));

            Console.WriteLine($"{"Topics",-33} {"Pages",8}");
            foreach(DictionaryEntry entry in bookContents)
            {
                Console.WriteLine($"{entry.Value,-33} {entry.Key,8}");
            }
        }
    }
}
