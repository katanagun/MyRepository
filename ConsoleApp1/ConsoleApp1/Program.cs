using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        public class A
        {

        }


        public class B : A
        {
            public Object A;

            public void setA(object A)
            {
                this.A = A;
            }

            public object get(object A)
            {
                return A;
            }

        }

        public class C : B
        {
            public Object B;

            public void setB(object B)
            {
                this.B = B;
            }

            public object get(object B)
            {
                return B;
            }

        }

      


        static void Main(string[] args)
        {
            A a1 = new A();
            A a2 = new A();
            A a3 = new A();
            A a4 = new A();
            B b5 = new B();
            C c6 = new C();
            b5.A = a1;
            b5.A = a2;
            c6.B = b5;
            c6.A = a4;
            c6.A = a3;
        }
    }


}
