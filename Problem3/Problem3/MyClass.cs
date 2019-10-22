using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3
{
    class MyClass
    {
        //feilds
        private string str;
        private string str2;

        public MyClass(string instr)
        {
            //composition
            //myClass owns str, str doesnt exist outside of myClass
            str = "some string";

            //agregation
            // str2 refers to object outside of MyClass
            str2 = instr;

        }

        public void printState()
        {
            Console.WriteLine("str,  {0}", str);
            Console.WriteLine("str2,  {0}", str2);
        }

    }
}
