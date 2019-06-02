module Repository.RepositoryInterfaces

type IRepository<'T> =
    abstract Create: 'T -> Async<'T>