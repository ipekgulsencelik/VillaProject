using MongoDB.Bson;

namespace Villa.DTO.DTOs.DealDTOs
{
    public class UpdateDealDTO
    {
        public ObjectId ID { get; set; }
        public string Type { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageURL { get; set; }
        public string Square { get; set; }
        public string Floor { get; set; }
        public int RoomCount { get; set; }
        public bool HasParkingArea { get; set; }
        public string PaymentType { get; set; }
    }
}