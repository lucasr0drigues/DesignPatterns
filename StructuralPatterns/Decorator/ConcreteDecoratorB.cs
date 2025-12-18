using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class ConcreteDecoratorB : Decorator
    {
        public ConcreteDecoratorB(Component component) : base(component)
        {

        }

        public override string Operation()
        {
            return $"Concrete Decorator B({base.Operation()})";
        }
    }
}
