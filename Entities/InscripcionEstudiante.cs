namespace UniversityEnrollmentPlatform.Entities
{
    public class InscripcionEstudiante
    {
        public int Id { get; set; }
        public DateTime FechaInscripcion { get; set; }
        public int PeriodoAcademicoId { get; set; } //Foreign Key
        public int EstudianteId { get; set; } //Foreign Key
        public Estudiante? Estudiante { get; set; }
        public PeriodoAcademico? Academico { get; set; }
        public int PagoId { get; set; } //Foreign Key
        public Pago Pago { get; set; } = null!;
    }
}
