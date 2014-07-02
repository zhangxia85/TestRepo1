open System

let rc = Console.ResetColor
let wl : string -> unit = Console.WriteLine
let rl = Console.ReadLine

[<EntryPoint>]
let main argv = 
    Console.BackgroundColor <- ConsoleColor.Cyan
    Console.ForegroundColor <- ConsoleColor.DarkRed
    wl "Hello F#!"
    rc()
    wl "Press ENTER to exit."
    rl() |> ignore
    0
