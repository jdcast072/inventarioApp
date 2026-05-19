using System.Reflection;

var assembly = Assembly.GetExecutingAssembly();
var version = assembly.GetName().Version;

if (args.Length > 0){
    switch (args[0].ToLower())
    {
        case "--help":
            mostrarAyuda();
            Environment.Exit(0);
            break;
        case "--version":
            Console.WriteLine($"Versión de InventarioApp v{version}");
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine($"Error, opción desconocida: {args[0]}");
            Console.WriteLine($"Use --help para ver las opciones disponibles.");
            Environment.Exit(2);
            break;
    };
};

mostrarBanner();

Console.Write("Ingrese un comando o (use 'salir' para terminar): ");
string? entrada = Console.ReadLine(); //Stdin: Lee la entrada del usuario

if (string.IsNullOrWhiteSpace(entrada) || entrada.ToLower() == "salir") {
    Console.WriteLine("Hasta luego. Saliendo... ");//Stdout: Salida del comando o programa
    Environment.Exit(0);
}

void mostrarBanner() {
Console.WriteLine("╔══════════════════════════════════════╗");
Console.WriteLine("║   SISTEMA DE GESTIÓN DE INVENTARIO   ║");
Console.WriteLine("╚══════════════════════════════════════╝");
Console.WriteLine();
Console.WriteLine($"Versión del programa: {version}");
Console.WriteLine($".NET version: {Environment.Version}");
Console.WriteLine($"Plataforma del SO: {Environment.OSVersion.Platform}");
Console.WriteLine($"Nombre ejecutado del programa: {assembly}");
}

// Modo interactgivo si no hay args
// Write: Sirve para mostrar un mensaje al usuario sin saltos de línea, ideal para prompts


void mostrarAyuda() {
    Console.WriteLine("Uso: inventarioApp [comando] [opciones]");
    Console.WriteLine();
    Console.WriteLine("Comandos:");
    Console.WriteLine("  --help, -h    Muestra esta ayuda");
    Console.WriteLine("  --version, -v    Muestra la versión del programa");
    Console.WriteLine();
    Console.WriteLine("Ejemplos:");
    Console.WriteLine("  dotnet run -- --help");
    Console.WriteLine("  dotnet run -- --version");
    Console.WriteLine("Si no se proporcionan opciones, el programa se ejecutará en modo interactivo.");
}



/*
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
*/