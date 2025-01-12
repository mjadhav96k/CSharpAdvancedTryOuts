using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvancedTryOuts
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region ArrayList Quiz 1
            //ArrayList list = new ArrayList();
            //list.Add(5);
            //list.Add(9);
            //list.Add(5.10);

            //int result = 0;
            //foreach (int item in list)
            //{
            //    result += item;
            //}
            //Console.WriteLine(result); 
            #endregion

            #region ArrayList Quiz 2
            /*
             ArrayList re-orders the elements in their appropriate index positions, when an element in the array list is deleted. The last index number available after calling the RemoveAt(2) is 2 and their is no value present at index number 3 to execute the method RemoveAt(3). IndexOutOfRangeException would be raised when the RemoveAt(3) is called.
             */

            //ArrayList empList = new ArrayList();

            //empList.Add("Emily");
            //empList.Add(101);
            //empList.Add("James");
            //empList.Add(102);

            //empList.RemoveAt(2);
            //empList.RemoveAt(3);

            //foreach (var item in empList)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region Generic List Quiz1
            //List<bool> list = new List<bool>();
            //Console.WriteLine(list.Count);
            //Console.WriteLine(list.Capacity);
            //list.Add(true);
            //Console.WriteLine(list.Count);
            //Console.WriteLine(list.Capacity);
            //list.RemoveAt(0);
            //Console.WriteLine(list.Count);
            //Console.WriteLine(list.Capacity); 
            #endregion

            #region Sorted List
            //SortedList<int, string> slObj = new SortedList<int, string>();

            //slObj.Add(004, "Tim");
            //slObj.Add(001, "Ann");
            //slObj.Add(003, "Fin");

            //if (slObj.ContainsValue("John"))
            //{
            //    Console.WriteLine("Hi");
            //}
            //else
            //{
            //    slObj.Add(2, "John");
            //}
            //foreach (var pair in slObj)
            //{
            //    Console.WriteLine(pair);
            //} 
            #endregion

            #region Delegate
            //SubstringDelegate str1;
            //string str = "Hello_World";
            //str1 = Class1.fun;
            //str1(ref str);
            //Console.WriteLine(str); 
            #endregion

            #region Lamda Expressions
            ////Quiz 1
            //int[] numbers = { 10, 5, 8, 7, 12, 15, 31, 56, 21 };
            //bool isEmpty = numbers.Any(n => n % 2 == 0);
            //Console.WriteLine(isEmpty);

            ////Quiz 2
            //int[] source = new[] { 13, 28, 4, 16, 11, 27, 9, 42, 24, 8 };
            //foreach (int i in source.Where(
            //    x =>
            //    {
            //        if ((x / 4) <= 3)
            //            return true;
            //        else if ((x / 4) >= 7)
            //            return true;
            //        return false;
            //    }))
            //    Console.WriteLine(i);
            #endregion

            #region Asynchronous Programming
            SaySomething();
            Console.Write(result); 
            #endregion

        }

        private static string result;

        static async Task<string> SaySomething()
        {
            await Task.Delay(5);
            result = "Hello world!";
            return "something";
            //Because SaySomething() was not awaited in the main, execution of the current method continues before the call is completed. Hence, no output is printed, making this option is correct
        }

    }
    #region Delgate Quiz class
    delegate void SubstringDelegate(ref string str);
    class Class1
    {
        public static void fun(ref string a)
        {
            a = a.Substring(5, a.Length - 5);
        }
    } 
    #endregion
}
