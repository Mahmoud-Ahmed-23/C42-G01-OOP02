using Demo.Inheritance;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Video 1

            //Car c1;

            ///// Declare for Reference of type "Car", Refering to NULL
            ///// CLR will Allocate 4 byte at STACK for this reference "C1"
            ///// ClR will Allocate 0 byte at HEAP  
            ///// 

            ////c1 = new Car(123, "Mercedes G-Class", 200);

            ///// new
            ///// 1. Allocate Required number of bytes for the allocated object at HEAP = 16 Bytes
            ///// 2. Initialize the allocated bytes of each and every attribute with the default value of attribute datatype
            ///// 3. Call User-defined Constructor [if exists]    
            ///// 4. Assign the address of the allocated object in Heap to the references "c1"
            /////

            //c1 = new Car(123, "Mercedes G-Class", 200);

            //Console.WriteLine(c1);

            //Console.WriteLine("\n\n-------------------------------------\n\n");

            ////----------------------------------------------//

            //c1 = new Car(123, "Hundai");

            //Console.WriteLine(c1);

            //Console.WriteLine("\n\n-------------------------------------\n\n");

            ////---------------------------------------------//

            //c1 = new Car(312);

            //Console.WriteLine(c1);

            #endregion


            #region Video 2

            Child child = new Child(1, 2, 3);

            //child.x = 11;
            //child.y = 22;
            //child.z = 33;

            /// before overridding
            /// Console.WriteLine(child.ToString()); // X: 1 Y: 2
            /// Console.WriteLine("\n-------------------------------------------\n");
            /// Console.WriteLine($"Product: {child.Product()}"); // Product = 2


            ///after overridding

            Console.WriteLine(child.ToString()); // X: 1 Y: 2 Z: 3
            Console.WriteLine("\n-------------------------------------------\n");            
            Console.WriteLine($"Product: {child.Product()}"); // Product = 6





            #endregion



        }
    }
}
