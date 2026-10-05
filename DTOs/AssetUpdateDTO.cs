namespace STB_backend.DTOs
{
    public class AssetUpdateDTO
    {
        //logika
        public string Name { get; set; }
        public string Description { get; set; }
        public string roomId { get; set; }
        public int baseCreditPricePerHour { get; set; }
        public int monthlyDividendCredits { get; set; }
        public string ownerId { get; set; }
        public bool IsActive { get; set; }
    }
}
