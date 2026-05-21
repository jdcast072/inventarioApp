# Sistema de Gestión de Inventario

Sistema de gestión de inventario - Curso de Platzi - .NET Fundamentals

## Requisitos
.NET version: 10 SDK

## Estructura del proyecto

InventarioApp/
- Program.cs # Punto de entrada
- InventarioApp. csproj # Configuracion
- .gitignore # Archivos ignorados por Git
- src/

## `args`, `stdin` y `stdout` 

Se modifica el código del archivo Program.cs para agregar una banner, condicional tipo interruptor (`switch`) y argumentos CLI para mostrar por **argumentos CLI** de flags de ayuda (`--help`) y la versión actual del proyecto (`--version`).
Además, se agrega un modo interactivo de prueba con un prompt básico para salir de **InventarioApp**.

### Cálculo de operación entre cantidad de **productos** por el **valor** de cada producto 

Se añade un cálculo de operaciones por entrada del usuario para que pueda añadir la cantidad de productos disponibles y cuánto vale cada producto. Además, se agrega la **anulabilidad segura** junto con un bucle `while` en caso de que la entrada de usuario sea nula o sin valor.
```
Ejemplo:
Ingrese una cantidad: 500
Cantidad: 500
Ingrese un precio: 15
Precio validado: $15.00
Valor total del inventario actualizado:: 7,500.00
Ingrese un comando o (use 'salir' para terminar): salir
Hasta luego. Saliendo...

```

---
### Autor
Juan Diego Castañeda

### Tutor Platzi
Sebastian Martinez

### Progreso del curso
- [x] Módulo 1: Ecosistema .NET.
- [x] Módulo 2: Entradas y salidas con args
