using System;

namespace Repository
{
    public class Message
    {
        public Guid Id { get; set; }
        
        public string Text { get; set; }
        
        public DateTime CreatedAt { get; set; }
        
        public DateTime UpdatedAt { get; set; }
    }
}