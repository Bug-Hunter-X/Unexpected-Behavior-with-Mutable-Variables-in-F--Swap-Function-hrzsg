let mutable x = 10
let mutable y = 20

let swap x y =
    let temp = x
    x <- y
    y <- temp

swap x y
printfn "%d %d" x y //This will print 20 20 as expected

let mutable a = 10
let mutable b = 20

let swap2 (x:int ref) (y:int ref) = 
    let temp = !x
    x := !y
    y := temp

swap2 &a &b
printfn "%d %d" a b // This will also print 20 20 as expected

//Here is the corrected version of swap3 function
let mutable c = 10
let mutable d = 20

let swap3 (x:int ref) (y:int ref) = 
    let temp = !x
    x := !y
    y := temp

swap3 &c &d
printfn "%d %d" c d // This will print 20 20
