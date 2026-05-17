using System.Reflection;

var assembly = Assembly.GetExecutingAssembly();
var version = assembly.GetName().Version;

Console.WriteLine("Hello, World!");
Console.WriteLine($"Plataforma del SO: {Environment.OSVersion.Platform}");
Console.WriteLine($".NET version: {Environment.Version}");
Console.WriteLine($"Versión del programa: {version}");
Console.WriteLine($"Nombre ejecutado del programa: {assembly}");