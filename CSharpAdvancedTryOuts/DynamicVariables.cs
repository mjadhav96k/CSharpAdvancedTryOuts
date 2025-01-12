using System;

namespace Dynamic_Variables
{
    class Employee
    {
        // Dynamic fields can be created in C#
        dynamic empId;

        // Dynamic properties can be created in C#
        dynamic EmpName { get; set; }

        public Employee(int id, string name)
        {
            // Explicit conversion to dynamic
            empId = (dynamic)id;
            EmpName = (dynamic)name;
        }

        // Method returning type dynamic is possible
        public dynamic GetEmployeeId()
        {
            return empId;
        }

    }

    class DynamicVariables
    {
        static void Main(string[] args)
        {
            dynamic employee;
            dynamic emp = 101;
            emp = new Employee(101, "Julia");
            /* The type of value assigned to a dynamic type variable can be changed 
             * Here it is changed from the fundamental data type int to a user defined class Employee */

            // 1. Uncomment the below lines and execute the application
            //int id = emp.GetEmployeeId();
            //Console.WriteLine(id);
            /* Data types of the dynamic variables are resolved at run-time
             * Here the GetEmployeeId() returns the value assigned to the 
             * instance variable empId declared using dynamic in class Employee */

            /* 2. Uncomment the below line and execute the application
             * to print the type of the dynamic variable decided at run-time */
            //Console.WriteLine(emp.GetType());
            /* emp is assigned with a new Employee() object
             * Hence the data type displayed is Employee along with the namespace */
        }
    }
}
