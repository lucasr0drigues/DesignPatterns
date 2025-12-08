using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class ConcreteCreator3 : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new ConcreteProduct3();
        }
    }
}
