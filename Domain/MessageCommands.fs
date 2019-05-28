module Domain.MessageCommands
open MediatR
open System.ComponentModel.DataAnnotations;


type CreateCommandResult<'T> = {
    result: 'T
}


type CreateMessageCommand = {
    [<Required>]
    Text: string
}