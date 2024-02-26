﻿using MongoDB.Bson;

namespace Villa.DTO.DTOs.ContactDTOs
{
    public class UpdateContactDTO
    {
        public ObjectId ID { get; set; }
        public string MapURL { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}