module Domain.MessageCommands

open MediatR
open System.ComponentModel.DataAnnotations
open Message
open System

type CreateCommandResult =
    { result : Message }

type CreateMessageCommand =
    { [<Required>]
      Text : string }
    interface IRequest<CreateCommandResult>

type UpdateCommandResult =
    { isSuccessful : bool }

type UpdateMessageCommand =
    { [<Required>]
      Id : Guid
      [<Required>]
      Text : string }
    interface IRequest<UpdateCommandResult>
