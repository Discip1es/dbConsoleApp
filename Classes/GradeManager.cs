using System;
using Interfaces;
using Models;

namespace Classes
{
    /// <summary>
    /// Реализация интерфейса IGradeManager для управления оценками.
    /// </summary>
    public class GradeManager : IGradeManager
    {
        private readonly ApplicationDbContext _context;

        /// <summary>
        /// Конструктор класса GradeManager.
        /// </summary>
        /// <param name="context">Контекст базы данных.</param>
        public GradeManager(ApplicationDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Добавляет оценку для студента.
        /// </summary>
        public void AddGrade(string tableName, string lastName, double grade)
        {
            var gradeEntry = new Grade { LastName = lastName, Value = grade };
            if (tableName == "mathGrades")
            {
                _context.MathGrades.Add(gradeEntry);
            }
            else if (tableName == "progGrades")
            {
                _context.ProgGrades.Add(gradeEntry);
            }
            _context.SaveChanges();
        }

        /// <summary>
        /// Получает оценку от пользователя.
        /// </summary>
        public double GetGrade(string prompt)
        {
            double grade;
            while (true)
            {
                Console.Write(prompt);
                if (double.TryParse(Console.ReadLine(), out grade) && grade >= 0 && grade <= 5)
                {
                    return grade;
                }
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите оценку от 0 до 5.");
            }
        }
    }
}
