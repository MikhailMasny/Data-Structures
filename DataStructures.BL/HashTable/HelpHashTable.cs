namespace DataStructures.BL.HashTable
{
    /// <summary>
    /// Вспомогательный класс для SuperHashTable.
    /// </summary>
    class HelpHashTable
    {
        /// <summary>
        /// Поле один.
        /// </summary>
        public string FieldOne { get; set; }

        /// <summary>
        /// Поле два.
        /// </summary>
        public int FieldTwo { get; set; }

        /// <summary>
        /// Переопределение ToString.
        /// </summary>
        /// <returns>Значение.</returns>
        public override string ToString()
        {
            return FieldOne;
        }

        /// <summary>
        /// Переопределение GetHashCode.
        /// </summary>
        /// <returns>HashCode.</returns>
        public override int GetHashCode()
        {
            return FieldOne.Length + FieldTwo + (int)FieldOne[0];
        }
    }
}
