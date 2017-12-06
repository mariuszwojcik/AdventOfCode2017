namespace AOC

    module String =
        let convertToInts (separator: char) (source: string) =
            source.Split separator
            |> Seq.map(fun i -> System.Int32.Parse(i.ToString()))
            |> Seq.toArray

        let PrintPuzzleResult puzzleName result =
            printfn "\tThe answer to %s puzzle is %d" puzzleName result


    module Seq =

        let convertToIntArray (source : seq<'T>) =
            source
            |> Seq.map(fun i -> System.Int32.Parse(i.ToString()))

        let pairwiseWithStep (step : int) (source : seq<'T>) =
            let s2 = Seq.append source source |> Seq.toList
            source
            |> Seq.mapi (fun idx item -> (item, s2.[idx + step]))
        
        let getEvenlyDividingNumbersDivision (source: int seq) =
            
            let findEvenlyDividingNumbers (i1: int) (s: int seq) =
                s
                |> Seq.where(fun i2 -> i1 % i2 = 0 || i2 % i1 = 0)
                |> Seq.map(fun i2 -> if i1 > i2 then (i1, i2) else (i2, i1))
                |> Seq.toArray

            let (a,b) = 
                source
                |> Seq.mapi(fun idx el -> (el, source |> Seq.skip (idx + 1)))
                |> Seq.map(fun (a,b) -> findEvenlyDividingNumbers a b)
                |> Seq.find(fun i -> i.Length > 0)
                |> Seq.head

            a / b

