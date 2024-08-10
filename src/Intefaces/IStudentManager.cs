namespace Interfaces
{
    /// <summary>
    /// Интерфейс для управления студентами.
    /// </summary>
    public interface IStudentManager
    {
        /// <summary>
        /// Добавляет нового студента.
        /// </summary>
        /// <param name="lastName">Фамилия студента.</param>
        /// <param name="firstName">Имя студента.</param>
        /// <param name="group">Название группы.</param>
        void AddStudent(string lastName, string firstName, string group);

        /// <summary>
        /// Отображает всех студентов.
        /// </summary>
        void DisplayAllStudents();

        /// <summary>
        /// Отображает студента с самым высоким средним баллом.
        /// </summary>
        void DisplayTopStudent();

        /// <summary>
        /// Получает ввод от пользователя.
        /// </summary>
        /// <param name="prompt">Сообщение для пользователя.</param>
        /// <returns>Введенное значение.</returns>
        string GetInput(string prompt);
    }
}
