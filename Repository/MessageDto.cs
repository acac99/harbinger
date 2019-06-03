using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository
{
    public class MessageDto
    {
        public MessageDto() 
        {}
        public MessageDto(Guid id, string text, DateTime createdAt, DateTime updatedAt)
        {
            Id = id;
            Text = text;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        
        public string Text { get; set; }
        
        public DateTime CreatedAt { get; set; }
        
        public DateTime UpdatedAt { get; set; }
    }
}