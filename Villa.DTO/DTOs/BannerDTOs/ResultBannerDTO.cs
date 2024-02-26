using MongoDB.Bson;

namespace Villa.DTO.DTOs.BannerDTOs
{
    public class ResultBannerDTO
    {
        public ObjectId ID { get; set; }
        public string City { get; set; }
        public string Title { get; set; }
        public string ImageURL { get; set; }
    }
}