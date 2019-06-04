module Api.Router

open Giraffe
open Domain.MessageCommands
open Api

let getRoutes : HttpHandler =
    choose [ POST
             >=> choose [ route "/message" >=> MessageController.CreateMessage ]

             PUT
             >=> choose [ route "/message" >=> MessageController.UpdateMessage ]
             setStatusCode 404 >=> text "Not found" ]
