using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class HashTableExamples
    {
        /*
        system.collections
        non-generic
        non-index
        key-value
         */
        
        public static void Basic()
        {
            //defined
            var cities = new Hashtable();
            

            //add
            cities.Add(35, "izmir");
            cities.Add(6, "ankara");

            foreach (DictionaryEntry item in cities)
            {
                Console.WriteLine($"{item.Key,-5}" + $"- {item.Value,-20}");
            }

            //get keys
            Console.WriteLine("\n keys:");
            var keys = cities.Keys;
            foreach (var key in keys)
            {
                Console.WriteLine(key);
            }

            //get value
            Console.WriteLine("\n values:");
            ICollection values = cities.Values;
            foreach (var value in values)
            {
                Console.WriteLine(value);
            }

            Console.WriteLine(cities[35]);

            cities.Remove(6);

        }

        public static void CrateHeading()
        {
            Console.WriteLine("Input to heading");
            string heading = Console.ReadLine();

            heading = heading.ToLower();

            var charSet = new Hashtable()
            {
                {'ç', 'c'},
                {'ö', 'o'},
                {'ı', 'i'},
                {' ', '-'},
                {'?', '-'},
                {'ğ', 'g'}
            };

            foreach(DictionaryEntry item in charSet )
            {
                heading=heading.Replace((char)item.Key, (char)item.Value);
            }
            Console.WriteLine(heading);
        }
    }
}
