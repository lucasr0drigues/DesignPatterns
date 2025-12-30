using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    public class ConcreteVisitor1 : IVisitor
    {
        public void VisitConcreteComponentA(ConcreteComponentA element)
        {
            Console.WriteLine(element.ExclusiveMethodofConcreteComponentA() + " + Concrete Visitor 1");
        }

        public void VisitConcreteComponentB(ConcreteComponentB element)
        {
            Console.WriteLine(element.SpecialMethodOfConcreteComponentB() + " + Concrete Visitor 1");
        }
    }
}
