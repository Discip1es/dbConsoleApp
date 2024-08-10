namespace Models
{
    /// <summary>
    /// Модель студента.
    /// </summary>
    public class Student
    {
        /// <summary>
        /// Уникальный идентификатор студента.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Фамилия студента.
        /// </summary>
        public string? LastName { get; set; }

        /// <summary>
        /// Имя студента.
        /// </summary>
        public string? FirstName { get; set; }

        /// <summary>
        /// Название группы студента.
        /// </summary>
        public string? GroupName { get; set; }
    }
}
