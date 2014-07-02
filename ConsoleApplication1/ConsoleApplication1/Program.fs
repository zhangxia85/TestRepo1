open System

type c = Console

type cc = ConsoleColor

let bc = ref c.BackgroundColor
let fc = ref c.ForegroundColor
let rc = c.ResetColor
let wl : string -> unit = c.WriteLine
let rl = c.ReadLine

[<EntryPoint>]
let main argv = 
    bc := cc.Cyan
    fc := cc.DarkRed
    wl "Hello F#!"
    rc()
    wl "Press ENTER to exit."
    rl() |> ignore
    0
