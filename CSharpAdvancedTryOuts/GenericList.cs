using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvancedTryOuts
{

        class GenericList
    {
            static void Main(string[] args)
            {
                List<string> bookCollection = new List<string>();

                // Another way to create a generic list is given below
                IList<int> bookQuantity = new List<int>();
                /* The List<T> is a concrete implementation of IList<T> interface
                 * It is advisable to program using interface rather than concrete class 
                 * but List<T> includes more helper methods */

                //Add method adds an element at the end of a List<T>
                bookCollection.Add("Anna Karenina by Leo Tolstoy.");
                bookCollection.Add("Madame Bovary by Gustave Flaubert.");
                bookCollection.Add("War and Peace by Leo Tolstoy.");

                bookQuantity.Add(20);
                bookQuantity.Add(10);
                bookQuantity.Add(15);

                // Count property returns the total number of elements exists in the List<T>
                Console.WriteLine(bookQuantity.Count);

                /* Removes method removes the first occurence of the specified element
                 * and returns false if element is not found */
                Console.WriteLine(bookQuantity.Remove(30));

                /* 1. Uncomment the following statement to sort the elements
                 * Observe that a compilation error is thrown, since
                 * the reference variable is of type IList<T>,
                 * and the Sort() is not declared in the IList<T>, but defined only in List<T> */
                //bookQuantity.Sort();

                /* 2. Uncomment the following statement to sort the elements in bookCollection
                 * Observe that NO compilation error is thrown, since
                 * the reference variable is of type List<T>, and
                 * the Sort() is implemented only in List<T> */
                //bookCollection.Sort();

                //Foreach can be used to iterate through a List<T>
                foreach (var el in bookQuantity)
                    Console.WriteLine(el);

                //Clear method removes all the elements from a List<T>
                bookQuantity.Clear();
                Console.WriteLine(bookQuantity.Count);
            }
        }
    }


