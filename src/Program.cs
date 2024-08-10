using Classes;

class Program
{
    static void Main()
    {
        using var context = new ApplicationDbContext();
        var studentManager = new StudentManager(context);
        var gradeManager = new GradeManager(context);

        while (true)
        {
            Console.WriteLine("Введите данные студента (или 'n' для выхода):");
            string lastName = studentManager.GetInput("Фамилия: ");
            if (lastName.ToLower() == "n") break;

            string firstName = studentManager.GetInput("Имя: ");
            if (firstName.ToLower() == "n") break;

            string group = studentManager.GetInput("Группа: ");
            if (group.ToLower() == "n") break;

            double mathGrade = gradeManager.GetGrade("Оценка по математике: ");
            double programmingGrade = gradeManager.GetGrade("Оценка по программированию: ");

            studentManager.AddStudent(lastName, firstName, group);
            gradeManager.AddGrade("mathGrades", lastName, mathGrade);
            gradeManager.AddGrade("progGrades", lastName, programmingGrade);

            Console.WriteLine("Введите 'y' для ввода следующего студента или 'n' для выхода.");
            if (Console.ReadLine().ToLower() != "n")
            {
                continue;
            }
            break;
        }

        Console.WriteLine("Выберите действие: 1 - Вывести всех студентов, 2 - Студент с самым высоким средним баллом");
        string choice = Console.ReadLine();
        if (choice == "1")
        {
            studentManager.DisplayAllStudents();
        }
        else if (choice == "2")
        {
            studentManager.DisplayTopStudent();
        }
    }
}
