module Domain.MessageHandler
open Domain.MessageCommands
open MediatR

type MessageCreateCommandHandler() =
    interface IRequestHandler<CreateMessageCommand, CreateCommandResult<bool>>