namespace InventarioVideojuegos;

public class ValidadorDatos
{
    public static string ingresarDato(string indicacion)
    {
        Console.WriteLine(indicacion);
        string valor = Console.ReadLine();
        return valor;
    }

    public static double validarPrecio(string valor)
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

    public static int validarEntero(string valor)
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