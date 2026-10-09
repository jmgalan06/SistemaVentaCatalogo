namespace SistemaVentaCatalogo.Api.Models;

class ItemCarrito
{
    public int IdItemCarrito { get; set; }
    public int IdCarrito { get; set; }
    public int IdProducto { get; set; }
    public int Cantidad { get; set; }
    public decimal SubTotal { get; set; }
}