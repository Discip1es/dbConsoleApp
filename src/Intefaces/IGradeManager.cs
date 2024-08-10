namespace Interfaces
{
    /// <summary>
    /// Интерфейс для управления оценками.
    /// </summary>
    public interface IGradeManager
    {
        /// <summary>
        /// Добавляет оценку для студента.
        /// </summary>
        /// <param name="tableName">Название таблицы оценок.</param>
        /// <param name="lastName">Фамилия студента.</param>
        /// <param name="grade">Значение оценки.</param>
        void AddGrade(string tableName, string lastName, double grade);

        /// <summary>
        /// Получает оценку от пользователя.
        /// </summary>
        /// <param name="prompt">Сообщение для пользователя.</param>
        /// <returns>Введенное значение оценки.</returns>
        double GetGrade(string prompt);
    }
}
