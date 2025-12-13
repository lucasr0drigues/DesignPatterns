using Prototype;

Person p1 = new Person();
p1.Age = 42;
p1.BirthDate = Convert.ToDateTime("1977-01-01");
p1.Name = "Jack Daniels";
p1.IdInfo = new IdInfo(555);

Person p2 = p1.ShallowCopy();

Person p3 = p1.DeepCopy();

Console.WriteLine("Original values of p1, p2, p3: ");
Console.WriteLine(" p1 instance values: ");
DisplayValues(p1);
Console.WriteLine(" p2 instance values: ");
DisplayValues(p2);
Console.WriteLine(" p3 instance values: ");
DisplayValues(p3);

Console.WriteLine();

p1.Age = 32;
p1.BirthDate = Convert.ToDateTime("1900-01-01");
p1.Name = "Frank";
p1.IdInfo.IdNumber = 7878;

Console.WriteLine("Values of p1, p2, p3 after changes to p1: ");
Console.WriteLine(" p1 instance values: ");
DisplayValues(p1);
Console.WriteLine(" p2 instance values (reference values have changed): ");
DisplayValues(p2);
Console.WriteLine(" p3 instance values (everything was kept the same): ");
DisplayValues(p3);


static void DisplayValues(Person p)
{
    Console.WriteLine($"Name: {p.Name}, Age: {p.Age}, BirthDate: {p.BirthDate.ToShortDateString()}");
    Console.WriteLine($"Id: {p.IdInfo.IdNumber}");
}