using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class DictioanryAppExample
    {
        public static void Payment()
        {
            var employeeList = new Dictionary<int, Employee>()
            {
                {100, new Employee("A","B",1000) },
                {101, new Employee("C","B",2000) }
            };

            employeeList.Add(102, new Employee("E", "E", 2000));

            foreach (var item in employeeList)
            {
                Console.WriteLine(item);
            }
        } 
    }
}
