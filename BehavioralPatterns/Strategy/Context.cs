using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.Marshalling;
using System.Text;

namespace Strategy
{
    public class Context
    {
        private IStrategy _strategy;

        public Context() { }

        public Context(IStrategy strategy)
        {
            _strategy = strategy;
        }

        public void SetStrategy(IStrategy strategy)
        {
            _strategy = strategy;
        }

        public void DoSomeBusinessLogic()
        {
            Console.WriteLine("Context: Sorting data using the strategy (not sure how it'll do it)");

            var result = _strategy.DoAlgorithm(new List<string> { "a", "b", "c", "d", "e", "f"});

            string resultStr = string.Empty;

            foreach(var element in result as List<string>)
            {
                resultStr += element + ", ";
            }

            resultStr = resultStr.Substring(0, resultStr.Length - 2);

            Console.WriteLine(resultStr);
        }
    }
}
