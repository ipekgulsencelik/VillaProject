using MongoDB.Bson;

namespace Villa.DTO.DTOs.CounterDTOs
{
    public class UpdateCounterDTO
    {
        public ObjectId ID { get; set; }
        public string Title { get; set; }
        public string Count { get; set; }
    }
}