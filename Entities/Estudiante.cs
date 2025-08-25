using Microsoft.EntityFrameworkCore;

namespace UniversityEnrollmentPlatform.Entities
{
    public class Estudiante
    {
        public int Id { get; set; }
        public DateTime FechaCreacionPerfil { get; set; }
        public required bool Activo { get; set; }
        public required DateTime UltimaConexion { get; set; }
        public int UsuarioId { get; set; } //Foreign Key
        public int CarreraId { get; set; } //Foreign Key

        public Carrera? Carrera { get; set; }
        public Usuario? Usuario { get; set; }
        public required ICollection<InscripcionEstudiante> Inscripcion { get; set; }
    }
}
