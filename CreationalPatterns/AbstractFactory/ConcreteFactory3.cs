using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class ConcreteFactory3 : IAbstractFactory
    {
        public IAbstractProductA CreateProductA()
        {
            return new ConcreteProductA3();
        }

        public IAbstractProductB CreateProductB()
        {
            return new ConcreteProductB3();
        }
    }
}
