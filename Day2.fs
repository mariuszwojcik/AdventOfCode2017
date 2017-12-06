namespace AOC.Day2

open System
open AOC
open AOC.String

    module part1 =
        let getMinAndMax (a: int array) =
            let min = a |> Array.min
            let max = a |> Array.max
            (min, max)


        let calculateChecksum (input: string) =
            input.Split '\n'
            |> Seq.map(fun s -> s |> convertToInts '\t')
            |> Seq.map getMinAndMax
            |> Seq.map(fun (min, max) -> max - min)
            |> Seq.sum

        let solve input =
            let result = calculateChecksum input
            PrintPuzzleResult "Day 2 1st" result

    module part2 =

        let calculateChecksum (input: string) =
            input.Split '\n'
            |> Seq.map(fun s -> s |> convertToInts '\t')
            |> Seq.map(fun i -> i |> Seq.getEvenlyDividingNumbersDivision)
            |> Seq.sum

        let solve input =
            let result = calculateChecksum input
            PrintPuzzleResult "Day 2 2nd" result
