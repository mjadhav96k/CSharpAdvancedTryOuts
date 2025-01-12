using System;
using System.IO;
namespace MemoryManagement
{
    /*Types that use unmanaged resources must implement IDisposable to reclaim the unmanaged memory.
    Dispose method is used to release the unmanaged resource from the memory. To prevent garbage collector
    from calling an object's finalizer (Destructor), dispose method uses GC.SuppressFinalize method*/
    class MyClass : IDisposable
    {
        public StreamReader reader;
        public MyClass()
        {
            Console.WriteLine("Constructor called");
        }
        ~MyClass()
        {
            Console.WriteLine("Destructor called");
        }
        public void Dispose()
        {
            //Cleanup unmanaged resources
            if (reader != null)
                reader.Dispose();
            //Avoids the invocation of Destructor. GC means garbage collector
            GC.SuppressFinalize(this);
            Console.WriteLine("Disposed");
        }
    }
    class MemoryManagement
    {
        static void Main(string[] args)
        {

            /*Dispose method can be called two ways*/

            //Dispose method called through try/finally block. Here, it is needed to call Dispose method explicitly

            MyClass obj = null;
            try
            {
                obj = new MyClass();
            }
            finally
            {
                //call dispose method
                obj.Dispose();
            }

            /* Dispose method can also be called through using statement. 
             * C# introduced using statement, which can only be used
                with types that implement an IDisposable interface; it automatically calls Dispose method after the using
                statement ends */
            // try it out by commenting the code in main() and uncommenting the code given below.

            /*using (MyClass obj = new MyClass())
            {
            }
            */



            //Comment the above code and Uncomment the below code. Also comment GC.SuppressFinalize(this) method in Line 25

            /*using (MyClass obj = new MyClass())
            {
            }
            */
            /*You will observe that though the dispose method is called, the destructor will also be called 
            if SuppressFinalize method call is not present*/
            Console.WriteLine("End");
        }
    }
}
