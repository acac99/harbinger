module Application.MessageHandler

open MediatR
open Domain.MessageCommands
open Domain.Message
open Repository
open Domain
open System.Threading.Tasks

type MessageCreateCommandHandler(messageRepository : IRepository<MessageDto>) =
    interface IRequestHandler<CreateMessageCommand, CreateCommandResult<bool>> with
        member this.Handle(request : CreateMessageCommand,
                           cancellationToken : System.Threading.CancellationToken) : System.Threading.Tasks.Task<CreateCommandResult<bool>> =
            let newMessage = Message.CreateMessage request
            let messageDto = new MessageDto (newMessage.Id, newMessage.Text, newMessage.CreatedAt, newMessage.UpdatedAt)
            sprintf "%A" messageDto.Text |> ignore
 
            messageRepository.Create messageDto |> ignore
            Task.FromResult { result = true }
            
            
