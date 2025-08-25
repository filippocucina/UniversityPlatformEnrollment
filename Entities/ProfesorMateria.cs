namespace UniversityEnrollmentPlatform.Entities
{
    public class ProfesorMateria
    {   
        public int MateriaId { get; set; } //Foreign Key
        public int ProfesorId { get; set; } //Foreign Key
        public int PeriodoId { get; set; } //Foreign Key
        public Materia? Materia { get; set; }
        public Profesor? Profesor { get; set; }
        public PeriodoAcademico? Periodo { get; set; }
    }
}
