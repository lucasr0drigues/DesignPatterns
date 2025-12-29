using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod
{
    public class ConcreteClass1 : AbstractClass
    {
        protected override void RequiredOperations1()
        {
            Console.WriteLine("Concrete Class 1: Implemented Operation 1");
        }

        protected override void RequiredOperations2()
        {
            Console.WriteLine("Concrete Class 1: Implemented Operation 2");
        }
    }
}
