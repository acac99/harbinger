module Application.MessageHandler

open MediatR
open Domain.MessageCommands
open Domain.Message
open Repository
open Domain
open System.Threading.Tasks

type MessageCreateCommandHandler(messageRepository : IRepository<Message>) =
    interface IRequestHandler<CreateMessageCommand, CreateCommandResult<bool>> with
        member this.Handle(request : CreateMessageCommand,
                           cancellationToken : System.Threading.CancellationToken) : System.Threading.Tasks.Task<CreateCommandResult<bool>> =
            let newMessage = Message.CreateMessage request
            let messageDto: Message = {
                Id = newMessage.Id
                Text = newMessage.Text
                CreatedAt = newMessage.CreatedAt
                UpdatedAt = newMessage.UpdatedAt
            }
            sprintf "%A" messageDto.Text |> ignore
 
            messageRepository.Create messageDto |> ignore
            Task.FromResult { result = true }
            
            
