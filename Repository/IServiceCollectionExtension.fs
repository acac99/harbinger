[<AutoOpen>]
module Repository.IServiceCollectionExtension

open Microsoft.Extensions.DependencyInjection
open Microsoft.Extensions.DependencyInjection.Extensions
open Repository.HarbingerContext
open Repository.Message
open Repository.MessageRepository
open Repository.RepositoryInterfaces

 type IServiceCollection with
    member this.AddMessageRepository () =
        this.AddEntityFrameworkNpgsql()
            .AddDbContext<HarbingerContext>()
            .BuildServiceProvider() |> ignore
        this.TryAddSingleton<IRepository<Message>, MessageRepository>()
        this