namespace UniversityEnrollmentPlatform.Entities
{
    public class Departamento
    {
        public int Id { get; set; }
        public required string Nombre { get; set; }
        public required ICollection<Carrera> Carrera { get; set; }
        public required ICollection<Aula> Aula { get; set; }
    }
}
