using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4
{
    class ChildClass : ParentClass
    {
        //demonstrate overriing a base class method by child 

        public override void SomeMethod()
        {
            Console.WriteLine("Childs SomeMethod");
        }

        public override void Method2()
        {
            base.Method2();
            Console.WriteLine("Child.Method2");
        }
    }
}
