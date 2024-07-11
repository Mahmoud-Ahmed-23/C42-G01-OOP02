using Demo.Inheritance;
using Demo.Polymorphism;

namespace Demo
{
    internal class Program
    {
        #region OverLoading

        public void Sum(int x, int y)
        {
            Console.WriteLine(x + y);
        }

        public void Sum(int x, double y)
        {
            Console.WriteLine(x + y);
        }


        public void Sum(double x, double y)
        {
            Console.WriteLine(x + y);
        }


        #endregion
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


            #region Overriding

            TypeA typeA = new TypeA(3);

            Console.WriteLine(typeA.ToString());

            typeA.MyFun01();

            typeA.MyFun02();


            TypeB typeB = new TypeB(3, 2);

            Console.WriteLine(typeA.ToString());

            typeB.MyFun01();

            typeB.MyFun02();


            #endregion


            #region Binding

            TypeA RefBase = new TypeB(3, 2);
            
            RefBase.A = 11;

            //RefBase.B = 22; invalid

            RefBase.MyFun01(); // I am Base [Parent]

            RefBase.MyFun02(); // TypeA: 3 , TypeB: 2

            #endregion



        }
    }
}
