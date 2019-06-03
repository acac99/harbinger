module Domain.MessageCommands
open MediatR
open System.ComponentModel.DataAnnotations
open Message


type CreateCommandResult = {
    result: Message
}


type CreateMessageCommand =
    {
        [<Required>]
        Text: string
    }
    interface IRequest<CreateCommandResult>
    
