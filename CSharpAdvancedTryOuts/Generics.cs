using System;
using System.Collections.Generic;

namespace Generic
{
    public class Generic<T>
    {
        public List<T> ReturnListOfAnyDatatype(T a, T b, T c)
        {
            List<T> MyList = new List<T>();
            MyList.Add(a);
            MyList.Add(b);
            MyList.Add(c);
            return MyList;
        }
    }

    class Generic
    {
        static void Main(string[] args)
        {
            // 1. Uncomment the following region RegionOne
            // Execute the application to create a list containing integer values
            //#region RegionOne
            //Generic<int> list1 = new Generic<int>();
            //var integerlist = list1.ReturnListOfAnyDatatype(1, 2, 3);
            //Console.WriteLine("Elements of Integer List are:");
            //foreach (var i in integerlist)
            //{
            //    Console.WriteLine(i);
            //}
            //#endregion


            // 2. Uncomment the following region RegionTwo
            // Execute the application to create a list containing string values
            //#region MyRegion
            //Generic<string> list2 = new Generic<string>();
            //var stringList = list2.ReturnListOfAnyDatatype("California", "NewYork", "Mumbai");
            //Console.WriteLine("Elements of string List are:");
            //foreach (var i in stringList)
            //{
            //    Console.WriteLine(i);
            //}
            //#endregion


            // 3. Uncomment the following region RegionThree
            // Execute the application to create a list containing objects
            //#region RegionThree
            //Generic<object> listThree = new Generic<object>();
            //var objectList = listThree.ReturnListOfAnyDatatype(1, 23.5, "Hello");
            //Console.WriteLine("Elements of string List are:");
            //foreach (var i in objectList)
            //{
            //    Console.WriteLine(i);
            //}
            /* You can observe that the list is created even though
             * the elements are of different types. This is because
             * we have created a list of object type Generic<object> which will 
             * accept elements of any data type */
            //#endregion
        }
    }
}
