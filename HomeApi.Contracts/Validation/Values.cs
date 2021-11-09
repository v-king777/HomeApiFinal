namespace HomeApi.Contracts.Validation
{
    /// <summary>
    /// Класс-хранилище допустымых значений для валидаторов
    /// </summary>
    public static class Values
    {
        public static readonly string[] ValidRooms = new[]
        {
            "Кухня",
            "Ванная",
            "Гостиная",
            "Туалет",
            "Спальня",
            "Прихожая"
        };
    }
}
