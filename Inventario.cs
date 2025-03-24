namespace InventarioVideojuegos;

using System.Linq;

public class Inventario
{
    public static List<VideoJuego> videoJuegos = new List<VideoJuego>(100);
    
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

    public static void buscarVideoJuego()
    {
        string titulo = ValidadorDatos.ingresarDato("\nIngrese el titulo del video juego que quiere buscar: ").ToLower();
        
        string tituloTemp = "";
        int n = 0;
        foreach (var videoJuego in videoJuegos)
        {
            videoJuego.titulo = videoJuego.titulo.ToLower();
            
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

        if (tituloTemp != titulo)
        {
            Console.WriteLine("\nLo sentimos, su video juego no a sido encontrado");
        }
        Console.WriteLine("\nPresione cualquier tecla para continuar ...");
        Console.ReadLine();
    }

    public static void actualizarStock()
    {
        string titulo = ValidadorDatos.ingresarDato("\nIngrese el titulo del video juego al que quiere actualizarle el stock: ").ToLower();
        
        string tituloTemp = "";
        int n = 0;

        foreach (var videoJuego in videoJuegos)
        {
            string tituloOriginal = videoJuego.titulo;
            string tituloLower = tituloOriginal.ToLower();

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
        
        if (tituloTemp != titulo)
        {
            Console.WriteLine("\nLo sentimos, su video juego no a sido encontrado");
        }
        Console.WriteLine("\nPresione cualquier tecla para continuar ...");
        Console.ReadLine();
    }

    public static void estadisticas()
    {
        double valorTotalInventario = 0;
        double precioMin = 0;
        double precioMax = 0;
        var cantTotalJuegos = videoJuegos.Count;
        int n = 0;
        
        double[] arrayPrecios = new double[cantTotalJuegos];

        foreach (var videoJuego in videoJuegos)
        {
            arrayPrecios[n] = videoJuego.precio;
            n++;
        }

        for (int i = 0; i < arrayPrecios.Length; i++)
        {
            valorTotalInventario = valorTotalInventario + arrayPrecios[i];
        }

        precioMin = arrayPrecios.Min();
        precioMax = arrayPrecios.Max();
        
        Console.WriteLine($"\nLa cantidad total de Video Juegos Almacenados = {cantTotalJuegos} Juegos");
        Console.WriteLine($"\nEl valor total del inventario es ${valorTotalInventario}");
        Console.WriteLine($"\nEl juego más caro tiene un valor de ${precioMax}");
        Console.WriteLine($"\nEl juego más barato tiene un valor de ${precioMin}");
        
        
    }
}