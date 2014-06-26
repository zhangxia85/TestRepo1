open System

let wl : string -> unit = Console.WriteLine
let rl = Console.ReadLine

[<EntryPoint>]
let main argv = 
    wl "Hello F#!"
    wl "Press ENTER to exit."
    rl() |> ignore
    0
