let lockObj = new obj()

let mutable x = 10
let mutable y = 20

let add x y =
    lock lockObj (
        x + y
    )

printf "%d\n" (add x y)

x <- 15
y <- 25

printf "%d\n" (add x y)