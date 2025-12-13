using Singleton;

var instanceA = AppConfig.Instance;

var instanceB = AppConfig.Instance;

Console.WriteLine($"Instance B: {instanceB.EnvironmentName}");

Console.WriteLine(ReferenceEquals(instanceA, instanceB));

instanceA.SetEnvironment("Staging");

Console.WriteLine($"Instance B: {instanceB.EnvironmentName}");