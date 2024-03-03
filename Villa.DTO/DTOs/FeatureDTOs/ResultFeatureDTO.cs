using MongoDB.Bson;

namespace Villa.DTO.DTOs.FeatureDTOs
{
    public class ResultFeatureDTO
    {
        public ObjectId ID { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string ImageURL { get; set; }
        public string Square { get; set; }
        public string Contract { get; set; }
        public string Payment { get; set; }
        public bool HasSafety { get; set; }
    }
}