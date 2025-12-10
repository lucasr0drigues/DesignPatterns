using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class ConcreteProductB3 : IAbstractProductB
    {
        public string UsefulFunctionB()
        {
            return "The result of the product B3";
        }

        public string AnotherUsefulFunctionB(IAbstractProductA collaborator)
        {
            var result = collaborator.UsefulFunctionA();

            return $"The result of the B3 collaborating with the ({result})";
        }
    }
}
