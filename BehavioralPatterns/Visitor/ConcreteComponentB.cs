using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    public class ConcreteComponentB : IComponent
    {
        public void Accept(IVisitor visitor)
        {
            visitor.VisitConcreteComponentB(this);
        }

        public string SpecialMethodOfConcreteComponentB()
        {
            return "Component B";
        }
    }
}
