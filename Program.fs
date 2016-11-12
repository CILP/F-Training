// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.

// let add = (fun x y -> x + y)
let add (x: int) (y: int) =
    x + y

let rest (x: int) (y: int) = 
    x - y

let product (x: int) (y: int) =
    x * y

let div (x: int) (y: int) =
    x / y

let some = (fun x y -> x + y)

// Generic arithmetic operation
let gen o (x: int) (y: int) =
    o x y

let genLambda = (fun o x y -> o x y)

[<EntryPoint>]
let main argv = 
    printfn "%A" argv

    printfn "Hello World From %s" "F#"

    let result = genLambda some 5 5

    printfn "add 5 5: %d" result


    #if DEBUG
    System.Console.ReadKey() |> ignore
    #endif

    0 // return an integer exit code
