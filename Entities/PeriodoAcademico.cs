namespace UniversityEnrollmentPlatform.Entities
{
    public class PeriodoAcademico
    {
        public int Id { get; set; }
        public required string NombrePeriodo { get; set; }
        public required int PeriodoDisponible { get; set; }
        public required bool PeriodoActivo { get; set; }
        public required ICollection<InscripcionEstudiante> InscripcioneEstudiante { get; set; }
    }
}
