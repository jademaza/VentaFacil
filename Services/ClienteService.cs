using System.Linq;

public class ClienteService
{
    public bool NombreValido(string nombre)
    {
        return !string.IsNullOrWhiteSpace(nombre);
    }

    public bool DocumentoValido(string documento)
    {
        return !string.IsNullOrWhiteSpace(documento)
            && documento.Length == 8
            && documento.All(char.IsDigit);
    }
}