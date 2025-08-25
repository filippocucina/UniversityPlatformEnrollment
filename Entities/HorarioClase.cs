namespace UniversityEnrollmentPlatform.Entities
{
    public class HorarioClase
    {
        public int Id { get; set; }
        public int MateriaId { get; set; } //Foreign Key
        public int AulaId { get; set; } //Foreign Key
        public int PeriodoAcademicoId { get; set; } //Foreign Key
        public required DayOfWeek Dia { get; set; }
        public required TimeOnly HoraInicio { get; set; }
        public required TimeOnly HoraFin { get; set; }
        public required TimeOnly HoraTeoria { get; set; }
        public required TimeOnly HoraPractica { get; set; }
        public Materia? Materia { get; set; }
        public Aula? Aula { get; set; }
        public PeriodoAcademico? PeriodoAcademico { get; set; }
    }
}
