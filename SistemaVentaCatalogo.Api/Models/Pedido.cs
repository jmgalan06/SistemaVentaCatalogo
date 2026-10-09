namespace SistemaVentaCatalogo.Api.Models;

class Pedido
{
    public int IdPedido { get; set; }
    public int IdCliente { get; set; }
    public int IdAdministrador { get; set; }
    public DateTime Fecha { get; set; }
    public decimal SubTotal { get; set; }
    public decimal Descuentos { get; set; }
    public decimal Total { get; set; }
    public string Estado { get; set; } = string.Empty;
}