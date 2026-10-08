public class VentaService
{
    public decimal CalcularTotal(decimal precio, int cantidad)
    {
        return precio * cantidad;
    }

    public decimal AplicarDescuento(decimal total, decimal porcentaje)
    {
        return total - (total * porcentaje / 100);
    }
}