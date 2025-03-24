namespace InventarioVideojuegos;

/// <summary>
/// Clase que ayuda a validar datos ingresados por el usuario.
/// Nos asegura que los valores usados en el programa sean correctos.
/// </summary>
public class ValidadorDatos
{
    /// <summary>
    /// Muestra un mensaje al usuario y captura lo que ingresa por teclado
    /// </summary>
    /// <param name="indicacion">El mensaje que se mostrará al usuario</param>
    /// <returns>El texto ingresado por el usuario</returns>
    public static string ingresarDato(string indicacion)
    {
        Console.WriteLine(indicacion);
        string valor = Console.ReadLine();
        return valor;
    }

    /// <summary>
    /// Valida que un valor ingresado sea un número decimal válido (precio).
    /// Si no es válido, pide al usuario que lo ingrese nuevamente.
    /// </summary>
    /// <param name="valor">El texto a validar</param>
    /// <returns>El número decimal validado</returns>
    public static double validarPrecio(string valor)
    {
        double valorDouble;
        
        // Intentamos convertir el valor a double
        if (double.TryParse(valor, out valorDouble))
            return valorDouble;
        
        // Si no pudimos convertirlo, pedimos que lo ingrese de nuevo
        Console.WriteLine("El valor ingresado no es un número válido.");
        string newDato;
    
        do
        {
            newDato = ingresarDato("Por favor ingrese un valor numérico");
        } while (!double.TryParse(newDato, out valorDouble));
    
        return valorDouble;
    }

    /// <summary>
    /// Valida que un valor ingresado sea un número entero válido (para cantidades).
    /// Si no es válido, pide al usuario que lo ingrese nuevamente.
    /// </summary>
    /// <param name="valor">El texto a validar</param>
    /// <returns>El número entero validado</returns>
    public static int validarEntero(string valor)
    {
        int valorInt;

        // Intentamos convertir el valor a entero
        if (int.TryParse(valor, out valorInt))
            return valorInt;

        // Si no pudimos convertirlo, pedimos que lo ingrese de nuevo
        Console.WriteLine("El valor ingresado no es un número entero válido.");
        string newDato;

        do
        {
            newDato = ingresarDato("Por favor ingrese un valor numérico entero");
        } while (!int.TryParse(newDato, out valorInt));

        return valorInt;
    }
}
