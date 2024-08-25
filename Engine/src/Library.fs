namespace Engine

module Say =
    let generateTextWithName name = $"Hello {name}!!"

    let computeLength (text: string) =
        printfn "computeLength called"
        text.Length

    let powerTo number =
        printfn "powerTo called"
        pown number 2

    let isCool number =
        printfn "isCool called"
        number > 4

    let getElements (text: string) =
        text.Split(' ')
        |> Seq.map computeLength
        |> Seq.map powerTo
        |> Seq.filter isCool
        |> Seq.map string
        |> String.concat ", "
