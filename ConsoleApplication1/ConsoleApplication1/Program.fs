// 在 http://fsharp.net 上了解有关 F# 的更多信息
// 请参阅“F# 教程”项目以获取更多帮助。
open System;
let wl = Console.WriteLine :string->unit
[<EntryPoint>]
let main argv = 
    wl "Hello F#!"
    wl "Press ENTER to exit."
    Console.ReadLine() |> ignore
    0 // 返回整数退出代码
