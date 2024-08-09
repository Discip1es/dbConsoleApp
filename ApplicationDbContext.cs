using Microsoft.EntityFrameworkCore;
using Models;

/// <summary>
/// Контекст базы данных для управления студентами и оценками.
/// </summary>
public class ApplicationDbContext : DbContext
{
    /// <summary>
    /// Набор студентов в базе данных.
    /// </summary>
    public DbSet<Student> Students { get; set; }

    /// <summary>
    /// Набор оценок по математике.
    /// </summary>
    public DbSet<Grade> MathGrades { get; set; }

    /// <summary>
    /// Набор оценок по программированию.
    /// </summary>
    public DbSet<Grade> ProgGrades { get; set; }

    /// <summary>
    /// Конфигурация контекста базы данных.
    /// </summary>
    /// <param name="optionsBuilder">Параметры конфигурации.</param>
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=students.db");
    }
}
