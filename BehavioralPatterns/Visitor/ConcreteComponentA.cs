using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    public class ConcreteComponentA : IComponent
    {
        public void Accept(IVisitor visitor)
        {
            visitor.VisitConcreteComponentA(this);
        }

        public string ExclusiveMethodofConcreteComponentA()
        {
            return "Component A";
        }
    }
}
