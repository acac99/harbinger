namespace Repository
{
    public class MessageRepository : IRepository<MessageDto>
    {
        private HarbingerContext _harbingerContext;

        public MessageRepository(HarbingerContext harbingerContext)
        {
            _harbingerContext = harbingerContext;
        }
        
        public MessageDto Create(MessageDto messageDto)
        {
            _harbingerContext.Messages.Add(messageDto);
            _harbingerContext.SaveChanges();
            return messageDto;
        }
    }
}