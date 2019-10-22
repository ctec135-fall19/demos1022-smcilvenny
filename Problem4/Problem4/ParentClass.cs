using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4
{
    class ParentClass
    {
        public void ParentMethod()
        {
            Console.WriteLine("Parent Method");
        }

        //demonstrate overriing a base class method by child 

        public virtual void SomeMethod()
        {
            Console.WriteLine("Parents SomeMethod");
        }

        public virtual void Method2()
        {
            Console.WriteLine("Parent.Method2");
        }
    }
}
