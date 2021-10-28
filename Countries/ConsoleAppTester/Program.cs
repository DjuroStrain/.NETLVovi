using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Countries;

namespace ConsoleAppTester
{
    class Program
    {
        static void Main(string[] args)
        {
            CountryRepository novi = new CountryRepository();
            List<Country> list = new List<Country>();

            list = novi.GetCountries();

            var list2 = novi.GetRegions();

            foreach(var item in list)
            {
                Console.WriteLine(item.Name);
            }

            Console.ReadLine();
        }



    }

    
}
