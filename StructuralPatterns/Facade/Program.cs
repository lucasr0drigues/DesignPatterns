using Facade;

Subsystem1 subsystem1 = new Subsystem1();
Subsystem2 subsystem2 = new Subsystem2();

Facade.Facade facade = new Facade.Facade(subsystem1, subsystem2);
Client.ClientCode(facade);