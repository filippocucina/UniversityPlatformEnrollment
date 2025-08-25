namespace UniversityEnrollmentPlatform.Entities
{
    public class Usuario
    {
        public int Id { get; set; } 
        public required string Nombre { get; set; }
        public required string Apellido { get; set; }
        public required string Cedula { get; set; }
        public required string Correo { get; set; }
        public required string Clave { get; set; }
        public required string Telefono { get; set; }
        public required string TipoUsuario { get; set; }

        //Referencias Relacion 1:1 para la Navegacion
        public Estudiante? Estudiante { get; set; }
        public Profesor? Profesor { get; set; }
        public Administrador? Administrador { get; set; }
    }
}
