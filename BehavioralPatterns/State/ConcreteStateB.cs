using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    public class ConcreteStateB : State
    {
        public ConcreteStateB()
        {
            
        }

        public override void Handle1()
        {
            Console.WriteLine("Concrete State B handles request 1");
        }

        public override void Handle2()
        {
            Console.WriteLine("Concrete State B handles request 2");
            Console.WriteLine("Concrete State B wants to change the state of the context");
            _context.TransitionTo(new ConcreteStateA());
        }
    }
}
