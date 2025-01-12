using System;

namespace ConsoleApp
{
    // Custom Exception class inherits from Exception class
    public class InvalidCardException : Exception
    {
        public InvalidCardException()
        {

        }

        public InvalidCardException(string message) : base(message)
        {
            // The parameter message describes the error.
            // You can either write a message here or print the stack trace for error
        }
    }

    public class ExceptionHandling
    {
        public static bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }
        static void Main(string[] args)
        {
            try
            {
                // 1. Execute the application
                string cardNo = "123456789";
                // 2. comment the above line and uncomment the below line
                // Execute the application
                //string cardNo="abc12345";
                if (IsDigitsOnly(cardNo))
                {
                    Console.WriteLine("Card Accepted");
                }
                else
                {
                    InvalidCardException expObj = new InvalidCardException("Invalid card details.");
                    /* throw keyword is used to raise an exception incase the 
                     * card number contains any characters other than numbers */
                    throw expObj;
                }
            }
            catch (InvalidCardException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
