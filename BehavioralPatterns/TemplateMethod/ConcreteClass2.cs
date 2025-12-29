using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod
{
    public class ConcreteClass2 : AbstractClass
    {
        protected override void RequiredOperations1()
        {
            Console.WriteLine("Concrete Class 2: Implemented Operation 1");
        }

        protected override void RequiredOperations2()
        {
            Console.WriteLine("Concrete Class 2: Implemented Operation 2");
        }

        protected override void Hook1()
        {
            Console.WriteLine("Concrete Class 2: Overridden Hook 1");
        }
    }
}
