namespace InventarioVideojuegos;

public class Menu
{
    public static void menuOptions()
    {
        Console.WriteLine("\nSistema de Géstion de Inventario de Videojuegos------------------");
        Console.WriteLine("\nA continuación digite el número de opción que desea realizar-----\n");
        Console.WriteLine("-----1. Agregar nuevo videojuego----------");
        Console.WriteLine("-----2. Mostrar todos los videojuegos-----");
        Console.WriteLine("-----3. Buscar videojuego por título------");
        Console.WriteLine("-----4. Actualizar stock------------------");
        Console.WriteLine("-----5. Mostrar estadísticas--------------");
        Console.WriteLine("-----6. Salir-----------------------------");
        Console.ReadLine();
    }
}