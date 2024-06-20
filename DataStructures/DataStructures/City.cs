using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class City : IComparable<City>
    {
        public City(int plateNum, string cityName)
        {
            PlateNum = plateNum;
            CityName = cityName;
        }

        public int PlateNum { get; set; }
        public string CityName { get; set; }

        public int CompareTo(City other)
        {
            if (this.PlateNum < other.PlateNum)
            {
                return -1;
            }
            else if (this.PlateNum == other.PlateNum)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }

        public override string ToString()
        {
            return $"{PlateNum} , {CityName}";
        }
    }
}
