module CS220.Quiz1.Math

open System

/// Modify the function `collatz` in such a way that the function takes in a
/// 32-bit integer, and returns the number of steps it takes to reach 1 in the
/// Collatz sequence.
let collatz (n: int) =
  let n = uint64 n
  let rec iter (n: uint64) counter =
    if n = 1UL then counter
    else if n % 2UL = 0UL then iter (n / 2UL) (counter + 1)
    else iter (3UL * n + 1UL) (counter + 1)
  iter n 0

