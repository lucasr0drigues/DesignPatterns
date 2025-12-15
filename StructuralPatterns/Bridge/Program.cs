using Bridge;

Client client = new Client();

var abstraction = new Abstraction(new ConcreteImplementationA());
client.ClientCode(abstraction);

Console.WriteLine();

abstraction = new ExtendedAbstraction(new ConcreteImplementationB());
client.ClientCode(abstraction);

Console.WriteLine();

abstraction = new Abstraction(new ConcreteImplementationB());
client.ClientCode(abstraction);