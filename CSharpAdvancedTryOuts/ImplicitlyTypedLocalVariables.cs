using System;

class ImplicitlyTypedLocalVariables
{
    // 1. Uncomment the below line and observe the compilation error
    //var cLevelItem = 20;
    // var cannot be used to declare an instance variable

    // 2. Uncomment the following method and observe the compilation errors
    //static var MethodOne(var numOne, var numTwo)
    //{
    //    // var can be used to declare local variables
    //    var result = numOne + numTwo;
    //    return result;
    //}
    /* var cannot be used to declare parameters
     * var cannot be used as return type */

    static void Main(string[] args)
    {

    }
}