namespace UniversityEnrollmentPlatform.Entities
{
    public class Materia
    {
        public int Id { get; set; }
        public required string Nombre { get; set; }
        public required string Codigo { get; set; }
        public required string TipoMateria { get; set; }
        public required string Descripcion { get; set; }
        public required int UnidadesCredito { get; set; }
        public int AulaId { get; set; }
        public Aula Aula { get; set; } = null!;
        public List<CarreraMateria> CarreraMaterias { get; set; } = new List<CarreraMateria>(); //N:M 
        public required ICollection<HorarioClase> HorarioClases { get; set; }
    }
}
