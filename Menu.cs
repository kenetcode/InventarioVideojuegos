namespace InventarioVideojuegos;

public class Menu
{
    public static int option = 0;
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

    public static void runOptionSelect()
    {
        option = menuOptions();
        bool temp = true;
        
        while (temp)
        {
            switch (option)
            {
                case 1: 
                    Inventario.agregarVideoJuego();
                    option = menuOptions();
                    break;
                case 2:
                    Inventario.listarVideoJuegos();
                    option = menuOptions();
                    break;
                case 3:
                    Inventario.buscarVideoJuego();
                    option = menuOptions();
                    break;
                case 4:
                    Inventario.actualizarStock();
                    option = menuOptions();
                    break;
                case 5:
                    Inventario.estadisticas();
                    option = menuOptions();
                    break;
                case 6:
                    Console.WriteLine("\nGracias por usar el inventario de video juegos");
                    temp = false;
                    return;
                default:
                    Console.WriteLine("\nLa opción seleccionada es inválida, intente nuevamente");
                    option = menuOptions();
                    break;
            }
        }
    }
}