using Decorator;

Client client = new Client();

var simple = new ConcreteComponent();
Console.WriteLine("Client: I get a simple component: ");
client.ClientCode(simple);

Console.WriteLine();

ConcreteDecoratorA decoratorA = new ConcreteDecoratorA(simple);
ConcreteDecoratorB decoratorB = new ConcreteDecoratorB(decoratorA);
Console.WriteLine("Client: Now I've got a decorated component: ");
client.ClientCode(decoratorB);