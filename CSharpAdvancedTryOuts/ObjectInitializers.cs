using System;
using System.Collections.Generic;

namespace ObjectAndCollectionInitializers
{
    public class Student
    {
        public int RollNo { get; set; }
        public string Name { get; set; }

        public Student()
        {
            Console.WriteLine("Parameterless constructor");
        }

        public Student(int rollNo, string name)
        {
            RollNo = rollNo;
            Name = name;
            Console.WriteLine("Parameterized constructor");
        }
    }

    class ObjectInitializers
    {

        static void Main(string[] args)
        {
            // Traditional approach
            Student student = new Student();
            Console.WriteLine("RollNo: {0}\nName: {1}", student.RollNo, student.Name);
            Student studentOne = new Student(101, "Henry");
            Console.WriteLine("RollNo: {0}\nName: {1}", studentOne.RollNo, studentOne.Name);
            Console.WriteLine("------------------------------------------");

            // Using object initializers
            // 1. Uncomment the below lines and execute the application
            //Student studentTwo = new Student
            //{
            //    RollNo = 102,
            //    Name = "Oswald",
            //};
            //Console.WriteLine("\n----- Details of studentTwo initialized using object initializer -----");
            //Console.WriteLine("RollNo: {0}\nName: {1}", studentTwo.RollNo, studentTwo.Name);
            /* Here Parameterless constructor is called and not the parameterized constructor
             * But initialized with the values used in the object initializer */


            /* 2. Uncomment the following code
             * Comment the parameterless constructor in Student class 
             * and execute the program */
            //Student studentThree = new Student
            //{
            //    Name = "Daisy"
            //};
            /* Here the default constructor should be invoked in the processing of object initializers
             * Due to the presence of parameterized constructor no default constructor
             * is created automatically and a compilation error is thrown*/
        }
    }
}
