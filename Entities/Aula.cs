namespace UniversityEnrollmentPlatform.Entities
{
    public class Aula
    {
        public int Id { get; set; }
        public int CodigoAula { get; set; }
        public int DepartamentoId { get; set; }
        public Departamento? Departamento { get; set; }
        public List<Materia> Materias { get; set; } = new();
    }
}
