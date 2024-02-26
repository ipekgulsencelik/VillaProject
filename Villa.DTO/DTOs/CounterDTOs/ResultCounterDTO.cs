using MongoDB.Bson;

namespace Villa.DTO.DTOs.CounterDTOs
{
    public class ResultCounterDTO
    {
        public ObjectId ID { get; set; }
        public string Title { get; set; }
        public string Count { get; set; }
    }
}