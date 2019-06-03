using AutoMapper;
using Domain;

namespace Repository
{
    public class MessageProfile : Profile
    {
        public MessageProfile()
        {
            CreateMap<Message.Message, MessageDto>();
            CreateMap<MessageDto, Message.Message>();
        }
        
    }
}