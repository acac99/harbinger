module Api.Router

open Giraffe
open Domain.MessageCommands

let getRoutes: HttpHandler =
        choose [
            POST >=>
                choose [
                    route "/message" >=> bindJson<CreateMessageCommand> (Successful.OK)
                ]
            setStatusCode 404 >=> text "Not found" ]
   