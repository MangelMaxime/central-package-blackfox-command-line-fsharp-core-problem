module TradeKart.EasyBuild.Main

open SimpleExec
open BlackFox.CommandLine

// This is a basic help message, as the CLI parser is not a "real" CLI parser
// For now, it is enough as this is just a dev tool
let printHelp () =
    let helpText =
        """
Usage: dotnet run <command> [<args>]

Available commands:
    watch                           Run the dev server

    build                           Build the project
        """

    printfn $"%s{helpText}"

[<EntryPoint>]
let main argv =
    
    printHelp ()

    0
