namespace SistemaVentaCatalogo.Api.Models;

class SeguimientoPedido
{
    public int IdSeguimiento { get; set; }
    public int IdPedido { get; set; }
    public DateTime Fecha { get; set; }
    public string Estado { get; set; } = string.Empty;
    public string Comentario { get; set; } = string.Empty;
}