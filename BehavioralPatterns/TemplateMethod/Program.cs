using TemplateMethod;

Console.WriteLine("Same client code can work with different subclasses: ");

Client.ClientCode(new ConcreteClass1());

Console.WriteLine();

Console.WriteLine("Same cliente code can work with different subclasses: ");

Client.ClientCode(new ConcreteClass2());