namespace Villa.DTO.DTOs.MessageDTOs
{
    public class CreateMessageDTO
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
        public DateTime MessageDate { get; set; }
    }
}