module Repository.Message
open System

type Message =
    {
        Id: Guid
        Text: String
        CreatedAt: DateTime
        UpdatedAt: DateTime
    }