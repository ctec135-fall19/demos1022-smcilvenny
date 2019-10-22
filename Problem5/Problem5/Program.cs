using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem5
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass mc1 = new MyClass("B", 2);
            MyClass mc2 = new MyClass("A", 1);

            Console.WriteLine(mc1.CompareTo(mc2));
            Console.WriteLine();

            MyClass[] mcArray = new MyClass[0];
            mcArray[1] = mc1;

        }
    }
}

//public int CompareTo(object obj){
//  cast obj in my class

// MyClasss mc = obj as MyClass;