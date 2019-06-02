module Repository.HarbingerContext
open Microsoft.EntityFrameworkCore
open Repository.Message

type HarbingerContext(options: DbContextOptions<HarbingerContext>) =
    inherit DbContext(options)

    override __.OnModelCreating modelBuilder =
        modelBuilder.Entity<Message>()
            .Property(fun x -> x.Id)
            .HasDefaultValue("NEWID()")
        |> ignore
        
        
    override __.OnConfiguring optionsBuilder =
        optionsBuilder
            .UseNpgsql("Host=localhost;Database=harbinger;Username=postgres;Password=postgres")
        |> ignore

    [<DefaultValue>]
    val mutable message: DbSet<Message>
    member x.messages
        with get() = x.message
        and set v = x.message <- v
        
        
        
        