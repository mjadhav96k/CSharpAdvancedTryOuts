using System;
using System.Collections.Generic;


class Predicate
{
    // A static method to check whether the accepted string parameter is in upper case or not
    static bool IsUpperCase(string str)
    {
        return str.Equals(str.ToUpper());
    }
    public static void Main(String[] args)
    {
        //Predicates are inbuilt delegate types which are capable of accepting only one parameter and returning only a boolean value

        //1.Predicate delegate
        Predicate<string> isUpper = IsUpperCase;
        bool result = isUpper("hello world!!");
        Console.WriteLine(result);

        //2. Predicate delegate with anonymous method
        //predicate delegates can be assigned with any method accepting one parameter and returning a boolean value
        //comment the previous print statements and uncomment the code for Predicate delegate with anonymous method

        /*isUpper = delegate (string s) { return s.Equals(s.ToUpper()); };
        result = isUpper("hello world!!");
        Console.WriteLine(result);*/


        //3. Predicate delegate with lambda expression
        //comment the previous print statements and uncomment the code for Predicate delegate with lambda expression

        /*isUpper = s => s.Equals(s.ToUpper());
        result = isUpper("hello world!!");
        Console.WriteLine(result);*/

        /*Predicates due to thier simplicity can be used to validate conditions, making them an important feature of C# when used with other powerful features like LINQ */

    }

}