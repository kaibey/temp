module TestCalculator

open NUnit.Framework
open FsUnit
open Calculator

[<TestFixture>]
type TestCalculator() =

    [<OneTimeSetUp>]
    member this.Setup() = printfn "Starting Calculator tests"
    
    [<OneTimeTearDown>]
    member this.TearDown() = printfn "Calculator tests are finished"
    
    [<Test>]
    [<Category("SumTests")>]
    member this.OneCanSumPositiveIntegers() = Calc.sum 5 5 |> should equal 10
    
    [<Test>]
    [<Category("SumTests")>]
    member this.OneCanSumNegativeIntegers() = Calc.sum -5 -5 |> should equal -10
    
    [<Test>]
    [<Category("SubtractTests")>]
    member this.OneCanSubtractPositiveIntegers() = Calc.subtract 5 5 |> should equal 0
    
    // Remaining test cases translated similarly