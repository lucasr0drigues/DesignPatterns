using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    public class SimpleCommand : ICommand
    {
        private string _payload = string.Empty;

        public SimpleCommand(string payload)
        {
            _payload = payload;
        }

        public void Execute()
        {
            Console.WriteLine($"Simple Command: See, I can do simple things like printing ({_payload})");
        }
    }
}
