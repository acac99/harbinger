module Api.Router

open Giraffe

let getRoutes: HttpHandler =
        choose [
            GET >=>
                choose [
                    route "/" >=> text "world"
                ]
            setStatusCode 404 >=> text "Not Found" ]
   