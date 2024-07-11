using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Polymorphism
{
    class TypeA
    {

        public int A { get; set; }

        public TypeA(int a)
        {
            A = a;
        }

        public void MyFun01()
        {
            Console.WriteLine("i am base [Parent]");
        }

        public virtual void MyFun02()
        {
            Console.WriteLine($"Type A is {A}");
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
            Console.WriteLine("i am derevid [child]");
        }


        public override void MyFun02()
        {
            Console.WriteLine($"TypeA is {A}  type b is {B}");
        }


    }

    class TypeC : TypeB
    {

        public int C { get; set; }

        public TypeC(int a, int b, int c) : base(a, b)
        {
            C = c;
        }
        public new void MyFun01() 
        {
            Console.WriteLine("i am derevid [crandchild]");
        }
        public override void MyFun02()
        {
            Console.WriteLine($"TypeC is {A}  type b is {B} C {C}");
        }
    }

    class TypeD : TypeC
    {

        public int D { get; set; }

        public TypeD(int a, int b, int c, int d) : base(a, b, c)
        {
            D = d;
        }
        public new void MyFun01() 
        {
            Console.WriteLine("");
        }
        public new virtual void MyFun02()
        {
            Console.WriteLine($"TypeD is {A}  type b is {B} C {C}  D: {D}");
        }
    }


    class TypeE : TypeD
    {

        public int E { get; set; }

        public TypeE(int a, int b, int c, int d, int e) : base(a, b, c, d)
        {
            E = e;
        }
        public new void MyFun01() // static biding
        {
            Console.WriteLine("");
        }
        public override void MyFun02()
        {
            Console.WriteLine($"TypeE is {A}  type b is {B} C {C}  D: {D} E :{E}");
        }
    }

}

