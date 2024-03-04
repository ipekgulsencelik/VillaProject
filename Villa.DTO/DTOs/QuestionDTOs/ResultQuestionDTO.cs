using MongoDB.Bson;

namespace Villa.DTO.DTOs.QuestionDTOs
{
    public class ResultQuestionDTO
    {
        public ObjectId ID { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
    }
}