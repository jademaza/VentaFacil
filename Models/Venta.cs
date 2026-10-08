public class Venta
{
    public Cliente Cliente { get; set; }
    public Producto Producto { get; set; }
    public int Cantidad { get; set; }
    public decimal Total { get; set; }
}