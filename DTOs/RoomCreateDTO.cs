namespace STB_backend.DTOs
{
    public class RoomCreateDTO
    {
        //logika
        public string Name { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public int baseCreditPricePerHour { get; set; }
        public int Capacity { get; set; }
    }
}
