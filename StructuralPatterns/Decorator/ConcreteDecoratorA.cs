using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class ConcreteDecoratorA : Decorator
    {
        public ConcreteDecoratorA(Component component) : base(component)
        {
        }

        public override string Operation()
        {
            return $"Concrete Decorator A({base.Operation()})";
        }
    }
}
