open Flips
open Flips.SliceMap
open Flips.Types
open Flips.UnitsOfMeasure
open System



[<Measure>]
type Lesson

[<Measure>]
type WriteExam

type Subject =
    | German
    | Maths
    | Chemistry
    | Physics
    | English
    | History
    | Musics
    | Geograhpy
    | Informatics
    | Religion
    | PEd
    | Art
    | Free

type Student = {
    Name:string
    Table:Subject list list
}

type Exam = {
    Uid:Guid
    Length:int<Lesson>
    Subject:Subject
}


let jonathan = {
    Name="Jonathan Schäfer"
    Table=[
        [Physics;English;Free;Free;Chemistry;Chemistry;History;History;German;German]
        [Maths;Maths;Musics;Musics;Geograhpy;Informatics]
        [English;English;Maths;Maths;Chemistry;Physics;PEd;PEd]
        [Chemistry;Physics;Musics;Free;English;English;Religion;Religion]
        [Geograhpy;Chemistry;History;German;Informatics;Religion]
    ]
}

let davide = {
    Name="Davide Wiest"
    Table = [
        [English;Physics;Art;Art;Geograhpy;Geograhpy;Religion;Religion]
        [Maths;Maths;German;German;Informatics;History]
        [Physics;Physics;Maths;Maths;Geograhpy;English;PEd;PEd]
        [Free;German;Art;Physics;Physics;Free;Free;Informatics;Informatics]
        [Informatics;Geograhpy;Religion;Free;History]
    ]
}

let students = [jonathan; davide]
let exams = []




let decision =
    DecisionBuilder<WriteExam> "Plans the exam optimally" {
        for student in students do
            for day in student.Table do
                for lesson in day ->
                    Boolean
    } |> SMap3.ofSeq
