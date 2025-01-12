using System;

namespace Delegates
{
    public delegate int MyDelegate(int num1, int num2);

    public class Example
    {
        // methods to be assigned and called by delegate
        public int Sum(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Difference(int num1, int num2)
        {
            return num1 - num2;
        }

        public int Product(int num1, int num2)
        {
            return num1 * num2;
        }

        public int Modulo(int num1, int num2)
        {
            return num1 % num2;
        }

        public int Quotient(int num1, int num2)
        {
            return num1 / num2;
        }
    }

    class Delegate
    {
        static void Main(string[] args)
        {
            Example obj = new Example();

            /* 1. Instantiation: As a single cast delegate. 
             * Observe the two syntaxes for assigning a refernece of a 
             * method to the delegate reference variable */
            // Assigning the method using a constructor of the delegate
            MyDelegate sum = new MyDelegate(obj.Sum);
            // Assigning the method without the constructor of the delegate
            MyDelegate diff = obj.Difference;

            // 2. Invocation. Observe the two syntaxes to invoke a delegate
            // Using delegate object to invoke the method(s)
            Console.WriteLine("Sum of two integer is = " + sum(10, 20));
            // Using Invoke() to invoke the method(s)
            Console.WriteLine("Difference of two integer is = " + diff.Invoke(20, 10));

            // 3. More than one method can be invoked at once using multicast delegates
            Console.WriteLine("\n----- Multicast delegate operations -----");
            MyDelegate allOperations = obj.Sum;
            allOperations += obj.Difference;
            allOperations += obj.Product;
            allOperations += obj.Modulo;
            allOperations += obj.Quotient;
            foreach (MyDelegate delOperation in allOperations.GetInvocationList())
            {
                Console.WriteLine("Result: " + delOperation(20, 10));
            }
            /* GetInvocationList() has a list of all the methods to be executed using a delegate
             * This is useful when the methods return a value 
             * Every iteration in the loop executes a method and the returned result can be processed */


            // One should always be careful while implementing multicast delegates. 
            // If '=+' is accidently replaced with '=', it could break the chain
            // 4. Uncomment the below given code and execute the application
            //Console.WriteLine("\n----- Multicast delegate operations AGAIN -----");
            //MyDelegate allOperationsAgain = obj.Sum;
            //allOperationsAgain += obj.Difference;
            //allOperationsAgain += obj.Product;
            //allOperationsAgain += obj.Modulo;
            //allOperationsAgain = obj.Quotient;
            //foreach (MyDelegate delOperation in allOperationsAgain.GetInvocationList())
            //{
            //    Console.WriteLine("Result: " + delOperation(20, 10));
            //}
            /* Here the delegate is assigned with obj.Quotient method using a '='
             * and hence the previous list of assigned methods would be replaced only with one method */
        }
    }
}
