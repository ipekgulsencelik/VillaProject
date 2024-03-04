using MongoDB.Bson;

namespace Villa.DTO.DTOs.QuestionDTOs
{
    public class UpdateQuestionDTO
    {
        public ObjectId ID { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
    }
}