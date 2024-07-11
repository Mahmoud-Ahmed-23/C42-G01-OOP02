using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Polymorphism
{
    internal class TypeA
    {
        public int A { get; set; }


        public TypeA(int a)
        {
            A = a;
        }


        public void MyFun01()
        {
            Console.WriteLine("I am Base [Parent] ");
        }

        public virtual void MyFun02()
        {
            Console.WriteLine($"TypeA: {A}");
        }


    }




    class TypeB : TypeA
    {
        public int B { get; set; }

        public TypeB(int a, int b) : base(a)
        {
            B = b;
        }


        public new void MyFun01()
        {
            Console.WriteLine("I am Base [Parent] ");
        }

        public override void MyFun02()
        {
            Console.WriteLine($"TypeA: {A}\nTypeB: {B}");
        }


    }


}
