using System.Reflection;

var assembly = Assembly.GetExecutingAssembly();
var version = assembly.GetName().Version;
int cantidadProductos = 0;
decimal valorTotalDelInventario = 0.00m;
bool sistemaActivo = true;
string nombreSistema = "Sistema de Gestión de Inventario";
decimal precio;

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

void mostrarBanner() {
Console.WriteLine("╔══════════════════════════════════════╗");
Console.WriteLine("║   SISTEMA DE GESTIÓN DE INVENTARIO   ║");
Console.WriteLine("╚══════════════════════════════════════╝");
Console.WriteLine();
Console.WriteLine($"Versión del programa: {version}");
Console.WriteLine($".NET version: {Environment.Version}");
Console.WriteLine($"Plataforma del SO: {Environment.OSVersion.Platform}");
Console.WriteLine($"Nombre ejecutado del programa: {assembly}");
Console.WriteLine("Estado del sistema");
Console.WriteLine($"Nombre: {nombreSistema}");
Console.WriteLine($"Sistema Activo: {(sistemaActivo ? "Si": "No")}");
}

mostrarBanner();

Console.Write("Ingrese una cantidad: ");
string? entradaCantidad = Console.ReadLine();


// Conversión segura a TryParse
if(int.TryParse(entradaCantidad, out int cantidad)){
    Console.WriteLine($"Cantidad: {cantidad}");
    cantidadProductos = cantidad;
}else {
    Console.Write("Error: debe ingresar un número entero\n");
}

Console.Write("Ingrese un precio: ");
string? entradaPrecio = Console.ReadLine();

if(decimal.TryParse(entradaPrecio, out precio)){
    Console.WriteLine($"Precio validado: {precio:C}");
    valorTotalDelInventario = cantidadProductos * precio;
    Console.WriteLine($"Valor total del inventario actualizado:: {valorTotalDelInventario:N2}");
}

while(sistemaActivo){
    
    Console.Write("\ninventarioApp> ");
    string? input = Console.ReadLine();
    
    //Aplicar el manejo seguro
    string comando = string.IsNullOrEmpty(input) ? "salir" : input.Trim().ToLower();
    switch(comando){
        case "salir":
            sistemaActivo = false;
            Console.WriteLine("Saliendo de la consulta del inventario, Hasta Luego ...!");
            break;
        case "listar":
            Console.WriteLine($"Productos del inventario: {cantidadProductos}");
            break;
        case "":
            break;

        default:
        Console.WriteLine($"Comando '{comando}' no es reconocido.");
        Console.WriteLine("Comandos disponibles: listar, agregar, buscar, salir.");
        break;
    }
}

Console.WriteLine($"Productos registrados: {cantidadProductos}");
Console.WriteLine($"Valor total del inventario: ${valorTotalDelInventario:N2}");

Console.Write("Ingrese un comando o (use 'salir' para terminar): ");
string? entrada = Console.ReadLine(); //Stdin: Lee la entrada del usuario

if (string.IsNullOrWhiteSpace(entrada) || entrada.ToLower() == "salir") {
    Console.WriteLine("Hasta luego. Saliendo... ");//Stdout: Salida del comando o programa
    Environment.Exit(0);
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
