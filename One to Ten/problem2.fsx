// Find the sum of all the even-valued terms in the sequence which do not exceed four million.

let fibonacci = Seq.unfold(fun (curr, next) -> Some(curr, (next, curr + next))) (0, 1)

let result = 
    fibonacci
    |> Seq.takeWhile (fun i -> i < 4000000)
    |> Seq.filter (fun i -> i % 2 = 0)
    |> Seq.sum