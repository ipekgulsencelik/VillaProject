using MongoDB.Bson;

namespace Villa.DTO.DTOs.VideoDTOs
{
    public class ResultVideoDTO
    {
        public ObjectId ID { get; set; }
        public string VideoURL { get; set; }
    }
}