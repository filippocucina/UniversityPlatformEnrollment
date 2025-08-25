namespace UniversityEnrollmentPlatform.Entities
{
    public class Carrera
    {
        public int Id { get; set; }
        public required string Nombre { get; set; }
        public required int Semestre { get; set; }
        public int DepartamentoId { get; set; } //Foreign Key
        public Departamento? Departamento { get; set; }
        public List<CarreraMateria> CarreraMaterias { get; set; } = new List<CarreraMateria>();
    }
}
