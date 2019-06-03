using AutoMapper;
using Domain;

namespace Repository
{
    public class MessageRepository : IRepository<Message.Message>
    {
        private HarbingerContext _harbingerContext;
        private IMapper _mapper;

        public MessageRepository(HarbingerContext harbingerContext, IMapper mapper)
        {
            _harbingerContext = harbingerContext;
            _mapper = mapper;
        }
        
        public Message.Message Create(Message.Message message)
        {
            var messageDto = _mapper.Map<Message.Message, MessageDto>(message);
            _harbingerContext.Messages.Add(messageDto);
            _harbingerContext.SaveChanges();
            return _mapper.Map<MessageDto, Message.Message>(messageDto);
        }
    }
}