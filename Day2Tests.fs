namespace AOC.Day2

open Expecto
open AOC

    module Tests =
                
        [<Tests>]
        let TestCases =
            testList "Day 1 test cases" [
                test "Part 1" {
                    let actual = AOC.Day2.part1.calculateChecksum Inputs.Day2Part1TestInput

                    Expect.equal actual 18 "result should be 18."
                }

                test "Part 2" {
                    let actual = AOC.Day2.part2.calculateChecksum Inputs.Day2Part2TestInput

                    Expect.equal actual 9 "result should be 9."
                }
            ]

        [<Tests>]
        let GetEvenlyDividingNumbersDivisionTests =
            testList "Get evenly dividing numbers" [
                test "5 9 2 8" {
                    let actual = [|5;9;2;8|] |> Seq.getEvenlyDividingNumbersDivision
            
                    Expect.equal actual 4 "the only two numbers that evenly divide are 8 and 2; the result of this division is 4."
                }

                test "9 4 7 3" {
                    let actual = [|9;4;7;3|] |> Seq.getEvenlyDividingNumbersDivision
            
                    Expect.equal actual 3 "the two numbers are 9 and 3; the result is 3."
                }

                test "3 8 6 5" {
                    let actual = [|3;8;6;5|] |> Seq.getEvenlyDividingNumbersDivision
            
                    Expect.equal actual 2 "the result is 2."
                }
            ]

            


