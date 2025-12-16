using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    public class Client
    {
        public void ClientCode(Component leaf)
        {
            Console.WriteLine($"Result: {leaf.Operation()}\n");
        }

        public void ClientCode2(Component component1, Component component2)
        {
            if (component1.IsComposite())
            {
                component1.Add(component2);
            }

            Console.WriteLine($"Result: {component1.Operation()}");
        }
    }
}
