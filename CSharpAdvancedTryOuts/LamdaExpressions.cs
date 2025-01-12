using System;

namespace Lambda
{
    class LamdaExpressions
    {
        public delegate float SimpleInterestDelegate(float principle, float rate, float time);
        static void Main(string[] args)
        {
            float principle = 15000.00f;
            float time = 1.5f;
            float rate = 7.8f;

            //An anonymous method implementation for calculating Simple interest: 
            //Method 1
            SimpleInterestDelegate simpleDel = delegate (float p, float r, float t) {
                float simpleInterest = p + (1 + r * t);
                return simpleInterest;
            };

            Console.WriteLine("Simple Interest using anonymous method: " + simpleDel(principle, rate, time));


            //However, this could also be easily done using lambda expression. Comment the Method1 and uncomment the Method2.

            //Method2
            /*SimpleInterestDelegate simpleLambda = (p, r, t) => p + (1 + r * t); 
            Console.WriteLine("Simple Interest using anonymous method: " + simpleLambda(principle, rate, time));*/

            /*Lambda expression can be used to provide a short-hand implementation of anonymous methods.
             * Lambda empressions have a really simple and readable syntax making them convenient to use with other powerful features of C# */


        }
    }
}
