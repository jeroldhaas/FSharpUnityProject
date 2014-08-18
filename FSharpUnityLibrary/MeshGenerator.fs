namespace FSharpUnityLibrary

open System
open System.Collections
open System.Collections.Generic

open UnityEngine

(*

module MeshGenerator =
    let GenerateVertices count fn =
        Array.create count fn
    let Vertices = 1

    type MeshGenerators() =
        let GenerateVertices count fn =
            Array.create count fn
        let RandomVertexGen count =
            let rnd = new System.Random()
            let rvg count =
                match count with
                    |0 -> None
                    |_ -> fun i -> rvg (i - 1)
//            let rndArray = float []
//            for i = 1 to count do
//            // this needs to pack into a 1D array with random values
//                  rndArray <- rndArray::rnd.NextDouble() 
//            rndArray
                
        let BuildVector3 count =
            let xArray = RandomVertexGen count
            let yArray = RandomVertexGen count
            let zArray = RandomVertexGen count
            // each float needs aggregated into a Vector3[]
//            let V3Array =
//                let v3a = 
                
    
//        member x.Vertices =
//            let rnd = new System.Random()
//            [fun i -> i = rnd.Next()]



*)