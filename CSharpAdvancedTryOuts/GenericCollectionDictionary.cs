using System;
using System.Collections.Generic;

namespace Dictionary
{
    class GenericCollectionDictionary
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> listOfCapitals = new Dictionary<string, string>();

            listOfCapitals.Add("India", "New Delhi");
            listOfCapitals.Add("Australia", "Canberra");
            listOfCapitals.Add("Belgium", "Brussels");
            listOfCapitals.Add("Greece", "Athens");
            listOfCapitals.Add("Germany", "Berlin");
            listOfCapitals.Add("Canada", "Ottawa");

            Console.WriteLine("----- List of Countries with their Capitals -----");

            // The below lines show how to iterate over dictionary object
            foreach (KeyValuePair<string, string> kvp in listOfCapitals)
            {
                Console.WriteLine("{0} : {1}", kvp.Key, kvp.Value);
            }

            /* 1. If a key does not exist, setting the indexer for that key
             * adds a new key-value pair */
            listOfCapitals["Italy"] = "Rome";
            Console.WriteLine("\n----- After adding 'Italy' -----");
            foreach (KeyValuePair<string, string> kvp in listOfCapitals)
            {
                Console.WriteLine("{0} : {1}", kvp.Key, kvp.Value);
            }
            Console.WriteLine("----------------------------------");

            // 2. ContainsKey can be used to test keys before inserting them
            Console.WriteLine("\n----- ContainsKey -----");
            if (listOfCapitals.ContainsKey("Italy"))
                Console.WriteLine("Key already present");
            else
                Console.WriteLine("Key not present");

            /* 3. Keys (Pluralized) property of Dictionary<K, T> 
             * returns all the keys from the key-value pairs */
            Console.WriteLine("\n----- Only Keys - Country names -----");
            foreach (string countryName in listOfCapitals.Keys)
            {
                Console.WriteLine(countryName);
            }

            /* 4. Values (Pluralized) property of Dictionary<K, T> 
             * returns all the values from the key-value pairs */
            Console.WriteLine("\n----- Only Values - Capital city names -----");
            foreach (string capitalName in listOfCapitals.Values)
            {
                Console.WriteLine(capitalName);
            }
        }
    }
}
