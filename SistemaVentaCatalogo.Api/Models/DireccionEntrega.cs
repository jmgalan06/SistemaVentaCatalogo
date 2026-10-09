namespace SistemaVentaCatalogo.Api.Models;

public class DireccionEntrega
{
    public int IdDireccion { get; set; }
    public string Calle { get; set; } = string.Empty;
    public string Ciudad { get; set; } = string.Empty;
    public string Referencia { get; set; } = string.Empty;
}