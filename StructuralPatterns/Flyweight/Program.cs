// See https://aka.ms/new-console-template for more information
using Flyweight;

Console.WriteLine("Hello, World!");
var factory = new FlyweightFactory(
    new Car { Company = "Chevrolet", Model = "Camaro2018", Color = "pink" },
    new Car { Company = "Mercedes", Model = "C300", Color = "black" },
    new Car { Company = "Mercedes", Model = "C500", Color = "red" },
    new Car { Company = "BMW", Model = "M5", Color = "red" },
    new Car { Company = "BMW", Model = "X6", Color = "white" }
    );

factory.ListFlyweights();

AddCarToPoliceDatabase(factory, new Car{
    Number = "CL234IR",
    Owner = "James Doe",
    Company = "BMW",
    Model = "M5",
    Color = "red"
});

AddCarToPoliceDatabase(factory, new Car
{
    Number = "CL234IR",
    Owner = "James Doe",
    Company = "BMW",
    Model = "X1",
    Color = "red"
});

factory.ListFlyweights();

static void AddCarToPoliceDatabase(FlyweightFactory factory, Car car)
{
    Console.WriteLine("\n Client: Adding a car to database");

    var flyweight = factory.GetFlyweight(new Car
    {
        Color = car.Color,
        Model = car.Model,
        Company = car.Company,
    });

    flyweight.Operation(car);
}