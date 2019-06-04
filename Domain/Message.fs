module Domain.Message

open System

type MessageRequest =
    { Text : string }

type Message =
    { Id : Guid
      Text : string
      CreatedAt : DateTime
      UpdatedAt : DateTime }

    static member CreateMessage(messageRequest : MessageRequest) =
        let newMessage =
            { Id = Guid.Empty
              Text = messageRequest.Text
              CreatedAt = DateTime.MinValue
              UpdatedAt = DateTime.MinValue }
        newMessage
    
    member __.UpdateMessage(messageRequest : MessageRequest) =
      let updatedMessage = { __ with Text = messageRequest.Text }
      updatedMessage

