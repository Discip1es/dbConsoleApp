namespace Models
{
    /// <summary>
    /// Модель оценки.
    /// </summary>
    public class Grade
    {
        /// <summary>
        /// Уникальный идентификатор оценки.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Фамилия студента, которому принадлежит оценка.
        /// </summary>
        public string? LastName { get; set; }

        /// <summary>
        /// Значение оценки.
        /// </summary>
        public double Value { get; set; }
    }
}
