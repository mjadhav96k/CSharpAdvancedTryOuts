using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    class LINQ
    {
        static void Main(string[] args)
        {
            //data source for LINQ query
            var worldPopulation = new Dictionary<string, long>()
            {
                {"China",1409517397 },
                {"India",1339180127 },
                {"USA",324459463 },
                {"Netherlands",17035938 },
                {"Greece",11159773 },
                {"Ireland",4761657}
            };

            //Traditional Method
            List<string> countrylist = new List<string>();
            foreach (var i in worldPopulation)
            {
                if (i.Value > 20000000)
                {
                    countrylist.Add(i.Key);
                }
            }
            Console.WriteLine("Using Traditional Method:");
            Console.WriteLine("Countries with population more than 20 million are:");
            foreach (var country in countrylist)
            {
                Console.WriteLine(country);
            }
            Console.WriteLine();

            //Using LINQ, you can easily fetch data from the provided data source
            //Uncomment the below given code and comment the example of traditional method 
            /* List<string> countries = (from country in worldPopulation where country.Value > 20000000 select country.Key).ToList<string>(); ;
             Console.WriteLine("Using LINQ:");
             Console.WriteLine("Countries with population more than 20 million are:");
             countries.ForEach(i => Console.WriteLine(i)); */



        }
    }
}
