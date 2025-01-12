using System;
using System.Collections.Generic;

namespace SortedList
{
    class SortedList
    {
        static void Main(string[] args)
        {
            SortedList<string, long> phoneBook = new SortedList<string, long>();
            string newContact = "Jennifer Lopez";
            long phoneNumber = 9988776655;
            phoneBook.Add(newContact, phoneNumber);

            newContact = "Abraham Lincoln";
            phoneNumber = 9988776655;
            phoneBook.Add(newContact, phoneNumber);

            newContact = "Crest Butler";
            phoneNumber = 9988776655;
            phoneBook.Add(newContact, phoneNumber);

            //1.Uncomment the below lines and execute the program
            /*newContact = null;
            phoneNumber = 9988776655;
            phoneBook.Add(newContact, phoneNumber);*/
            //A key cannot be null, but a value can be

            //The capacity of a SortedList object is the number of elements the SortedList can hold
            Console.WriteLine(phoneBook.Capacity);
            /*As elements are added to a SortedList, the capacity is automatically increased 
              as required through reallocation*/

            //2. Uncomment the below lines and observe how the capacity changes
            /*phoneBook.Add("Sarah Micheal", 9898454509);
            phoneBook.Add("Jack Black", 8760982312);
            Console.WriteLine(phoneBook.Capacity);*/

            //3. Uncomment the below line to explicitly set the Capacity of a sorted list
            //phoneBook.Capacity = 4;
            /*The above line will lead to an exception as we are trying 
              to set the capacity less than the current size*/

            //4. Uncomment the below line and execute the program
            //phoneBook.Add("Abraham Lincoln", 7898004509);
            //The above line will lead to an exception as a sorted list cannot contain duplicate keys

        }
    }
}
