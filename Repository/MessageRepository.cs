namespace Repository
{
    public class MessageRepository : IRepository<Message>
    {
        private HarbingerContext _harbingerContext;

        public MessageRepository(HarbingerContext harbingerContext)
        {
            _harbingerContext = harbingerContext;
        }
        
        public Message Create(Message message)
        {
            _harbingerContext.Messages.Add(message);
            _harbingerContext.SaveChanges();
            return message;
        }
    }
}