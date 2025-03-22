namespace InventarioVideojuegos;

public class VideoJuego
{
    public string titulo { get; set; }
    public string genero { get; set; }
    public double precio { get; set; }
    public int cantStock { get; set; }

    public VideoJuego(string titulo, string genero, double precio, int cantStock)
    {
        this.titulo = titulo;
        this.genero = genero;
        this.precio = precio;
        this.cantStock = cantStock;
    }

    public VideoJuego()
    {
        
    }
}