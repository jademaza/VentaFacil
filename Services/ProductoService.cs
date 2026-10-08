public class ProductoService
{
    public bool NombreValido(string nombre)
    {
        return !string.IsNullOrWhiteSpace(nombre);
    }

    public bool PrecioValido(decimal precio)
    {
        return precio > 0;
    }
}