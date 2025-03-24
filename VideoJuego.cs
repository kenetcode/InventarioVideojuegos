namespace InventarioVideojuegos;

/// <summary>
/// Representa un videojuego en el inventario.
/// Contiene toda la información básica que necesitamos para gestionar un juego.
/// </summary>
public class VideoJuego
{
    // Título del videojuego (ej. "FIFA 2023")
    public string titulo { get; set; }
    
    // Género al que pertenece (ej. "Acción", "Deportes")
    public string genero { get; set; }
    
    // Precio de venta del videojuego en la moneda local
    public double precio { get; set; }
    
    // Cantidad de unidades disponibles en el inventario
    public int cantStock { get; set; }

    /// <summary>
    /// Constructor que inicializa un videojuego con todos sus datos
    /// </summary>
    public VideoJuego(string titulo, string genero, double precio, int cantStock)
    {
        this.titulo = titulo;
        this.genero = genero;
        this.precio = precio;
        this.cantStock = cantStock;
    }

    /// <summary>
    /// Constructor vacío para crear un videojuego sin datos iniciales
    /// (útil cuando pedimos los datos al usuario uno por uno)
    /// </summary>
    public VideoJuego()
    {
        
    }
}
