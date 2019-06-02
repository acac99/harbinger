module Repository.MessageRepository

open Repository.HarbingerContext
open Repository.Message
open Repository.RepositoryInterfaces

type MessageRepository(harbingerContext: HarbingerContext) =
    member this.HarbingerContex = harbingerContext
    
    interface IRepository<Message> with
        member this.Create(message) =
            async {
                this.HarbingerContex.messages.AddAsync(message) |> Async.AwaitTask |> ignore
                this.HarbingerContex.SaveChangesAsync() |> Async.AwaitTask |>ignore
                return message
            }
        


