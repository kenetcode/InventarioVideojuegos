namespace InventarioVideojuegos;

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
        string titulo = ValidadorDatos.ingresarDato("\nIngrese el titulo del video juego que quiere buscar: ");
        
        string tituloTemp = "";
        
        foreach (var videoJuego in videoJuegos)
        {
            int n = 0;
            if (videoJuego.titulo == titulo)
            {
                Console.WriteLine("\n----------Los datos del video juego solicitado son: ---");
                Console.WriteLine($"----------Datos del video juego {n + 1}----------------");
                Console.WriteLine($"Nombre: {videoJuego.titulo}");
                Console.WriteLine($"Genero: {videoJuego.genero}");
                Console.WriteLine($"Precio: {videoJuego.precio}");
                Console.WriteLine($"Cantidad de stock: {videoJuego.cantStock}");
                tituloTemp = videoJuego.titulo;
                n++;
            }
        }

        if (tituloTemp != titulo)
        {
            Console.WriteLine("\nLo sentimos, su video juego no a sido encontrado");
        }
        Console.WriteLine("\nPresione cualquier tecla para continuar ...");
        Console.ReadLine();
    }
}