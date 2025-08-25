namespace UniversityEnrollmentPlatform.Entities
{
    public class Profesor
    {
        public int Id { get; set; }
        public required string CorreoInstitucional { get; set; }
        public required string GradoAcademico { get; set; }
        public required bool Activo { get; set; }
        public required DateTime FechaIngreso { get; set; }
        public required DateTime UltimaConexion { get; set; }
        public required string CV { get; set; }
        public required float Salario { get; set; }
        public required string Especialidad { get; set; }
        public int UsuarioId { get; set; } //Foreign Key
        public Usuario? Usuario { get; set; }
        public required ICollection<ProfesorMateria> AsignacionMaterias { get; set; }
    }
}
