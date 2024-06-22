using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class HashSetAppExample
    {
        public static void CharAlphabetApp()
        {
            var sesliHarf = new HashSet<char>()
            {
                'e','ı','i','u','ü','o','ö','b'
            };

            sesliHarf.Add('a');

            sesliHarf.Remove('b');
            CollectionWrite(sesliHarf);

            var alfabe = new List<char>();
            for (int i = 97; i < 123; i++)
                alfabe.Add((char)i);
            CollectionWrite(alfabe);


            sesliHarf.UnionWith(alfabe);
            CollectionWrite(sesliHarf);

        }

        public static void CollectionWrite(IEnumerable col)
        {
            Console.WriteLine();
            int i = 0;
            foreach (char c in col)
            {
                Console.Write($"{c,5}");
                i++;
            }
            Console.WriteLine();
            Console.WriteLine("Item count: {0}",i);
            Console.WriteLine();
        }
    }
}
