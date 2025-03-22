namespace InventarioVideojuegos;

public class VideoJuego
{
    private string titulo { get; set; }
    private string genero { get; set; }
    private double precio { get; set; }
    private int cantStock { get; set; }

    public VideoJuego(string titulo, string genero, double precio, int cantStock)
    {
        this.titulo = titulo;
        this.genero = genero;
        this.precio = precio;
        this.cantStock = cantStock;
    }
}