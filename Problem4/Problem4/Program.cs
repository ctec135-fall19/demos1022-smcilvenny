using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4
{
    class Program
    {
        static void Main(string[] args)
        {

            //first bullet point from 

            ParentClass[] myArray = new ParentClass[3];

            myArray[0] = new ParentClass();
            myArray[1] = new ChildClass();
            myArray[2] = new GrandchildClass();

            //2nd bullet point prob 4

            foreach(ParentClass element in myArray)
            {
                Console.Write("{0},  ", element.GetType());
                element.ParentMethod();
            }
            Console.WriteLine();

            #region
            //overriding a base class method by child
            foreach (ParentClass element in myArray)
            {
                Console.Write("{0},  ", element.GetType());
                element.SomeMethod();
            }
            Console.WriteLine();


            #endregion

            #region
            //demonstarte chil method calling the parents method

            //create a virtual method in parent
            //override in child and call the parent as part of the implem

            foreach (ParentClass element in myArray)
            {
                Console.Write("{0},  ", element.GetType());
                element.Method2();
                Console.WriteLine();
            }
            Console.WriteLine();


            #endregion

            #region//demonstrate use of as keyword - 5th bullet point
            //repeat calls to someMethod
            foreach(object element in myArray)
            {
               
                ParentClass p = element as ParentClass;
                Console.Write("{0},  ", p.GetType());
                p.SomeMethod();

            }
            Console.WriteLine();
            #endregion

            #region is keyword - 6th bullet point
            Console.WriteLine("Use of is");
            foreach ( ParentClass element in myArray)
            {
                if (element is GrandchildClass) Console.WriteLine("Grandchild");
                else if (element is ChildClass) Console.WriteLine("CHild");
                else if (element is ParentClass) Console.WriteLine("parent");
            }
            Console.WriteLine();
            #endregion

            #region switch

            Console.WriteLine("switch");

            foreach (ParentClass element in myArray)
            {
                switch (element)
                {
                    case GrandchildClass gc:
                        Console.WriteLine("grandchild");
                        break;
                    case ChildClass c:
                        Console.WriteLine("child");
                        break;
                    case ParentClass p:
                        Console.WriteLine("Parent");
                        break;
                    default:
                        Console.WriteLine("default");
                        break;
                }
            }
            Console.WriteLine();
            #endregion

            #region
            //2nd to last bullet point create object of object type initialized to base 
            //then cast to child

            object obj = new ParentClass();
            ((ParentClass)obj).ParentMethod();

            ParentClass p1 = new GrandchildClass();
            ((GrandchildClass)obj).specializedMethod();

            #endregion

        }
    }
}
