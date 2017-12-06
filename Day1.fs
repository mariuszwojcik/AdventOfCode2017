namespace AOC.Day1

open AOC
open AOC.String

    module part1 =

        let sum input =

            input
            |> Seq.convertToIntArray
            |> Seq.pairwiseWithStep(1)
            |> Seq.where(fun (a,b) -> a = b)
            |> Seq.map(fun (a,b) -> a)
            |> Seq.sum

        let solve input =
            let result = sum input
            PrintPuzzleResult "Day 1 1st" result


    module part2 =
        let sum input =
            let a = input |> Seq.convertToIntArray |> Seq.toArray
            let pairwiseStep = a.Length / 2
            
            input
            |> Seq.convertToIntArray
            |> Seq.pairwiseWithStep pairwiseStep
            |> Seq.where(fun (a,b) -> a = b)
            |> Seq.map(fun (a,b) -> a)
            |> Seq.sum

        let solve input =
            let result = sum input
            PrintPuzzleResult "Day 1 2nd" result
            