using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public  class ListApplicationExample
    {
        public static void CityListApplicationExample()
        {
            var cities = new List<City>()
            {
                new City(5,"Amasya"),
                new City(1, "Adana"),
                new City(35, "İzmir")
            };
            cities.Add(new City(10, "Balıkesir"));

            cities.Sort();
            cities.ForEach(city => Console.WriteLine(city));
        }

    }
}
