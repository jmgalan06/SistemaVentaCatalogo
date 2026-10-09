namespace SistemaVentaCatalogo.Api.Models;

class Producto
{
    public int IdProducto { get; set; }
    public int IdCategoria { get; set; }
    public string Nombre { get; set; } = string.Empty;
    public string Descripcion { get; set; } = string.Empty;
    public decimal Precio { get; set; }
    public int Stock { get; set; }
    public bool EsDescuento { get; set; } = false;
    public string ImagenUrl { get; set; } = string.Empty;
}