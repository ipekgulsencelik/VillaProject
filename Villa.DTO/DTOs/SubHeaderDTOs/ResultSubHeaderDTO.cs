using MongoDB.Bson;

namespace Villa.DTO.DTOs.SubHeaderDTOs
{
    public class ResultSubHeaderDTO
    {
        public ObjectId ID { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Facebook { get; set; }
        public string Twitter { get; set; }
        public string Linkedin { get; set; }
        public string Instagram { get; set; }
    }
}