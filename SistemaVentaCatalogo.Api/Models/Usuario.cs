namespace SistemaVentaCatalogo.Api.Models;

class Usuario
{
    public int Id { get; set; }
    public string Nombre { get; set; } = string.Empty;
    public string Correo { get; set; } = string.Empty;
    public string Contrasenia { get; set; } = string.Empty;
    public string Rol { get; set; } = string.Empty;
}