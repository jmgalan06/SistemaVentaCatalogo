namespace SistemaVentaCatalogo.Api.Models;

class Cliente : Usuario
{
    public int IdCliente { get; set; }
    public Cliente() => Rol = "Cliente";
    public string Telefono { get; set; } = string.Empty;
}