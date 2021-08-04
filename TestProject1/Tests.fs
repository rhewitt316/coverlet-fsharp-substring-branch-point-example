module Tests

open System
open Xunit
open Module1

[<Fact>]
let ``My test`` () =
    let s = sub "qwerty"
    Assert.True(true)
