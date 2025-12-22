using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    public class ComplexCommand : ICommand
    {
        private Receiver _receiver;

        private string _objectA;
        private string _objectB;

        public ComplexCommand(Receiver receiver, string objectA, string objectB)
        {
            _receiver = receiver;
            _objectA = objectA;
            _objectB = objectB;
        }

        public void Execute()
        {
            Console.WriteLine("Complex Command: Complex stuff should be done by a receiver object");
            _receiver.DoSomething(_objectA);
            _receiver.DoSomethingElse(_objectB);
        }
    }
}
