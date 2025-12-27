using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    public class ConcreteStateA : State
    {
        public override void Handle1()
        {
            Console.WriteLine("Concrete State A handles request 1");
            Console.WriteLine("Concrete State A wants to change the state of the context");
            _context.TransitionTo(new ConcreteStateB());
        }

        public override void Handle2()
        {
            Console.WriteLine("Concrete State A handles request 2");
        }
    }
}
