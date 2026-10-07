public class ClienteService
{
    public bool NombreValido(string nombre)
    {
        return !string.IsNullOrWhiteSpace(nombre);
    }
}