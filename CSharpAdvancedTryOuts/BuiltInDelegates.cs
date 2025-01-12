using System;
using System.Collections.Generic;
using System.Linq;

namespace BuiltInDelegates
{
    class BuiltInDelegates
    {

        static void Main(string[] args)
        {
            //Func<T> delegate is an inbuilt delegate which is capable of accepting minimum 1 to maximum 17 parameters in which the last parameter always specifies the return type
            // for example:
            Func<int, int, int> findSum = (a, b) => a + b;
            Console.WriteLine("Sum ->" + findSum(1, 2));

            //Action<T> delegate is an inbuilt delegate which is capable of accepting minimum 0 to maximum 16 parameters and doesn't return anything

            Action<int> findFactorial = (n) => {
                int res = 1;
                for (int i = 1; i <= n; i++)
                {
                    res = res * i;
                }
                Console.WriteLine("Factorial of {0}: {1}", n, res);
            };

            findFactorial(5);

            //Predicate delegate is an inbuilt delegate which is capable of accepting only 1 parameter and always returns a boolean value

            Predicate<int> checkPalindrome = (n) => {
                int result = 0;
                var temp = n;
                while (temp != 0)
                {
                    var remainder = temp % 10;
                    result = result * 10 + remainder;
                    temp = temp / 10;
                }
                if (result == n)
                {
                    return true;
                }
                return false;
            };

            Console.WriteLine("Palindrome " + checkPalindrome(121));

            /*Action can also accept 0 paramaters and not return any value. 
             They can be used to print results or store methods which matches its signature and doesn't return anything */
            //Comment the statements in Line 15,28 and 48 and uncomment the below given code

            /*Action callAllDelegates = () => { Console.WriteLine(findSum(1, 2)); findFactorial(5); Console.WriteLine(checkPalindrome(121)); };
            callAllDelegates();*/
        }
    }
}
