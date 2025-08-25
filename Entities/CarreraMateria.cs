namespace UniversityEnrollmentPlatform.Entities
{
    public class CarreraMateria
    {
        public int CarreraId { get; set; } //Foreign Key
        public int MateriaId { get; set; } //Foreign Key
        public Carrera Carrera { get; set; } = null!;
        public Materia Materia { get; set; } = null!;
    }
}
