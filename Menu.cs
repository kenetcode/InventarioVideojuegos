namespace InventarioVideojuegos;

/// <summary>
/// Clase que maneja el menú de la aplicación y procesa las selecciones del usuario.
/// </summary>
public class Menu
{
    // Variable que almacena la opción seleccionada por el usuario
    public static int option = 0;
    
    /// <summary>
    /// Muestra las opciones del menú y captura la selección del usuario
    /// </summary>
    /// <returns>El número de opción seleccionada</returns>
    public static int menuOptions()
    {
        Console.WriteLine("\nA continuación digite el número de opción que desea realizar-----\n");
        Console.WriteLine("-----1. Agregar nuevo videojuego----------");
        Console.WriteLine("-----2. Mostrar todos los videojuegos-----");
        Console.WriteLine("-----3. Buscar videojuego por título------");
        Console.WriteLine("-----4. Actualizar stock------------------");
        Console.WriteLine("-----5. Mostrar estadísticas--------------");
        Console.WriteLine("-----6. Salir-----------------------------");

        option = ValidadorDatos.validarEntero(ValidadorDatos.ingresarDato("Ingrese la opción que desea realizar:"));

        return option;
    }

    /// <summary>
    /// Ejecuta la opción seleccionada por el usuario y mantiene el programa
    /// en funcionamiento hasta que el usuario decida salir
    /// </summary>
    public static void runOptionSelect()
    {
        option = menuOptions();
        bool temp = true;
        
        // Ciclo principal del programa
        while (temp)
        {
            switch (option)
            {
                case 1: 
                    // Agregar un nuevo videojuego
                    Inventario.agregarVideoJuego();
                    option = menuOptions();
                    break;
                case 2:
                    // Listar todos los videojuegos
                    Inventario.listarVideoJuegos();
                    option = menuOptions();
                    break;
                case 3:
                    // Buscar un videojuego por título
                    Inventario.buscarVideoJuego();
                    option = menuOptions();
                    break;
                case 4:
                    // Actualizar stock de un videojuego
                    Inventario.actualizarStock();
                    option = menuOptions();
                    break;
                case 5:
                    // Mostrar estadísticas del inventario
                    Inventario.estadisticas();
                    option = menuOptions();
                    break;
                case 6:
                    // Salir de la aplicación
                    Console.WriteLine("\nGracias por usar el inventario de video juegos");
                    temp = false;
                    return;
                default:
                    // Opción inválida
                    Console.WriteLine("\nLa opción seleccionada es inválida, intente nuevamente");
                    option = menuOptions();
                    break;
            }
        }
    }
}
