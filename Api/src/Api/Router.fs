module Api.Router

open Giraffe
open Domain.MessageCommands

let getRoutes: HttpHandler =
        choose [
            POST >=>
                choose [
                    route "/message" >=> MessageController.CreateMessage
                ]
            setStatusCode 404 >=> text "Not found" ]
   