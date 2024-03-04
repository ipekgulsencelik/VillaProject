using MongoDB.Bson;

namespace Villa.DTO.DTOs.VideoDTOs
{
    public class UpdateVideoDTO
    {
        public ObjectId ID { get; set; }
        public string VideoURL { get; set; }
    }
}