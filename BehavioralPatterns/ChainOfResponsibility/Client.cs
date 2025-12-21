using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{
    public class Client
    {
        public static void ClientCode(AbstractHandler handler)
        {
            foreach (var food in new List<string> { "Nut", "Banana", "Cup of coffe" })
            {
                Console.WriteLine($"Client: Who wants a {food}?");

                var result = handler.Handle(food);

                if (result != null)
                {

                    Console.WriteLine($" {result}");
                }
                else
                {
                    Console.WriteLine($" {food} was left untouched");
                }
            }
        }
    }
}
