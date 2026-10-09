namespace SistemaVentaCatalogo.Api.Models;

class Administrador : Usuario
{
    public int IdAdministrador { get; set; }
    public Administrador() => Rol = "Admin";
}
