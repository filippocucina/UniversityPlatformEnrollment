using Microsoft.EntityFrameworkCore;
using UniversityEnrollmentPlatform.Entities;

namespace UniversityEnrollmentPlatform.Data
{
    public class UniversityPlatformContext(DbContextOptions<UniversityPlatformContext> options) : DbContext(options)
    {
        public DbSet<Administrador> Administradores => Set<Administrador>();
        public DbSet<Aula> Aulas => Set<Aula>();
        public DbSet<Carrera> Carreras => Set<Carrera>();
        public DbSet<CarreraMateria> CarreraMaterias => Set<CarreraMateria>();
        public DbSet<Departamento> Departamentos => Set<Departamento>();
        public DbSet<Estudiante> Estudiantes => Set<Estudiante>();
        public DbSet<EstudianteMateria> EstudianteMaterias => Set<EstudianteMateria>();
        public DbSet<HorarioClase> HorarioClases => Set<HorarioClase>();
        public DbSet<InscripcionEstudiante> InscripcionEstudiantes => Set<InscripcionEstudiante>();
        public DbSet<Materia> Materias => Set<Materia>();
        public DbSet<Pago> Pagos => Set<Pago>();
        public DbSet<PeriodoAcademico> PeriodoAcademicos=> Set<PeriodoAcademico>();
        public DbSet<Profesor> Profesores => Set<Profesor>();
        public DbSet<ProfesorMateria> ProfesorMaterias => Set<ProfesorMateria>();
        public DbSet<Usuario> Usuarios => Set<Usuario>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CarreraMateria>()
                .HasKey(cm => new { cm.CarreraId, cm.MateriaId });

            modelBuilder.Entity<EstudianteMateria>()
                .HasKey(cm => new { cm.EstudianteId, cm.MateriaId });

            modelBuilder.Entity<ProfesorMateria>()
                .HasKey(cm => new { cm.ProfesorId, cm.MateriaId, cm.PeriodoId });
        }
    }
}
