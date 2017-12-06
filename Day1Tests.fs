namespace AOC.Day1

open Expecto
open AOC

    module Tests =

        [<Tests>]
        let part1TestCases =
            testList "Day 1 part 1 test cases" [
                test "Part 1, 1122" {
                    let actual = part1.sum "1122"

                    Expect.equal actual 3 "produces a sum of 3 (1 + 2) because the first digit (1) matches the second digit and the third digit (2) matches the fourth digit."
                }

                test "Part 1, 1111" {
                    let actual = part1.sum "1111"

                    Expect.equal actual 4 "produces 4 because each digit (all 1) matches the next."
                }

                test "Part 1, 1234" {
                    let actual = part1.sum "1234"

                    Expect.equal actual 0 "produces 0 because no digit matches the next."
                }

                test "Part 1, 91212129" {
                    let actual = part1.sum "91212129"

                    Expect.equal actual 9 "produces 9 because the only digit that matches the next one is the last digit, 9."
                }


                test "Part 2, 1212" {
                    let actual = part2.sum "1212"

                    Expect.equal actual 6 "produces 6: the list contains 4 items, and all four digits match the digit 2 items ahead."
                }

                test "Part 2, 1221" {
                    let actual = part2.sum "1221"

                    Expect.equal actual 0 "produces 0, because every comparison is between a 1 and a 2."
                }

                test "Part 2, 123425" {
                    let actual = part2.sum "123425"


                    Expect.equal actual 4 "produces 4, because both 2s match each other, but no other digit has a match."
                }

                test "Part 2, 123123" {
                    let actual = part2.sum "123123"

                    Expect.equal actual 12 "produces 12."
                }            

                test "Part 2, 12131415" {
                    let actual = part2.sum "12131415"

                    Expect.equal actual 4 "produces 4."
                }            
            ]



        
        [<Tests>]
        let convertToIntArrayTests =

            testList "Convert string to int array" [

                test "Convert string to int array" {
                    let actual = "1122" |> Seq.convertToIntArray |> Seq.toArray

                    Expect.equal actual [|1;1;2;2|] "Should convert each char to int array item"
                }

                test "Empty string" {
                    let actual = "" |> Seq.convertToIntArray |> Seq.toArray

                    Expect.equal actual [||] "should return empty array"
                }

                test "Single char string" {
                    let actual = "9" |> Seq.convertToIntArray |> Seq.toArray

                    Expect.equal actual [|9|] "should return one element array"
                }

            ]

        [<Tests>]
        let pairwiseWithStepTests =
            testList "Pairwise with step" [
                
                test "1 combines element with next element" {
                    let input = "123456"
            
                    let actual = 
                        input 
                        |> Seq.convertToIntArray
                        |> Seq.pairwiseWithStep 1
                        |> Seq.toArray

                    let expected = [|(1,2);(2,3);(3,4);(4,5);(5,6);(6,1)|]

                    Expect.equal actual expected "should combine each element with next element"
                }

                test "1 combines last element with first element" {
                    let input = "123456"
            
                    let actual = 
                        input 
                        |> Seq.convertToIntArray
                        |> Seq.pairwiseWithStep 1
                        |> Seq.toArray
                        |> Seq.last

                    let expected = (6,1)

                    Expect.equal actual expected "Should combine last and first elements together"
                }

                test "3 combines element with one 3 steps down" {
                    let input = "123456"
            
                    let actual = 
                        input 
                        |> Seq.convertToIntArray
                        |> Seq.pairwiseWithStep 3
                        |> Seq.toArray

                    let expected = [|(1,4);(2,5);(3,6);(4,1);(5,2);(6,3)|]

                    Expect.equal actual expected "should combine each element with next element"
                }
          ]

