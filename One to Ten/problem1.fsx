// Find the sum of all the multiples of 3 or 5 below 1000.

let nums = [| 0..999 |]

let sum = Array.filter(fun n -> n % 3 = 0 || n % 5 = 0) nums |> Array.sum