namespace UniversityEnrollmentPlatform.Entities
{
    public class Administrador
    { 
        public int Id { get; set; }
        public required DateTime UltimaConexion { get; set; }
        public required bool Activo { get; set; }
        public required string Rol { get; set; }
        public int UsuarioId { get; set; } //Foreign Key
        public Usuario? Usuario { get; set; }
    }
}
