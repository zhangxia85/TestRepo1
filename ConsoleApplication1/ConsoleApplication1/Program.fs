// 在 http://fsharp.net 上了解有关 F# 的更多信息
// 请参阅“F# 教程”项目以获取更多帮助。
open System;
[<EntryPoint>]
let main argv = 
    Console.WriteLine "Hello F#!"
    Console.WriteLine "Press ENTER to exit."
    Console.ReadLine() |> ignore
    0 // 返回整数退出代码
