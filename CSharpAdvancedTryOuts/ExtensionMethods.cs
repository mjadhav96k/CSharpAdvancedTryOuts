using System;
using System.Text.RegularExpressions;

namespace Extensions
{
    // Extension methods is one of the powerful features offered by C# which allow developers to extend the collection of methods available for predefined data types with thier own defined methods

    public static class StringExtensions /* static class defined to contain implementation of extension methods */
    {
        public static bool ValidatePassword(this string password) /* extension method defined to validate a password's format */
        {
            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasMiniMaxChars = new Regex(@".{8,15}");
            var hasLowerChar = new Regex(@"[a-z]+");
            var hasSymbols = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");
            if (hasNumber.IsMatch(password) && hasUpperChar.IsMatch(password) && hasMiniMaxChars.IsMatch(password) && hasLowerChar.IsMatch(password) && hasSymbols.IsMatch(password))
            {
                return true;
            }
            return false;
        }
    }

    public class ExtensionMethods
    {
        static void Main(string[] args)
        {
            string password = "Mark10@asdf";
            //After executing, comment above line and uncomment the line given below and then execute the code 
            //string password=" Mark";
            bool result = password.ValidatePassword();
            if (result)
            {
                Console.WriteLine("Password is in proper format");
            }
            else
            {
                Console.WriteLine("Invalid password format");
            }
        }
    }

    /*Extension methods due to their advantage of scaling up the performance of predefined data types and simplicity in usage is used in other powerful features of C# like LINQ */

}
