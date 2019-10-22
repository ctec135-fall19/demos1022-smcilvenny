using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4
{
    class GrandchildClass : ChildClass
    {
        //demonstrate overriing a base class method by child 

        public override void SomeMethod()
        {
            Console.WriteLine("GrandChilds SomeMethod");
        }

        public override void Method2()
        {
            base.Method2();
            Console.WriteLine("GrandChild.Method2");
        }

        public void specializedMethod()
        {
            Console.WriteLine("specializedMethod");
        }
    }
}
