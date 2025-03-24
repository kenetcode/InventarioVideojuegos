namespace InventarioVideojuegos;

using System.Linq;

/// <summary>
/// Clase que maneja todas las operaciones relacionadas con el inventario de videojuegos.
/// Contiene métodos para agregar, listar, buscar y actualizar videojuegos.
/// </summary>
public class Inventario
{
    // Lista que almacena todos los videojuegos del inventario (con capacidad inicial para 100)
    public static List<VideoJuego> videoJuegos = new List<VideoJuego>(100);
    
    /// <summary>
    /// Agrega un nuevo videojuego al inventario solicitando sus datos al usuario
    /// </summary>
    public static void agregarVideoJuego()
    {
        VideoJuego videoJuego = new VideoJuego();
        Console.WriteLine($"\nAgregue los datos del videojuego {videoJuegos.Count + 1}");
        videoJuego.titulo = ValidadorDatos.ingresarDato("\nDigite el título: ");
        videoJuego.genero = ValidadorDatos.ingresarDato("\nDigite el genero: ");
        videoJuego.precio = ValidadorDatos.validarPrecio(ValidadorDatos.ingresarDato("\nIngrese el precio del videojuego"));
        videoJuego.cantStock = ValidadorDatos.validarEntero(ValidadorDatos.ingresarDato("\nIngrese la cantidad de stock del videojuego"));
        videoJuegos.Add(videoJuego);
        Console.WriteLine("\nPresione cualquier tecla para continuar ...");
        Console.ReadLine();
    }

    /// <summary>
    /// Muestra todos los videojuegos disponibles en el inventario
    /// con su información detallada
    /// </summary>
    public static void listarVideoJuegos()
    {
        int n = 0;
        foreach (var listVideoJuego in videoJuegos)
        {
            n++;
            Console.WriteLine($"----------Datos del video juego {n}----------");
            Console.WriteLine($"Nombre: {listVideoJuego.titulo}");
            Console.WriteLine($"Genero: {listVideoJuego.genero}");
            Console.WriteLine($"Precio: {listVideoJuego.precio}");
            Console.WriteLine($"Cantidad de stock: {listVideoJuego.cantStock}");
        }
        Console.WriteLine("\nPresione cualquier tecla para continuar ...");
        Console.ReadLine();
    }

    /// <summary>
    /// Permite buscar un videojuego por su título y muestra su información
    /// si lo encuentra en el inventario
    /// </summary>
    public static void buscarVideoJuego()
    {
        // Pedimos el título y lo convertimos a minúsculas para hacer una búsqueda sin distinguir mayúsculas/minúsculas
        string titulo = ValidadorDatos.ingresarDato("\nIngrese el titulo del video juego que quiere buscar: ").ToLower();
        
        string tituloTemp = "";
        int n = 0;
        foreach (var videoJuego in videoJuegos)
        {
            videoJuego.titulo = videoJuego.titulo.ToLower();
            
            // Si encontramos el juego, mostramos sus datos
            if (videoJuego.titulo == titulo)
            {
                Console.WriteLine("\n----------Los datos del video juego solicitado son: ---");
                Console.WriteLine($"----------Datos del video juego {n + 1}----------------");
                Console.WriteLine($"Nombre: {videoJuego.titulo}");
                Console.WriteLine($"Genero: {videoJuego.genero}");
                Console.WriteLine($"Precio: {videoJuego.precio}");
                Console.WriteLine($"Cantidad de stock: {videoJuego.cantStock}");
                tituloTemp = videoJuego.titulo;
            }
            n++;
        }

        // Si no encontramos el juego, mostramos un mensaje
        if (tituloTemp != titulo)
        {
            Console.WriteLine("\nLo sentimos, su video juego no a sido encontrado");
        }
        Console.WriteLine("\nPresione cualquier tecla para continuar ...");
        Console.ReadLine();
    }

    /// <summary>
    /// Permite actualizar la cantidad en stock de un videojuego específico
    /// </summary>
    public static void actualizarStock()
    {
        // Pedimos el título y lo convertimos a minúsculas para la búsqueda
        string titulo = ValidadorDatos.ingresarDato("\nIngrese el titulo del video juego al que quiere actualizarle el stock: ").ToLower();
        
        string tituloTemp = "";
        int n = 0;

        foreach (var videoJuego in videoJuegos)
        {
            string tituloOriginal = videoJuego.titulo;
            string tituloLower = tituloOriginal.ToLower();

            // Si encontramos el juego, actualizamos su stock
            if (tituloLower == titulo)
            {
                Console.WriteLine($"\nStock actual del video juego {tituloOriginal}: Stock = {videoJuego.cantStock}\n");
                int newStock = ValidadorDatos.validarEntero(ValidadorDatos.ingresarDato($"Ingrese el nuevo stock del video juego {tituloOriginal}"));
                videoJuego.cantStock = newStock;
                Console.WriteLine("\n----------Los datos del video juego actualizado son: ---");
                Console.WriteLine($"----------Datos del video juego {n + 1}-----------------");
                Console.WriteLine($"Nombre: {tituloOriginal}");
                Console.WriteLine($"Genero: {videoJuego.genero}");
                Console.WriteLine($"Precio: {videoJuego.precio}");
                Console.WriteLine($"Cantidad de stock: {videoJuego.cantStock}");
                tituloTemp = videoJuego.titulo;
            }
            n++;
        }
        
        // Si no encontramos el juego, mostramos un mensaje
        if (tituloTemp != titulo)
        {
            Console.WriteLine("\nLo sentimos, su video juego no a sido encontrado");
        }
        Console.WriteLine("\nPresione cualquier tecla para continuar ...");
        Console.ReadLine();
    }

    /// <summary>
    /// Muestra estadísticas generales del inventario:
    /// - Cantidad total de juegos
    /// - Valor total del inventario
    /// - Precio del juego más caro
    /// - Precio del juego más barato
    /// </summary>
    public static void estadisticas()
    {
        double valorTotalInventario = 0;
        double precioMin = 0;
        double precioMax = 0;
        var cantTotalJuegos = videoJuegos.Count;
        int n = 0;
        
        // Creamos un array con los precios para facilitar los cálculos
        double[] arrayPrecios = new double[cantTotalJuegos];

        foreach (var videoJuego in videoJuegos)
        {
            arrayPrecios[n] = videoJuego.precio;
            n++;
        }

        // Calculamos el valor total del inventario
        for (int i = 0; i < arrayPrecios.Length; i++)
        {
            valorTotalInventario = valorTotalInventario + arrayPrecios[i];
        }

        // Obtenemos el precio mínimo y máximo usando LINQ
        precioMin = arrayPrecios.Min();
        precioMax = arrayPrecios.Max();
        
        // Mostramos las estadísticas
        Console.WriteLine($"\nLa cantidad total de Video Juegos Almacenados = {cantTotalJuegos} Juegos");
        Console.WriteLine($"\nEl valor total del inventario es ${valorTotalInventario}");
        Console.WriteLine($"\nEl juego más caro tiene un valor de ${precioMax}");
        Console.WriteLine($"\nEl juego más barato tiene un valor de ${precioMin}");
        Console.ReadLine();
    }
}
