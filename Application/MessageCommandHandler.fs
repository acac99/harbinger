module Application.MessageHandler

open MediatR
open Domain.MessageCommands
open Domain.Message
open Repository
open Domain
open System.Threading.Tasks

type MessageCreateCommandHandler(messageRepository : IRepository<Message.Message>) =
    interface IRequestHandler<CreateMessageCommand, CreateCommandResult> with
        
        member __.Handle(request : CreateMessageCommand,
                           _ : System.Threading.CancellationToken) : System.Threading.Tasks.Task<CreateCommandResult> =
            let messageRequest = { Text = request.Text }
            let newMessage = Message.CreateMessage messageRequest
 
            let createdMessage = messageRepository.Create newMessage
            Task.FromResult { result = createdMessage }
            
            
