// What is the largest prime factor of the number 600851475143 

open System

let factors (n: int64) =
     [2L.. int64(Math.Sqrt(double(n)))] |> Seq.filter(fun i -> n % i = 0L) 

let isPrime (n: int64) = factors n |> Seq.length = 0

let maxPrimeFactor (n: int64) =
    factors n
    |> Seq.filter isPrime
    |> Seq.max
    
maxPrimeFactor(600851475143L)