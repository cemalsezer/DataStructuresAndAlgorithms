using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class SortedDictionaryAppExample
    {
        public static void BookIndexApp()
        {
            var bookIndex = new SortedDictionary<string, List<int>>()
            {
                {"HTML", new List<int>() {8,10,12}},
                {"CSS", new List<int>() {70,80,90}},
                {"JQuery", new List<int>() {3,5,15}},
                {"SQL", new List<int>() {70,80}}

            };

            bookIndex.Add("FTP", new List<int>() { 3, 5, 7 });
            bookIndex.Add("ASP.NET", new List<int>() { 50,60 });

            foreach(var item in bookIndex)
            {
                Console.WriteLine(item.Key);
                item.Value.ForEach(x => Console.WriteLine("\t >"+x));
            }
        }
    }
}
