module Domain.MessageHandler
open Domain.MessageCommands
open MediatR

type MessageCreateCommandHandler() =
    interface IRequestHandler<CreateMessageCommand, CreateCommandResult<bool>> with
        member this.Handle(request: CreateMessageCommand, cancellationToken: System.Threading.CancellationToken): System.Threading.Tasks.Task<CreateCommandResult<bool>> = 
            failwith "Not Implemented"

