namespace UniversityEnrollmentPlatform.Entities
{
    public class Pago
    {  
        public int Id { get; set; }
        public required double Monto { get; set; }
        public required DateTime FechaPago { get; set; }
        public required string FormaPago { get; set; }
        public required bool ConfirmadoPago { get; set; }
        public InscripcionEstudiante InscripcionEstudiante { get; set; } = null!;
    }
}
