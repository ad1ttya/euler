// Find the largest palindrome made from the product of two 3-digit numbers.

open System

let isPalindrome (n: int) =
    let nChars = n.ToString().ToCharArray()
    let revChars = Array.rev nChars
    nChars = revChars

let maxPalindrome =
    [100..999]
    |> List.collect (fun n -> [100 .. 999] |> List.map (fun y -> n * y))
    |> Seq.filter isPalindrome
    |> Seq.max