type c = System.Console

type cc = System.ConsoleColor

let rc = c.ResetColor
let wl : string -> unit = c.WriteLine
let rl = c.ReadLine

[<EntryPoint>]
let main argv = 
    c.BackgroundColor <- cc.Cyan
    c.ForegroundColor <- cc.DarkRed
    wl "Hello F#!"
    rc()
    wl "Press ENTER to exit."
    rl() |> ignore
    0
