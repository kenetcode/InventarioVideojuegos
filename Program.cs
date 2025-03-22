namespace InventarioVideojuegos;

class Program
{
    static void Main(string[] args)
    {
        Menu.menuOptions();
        
        Inventario inventario = new Inventario();
        inventario.agregarVideoJuego();
        inventario.listarVideoJuegos();
    }
}