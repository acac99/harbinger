module Domain.Message
open System
open Domain.MessageCommands

type Message = {
  Id: Guid
  Text: string
  CreatedAt: DateTime
  UpdatedAt: DateTime
} with
  static member CreateMessage (messageRequest: CreateMessageCommand) = 
    let newMessage = {
      Id = Guid.Empty
      Text = messageRequest.Text
      CreatedAt = DateTime.MinValue
      UpdatedAt = DateTime.MinValue
    } 
    newMessage
