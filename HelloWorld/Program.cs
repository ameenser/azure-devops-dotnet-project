using System.Reflection;

var version = Assembly.GetExecutingAssembly()
    .GetName()
    .Version;

Console.WriteLine("Hello, World!");
Console.WriteLine($"Application version: {version}");
