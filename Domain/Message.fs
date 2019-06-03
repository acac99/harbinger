module Domain.Message
open System
open MediatR


type MessageRequest = {
    Text: string
} 


type Message = {
  Id: Guid
  Text: string
  CreatedAt: DateTime
  UpdatedAt: DateTime
} with
  static member CreateMessage (messageRequest: MessageRequest) = 
    let newMessage = {
      Id = Guid.Empty
      Text = messageRequest.Text
      CreatedAt = DateTime.MinValue
      UpdatedAt = DateTime.MinValue
    } 
    newMessage
