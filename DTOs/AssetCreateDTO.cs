namespace STB_backend.DTOs
{
    public class AssetCreateDTO
    {
        //logika
        public string Name { get; set; }
        public string Description { get; set; }
        public string roomId { get; set; }
        public int baseCreditPricePerHour { get; set; }
        public int monthlyDividendCredits { get; set; }
        public string ownerId { get; set; }
    }
}
