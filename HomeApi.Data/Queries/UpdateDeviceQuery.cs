namespace HomeApi.Data.Queries
{
    /// <summary>
    /// Класс для передачи дополнительных параметров при обновлении устройства
    /// </summary>
    public class UpdateDeviceQuery
    {
        public UpdateDeviceQuery(string newName = null, string newSerial = null)
        {
            NewName = newName;
            NewSerial = newSerial;
        }

        public string NewName { get; }

        public string NewSerial { get; }
    }
}
