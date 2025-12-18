using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class ConcreteComponent : Component
    {
        public override string Operation()
        {
            return "Concrete Component";
        }
    }
}
