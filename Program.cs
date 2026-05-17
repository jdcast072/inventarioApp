using System.Reflection;

var assembly = Assembly.GetExecutingAssembly();
var version = assembly.GetName().Version;

Console.WriteLine("Hello, World!");
Console.WriteLine("╔══════════════════════════════════════╗");
Console.WriteLine("║   SISTEMA DE GESTIÓN DE INVENTARIO   ║");
Console.WriteLine("╚══════════════════════════════════════╝");
Console.WriteLine();
Console.WriteLine($"Versión del programa: {version}");
Console.WriteLine($".NET version: {Environment.Version}");
Console.WriteLine($"Plataforma del SO: {Environment.OSVersion.Platform}");
Console.WriteLine($"Nombre ejecutado del programa: {assembly}");
Console.WriteLine("📁 Estructura:");
Console.WriteLine("   ✓ Configuración .csproj");
Console.WriteLine("   ✓ Estructura src/Models/");
Console.WriteLine("   ✓ .gitignore configurado");
Console.WriteLine("   ✓ README.md documentado");
Console.WriteLine();
Console.WriteLine("═══════════════════════════════════════");
Console.WriteLine("  ✓ MÓDULO 1 COMPLETADO");
Console.WriteLine("  → Siguiente: Módulo 2 - CLI interactiva");
Console.WriteLine("═══════════════════════════════════════");