using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Interfaces;
using Models;

namespace Classes
{
    /// <summary>
    /// Реализация интерфейса IStudentManager для управления студентами.
    /// </summary>
    public class StudentManager : IStudentManager
    {
        private readonly ApplicationDbContext _context;

        /// <summary>
        /// Конструктор класса StudentManager.
        /// </summary>
        /// <param name="context">Контекст базы данных.</param>
        public StudentManager(ApplicationDbContext context)
        {
            _context = context;
            _context.Database.EnsureCreated(); // Создание базы данных, если она не существует
        }

        /// <summary>
        /// Добавляет нового студента в базу данных.
        /// </summary>
        public void AddStudent(string lastName, string firstName, string group)
        {
            var student = new Student { LastName = lastName, FirstName = firstName, GroupName = group };
            _context.Students.Add(student);
            _context.SaveChanges();
        }

        /// <summary>
        /// Отображает всех студентов.
        /// </summary>
        public void DisplayAllStudents()
        {
            var students = _context.Students.ToList();
            Console.WriteLine("Список студентов:");
            foreach (var student in students)
            {
                Console.WriteLine($"ID: {student.Id}, Фамилия: {student.LastName}, Имя: {student.FirstName}, Группа: {student.GroupName}");
            }
        }

        /// <summary>
        /// Отображает студента с самым высоким средним баллом.
        /// </summary>
        public void DisplayTopStudent()
        {
            var topStudent = _context.Students
                .Select(s => new
                {
                    s.LastName,
                    s.FirstName,
                    s.GroupName,
                    AverageGrade = (_context.MathGrades.Where(g => g.LastName == s.LastName).Average(g => g.Value) +
                                   _context.ProgGrades.Where(g => g.LastName == s.LastName).Average(g => g.Value))/2
                })
                .OrderByDescending(s => s.AverageGrade)
                .FirstOrDefault();

            if (topStudent != null)
            {
                Console.WriteLine($"Студент с самым высоким средним баллом: {topStudent.LastName} {topStudent.FirstName}, Группа: {topStudent.GroupName}, Средний балл: {topStudent.AverageGrade}");
            }
            else
            {
                Console.WriteLine("Нет данных о студентах.");
            }
        }

        /// <summary>
        /// Получает ввод от пользователя.
        /// </summary>
        public string GetInput(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }
    }
}
