namespace InventarioVideojuegos;

public class Inventario
{
    List<VideoJuego> videoJuegos = new List<VideoJuego>(100);
    private VideoJuego videoJuego = new VideoJuego();

    public void agregarVideoJuego()
    {
        Console.WriteLine($"Agregue los datos del videojuego {videoJuegos.Count + 1}");
        videoJuego.titulo = ingresarDato("Digite el título: ");
        videoJuego.genero = ingresarDato("Digite el genero: ");
        videoJuego.precio = validarPrecio(ingresarDato("Ingrese el precio del videojuego"));
        videoJuego.cantStock = validarCantStock(ingresarDato("Ingrese la cantidad de stock del videojuego"));
        videoJuegos.Add(videoJuego);
    }

    public void listarVideoJuegos()
    {
        int n = 0;
        foreach (var listVideoJuego in videoJuegos)
        {
            Console.WriteLine($"----------Datos del video juego {n + 1}----------");
            Console.WriteLine($"Nombre: {listVideoJuego.titulo}");
            Console.WriteLine($"Genero: {listVideoJuego.genero}");
            Console.WriteLine($"Precio: {listVideoJuego.precio}");
            Console.WriteLine($"Cantidad de stock: {listVideoJuego.cantStock}");
        }
    }

    public string ingresarDato(string indicacion)
    {
        Console.WriteLine(indicacion);
        string valor = Console.ReadLine();
        return valor;
    }

    public double validarPrecio(string valor)
    {
        double valorDouble;
        
        if (double.TryParse(valor, out valorDouble))
            return valorDouble;
        
        Console.WriteLine("El valor ingresado no es un número válido.");
        string newDato;
    
        do
        {
            newDato = ingresarDato("Por favor ingrese un valor numérico");
        } while (!double.TryParse(newDato, out valorDouble));
    
        return valorDouble;
    }

    public int validarCantStock(string valor)
    {
        int valorInt;
        
        if (int.TryParse(valor, out valorInt))
            return valorInt;
        
        Console.WriteLine("El valor ingresado no es un número entero válido.");
        string newDato;
    
        do
        {
            newDato = ingresarDato("Por favor ingrese un valor numérico entero");
        } while (!int.TryParse(newDato, out valorInt));
    
        return valorInt;
    }
}