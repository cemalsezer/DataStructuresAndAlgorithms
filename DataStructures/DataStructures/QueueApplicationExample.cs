using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class QueueApplicationExample
    {
        public static void QueueApp()
        {
            var sesliHarfler = new List<char>()
            {
                'a','e','ı','i','o','ö','u','ü'
            };

            ConsoleKeyInfo choise;
            var newQueue = new Queue<char>();

            foreach (char item in sesliHarfler)
            {
                Console.WriteLine();
                Console.WriteLine($"{item,-5} is added on queue? [y/n]");
                choise=Console.ReadKey();
                Console.WriteLine();
                if(choise.Key==ConsoleKey.Y)
                {
                    newQueue.Enqueue(item);
                    Console.WriteLine($"\n{item,-5} added in queue");
                    Console.WriteLine($"Value of queue: {newQueue.Count()}");
                    Console.WriteLine();
                }
               
            }


            Console.WriteLine();
            Console.WriteLine("Press the Esc key to remove items from the queue");
            choise = Console.ReadKey();
            Console.WriteLine();

            if (choise.Key==ConsoleKey.Escape)
             {
                Console.WriteLine();

                while(newQueue.Count>0)
                {
                    Console.WriteLine();
                    Console.WriteLine($"{newQueue.Peek(),5} removing on queue");
                    Console.WriteLine($"{newQueue.Dequeue(),5} removed on queue");
                    Console.WriteLine($"Value of queue: {newQueue.Count()}");
                }

                    Console.WriteLine("\nQueue removal operation completed");
            }

        }

        
    }
}
