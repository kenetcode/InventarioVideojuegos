namespace InventarioVideojuegos;

/// <summary>
/// Clase principal que inicia la aplicación de inventario de videojuegos.
/// </summary>
class Program
{
    /// <summary>
    /// Punto de entrada de la aplicación.
    /// Muestra un mensaje de bienvenida y arranca el menú de opciones.
    /// </summary>
    static void Main(string[] args)
    {
        Console.WriteLine("\nSistema de Géstion de Inventario de Videojuegos------------------");
        Menu.runOptionSelect();
    }
}
