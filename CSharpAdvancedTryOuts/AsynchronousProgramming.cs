using System;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwait
{
    class AsynchronousProgramming
    {
        static void Main(string[] args)
        {
            //Call for step 1
            //Console.WriteLine(FuncOne().Result);

            //Call for step 2
            //FuncTwo();
            //Here since FuncTwo doesn't return any value, Main finishes execution before FuncTwo

            //Wait method waits for the complete execution of the task 
            //Call for step 3
            //FuncTwo().Wait();

            //Call for step 4
            //FuncThree();
        }

        //1. Uncomment the below methods FuncOne, GetDay and also the line calling FuncOne in Main

        /*FuncOne makes a call to GetDay method which returns the day
          of the week and FuncOne waits until GetDay completes execution*/
        /*public static async Task<string> FuncOne()
        {   
            string day=await GetDay();
            Console.WriteLine("Func1 execution complete");
            return day;
           
        }
        */
        /*Inside GetDay method Thread.Sleep suspends the execution for specified time
         and Task.FromResult is used to create a Task which is returned to FuncOne */
        /*public static Task<string> GetDay()
         {
             Thread.Sleep(1000);
             return Task.FromResult<string>(DateTime.Now.DayOfWeek.ToString());
         }*/
        //Task<TResult> is used when you want to use an async method returning a value

        //2 and 3. Uncomment the below methods FuncTwo, PutDelay and also the lines calling FuncTwo in main

        /*FuncTwo makes a call to PutDelay method which is simply used to delay execution
        for a specified time and until the execution of PutDelay is complete FuncTwo waits*/
        /*public static async Task FuncTwo()
        {
            Console.WriteLine("Kindly wait");
            await PutDelay();
            Console.WriteLine("Thank you for waiting");
        }
        public static async Task PutDelay()
        {
            await Task.Delay(2000);
            return;
        }*/
        //Task is used when you want to use an async method not returning any value

        //4. Uncomment the below method FuncThree,CheckVoid and also the line calling FuncThree in main

        /*FuncThree makes a call to CheckVoid method which uses Thread.Sleep method 
          to suspend execution for specified time*/
        /*public static async Task FuncThree()
        {
            await CheckVoid();
        }
        public static void CheckVoid()
        {
            Thread.Sleep(1000);
        }*/
        //An error is thrown as a void return type method cannot be awaited

    }
}
