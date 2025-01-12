using System;

namespace AnonymousMethods
{
    delegate void NumberChanger(double n);

    class AnonymousMethods
    {
        static double num;
        public static void Ceil(double p)
        {
            num = Math.Ceiling(p);
            Console.WriteLine("Ceil value of {0} is : {1}", p, num);
        }

        public static void Floor(double q)
        {
            num = Math.Floor(q);
            Console.WriteLine("Floor value of {0} is : {1}", q, num);
        }

        public static void SquareRoot(double p)
        {
            num = Math.Sqrt(p);
            Console.WriteLine("Square root of {0} is : {1}", p, num);
        }

        public static void Round(double p)
        {
            num = Math.Round(p);
            Console.WriteLine("Round off value of {0} is : {1}", p, num);
        }

        public static void Square(double p)
        {
            num = p * p;
            Console.WriteLine("Round off value of {0} is : {1}", p, num);
        }
        static void Main(string[] args)
        {
            NumberChanger nc = delegate (double n)
            {
                num = Math.Ceiling(n);
                Console.WriteLine("Ceil value of {0} is : {1}", n, num);

                /* 1. Uncomment any of the below given statements to make
                anonymous method implement a different functionality */

                /*num = Math.Floor(n);
                Console.WriteLine("Floor value of {0} is : {1}", n, num);*/
            };
            nc.Invoke(10.56);

            /* 2. Uncomment the following code and execute the application
             * The following code uses multicast delegate with anonymous methods */
            //Console.WriteLine("\n----- Multicast delegate with anonymous methods -----");
            //nc = delegate (double n)
            //{
            //    num = Math.Ceiling(n);
            //    Console.WriteLine("Ceil value of {0} is : {1}", n, num);
            //};
            //nc += delegate (double n)
            //{
            //    num = Math.Floor(n);
            //    Console.WriteLine("Floor value of {0} is : {1}", n, num);
            //};
            //nc += delegate (double n)
            //{
            //    num = Math.Sqrt(n);
            //    Console.WriteLine("Square root of {0} is : {1}", n, num);
            //};
            //nc.Invoke(10.56);
            /* observe the use of '+=' to assign anonymous methods to the delegates */
        }
    }
}

