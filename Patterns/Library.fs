#if !INTERACTIVE
module Patterns
#endif

type Cell = 
    |Positive
    |Negative
    |Unknown

type Pattern =
    |BlackP
    |WhiteP
    |UnknownP
    |ZeroOrMore of Pattern
    |OneOrMore of Pattern
    |Exactly of int * Pattern
    |FewerThan of int * Pattern
    |Sequence of List<Pattern>
    |Either of Pattern * Pattern
    |Anything
    |EndsOfCells


let toCells v = failwith "Not implemented"

let fromCells v = failwith "Not implemented" 

let patternMatch pattern cells = failwith "Not implemented"

let find pattern cells = failwith "Not implemented"

let map func pattern cells = failwith "Not implemented"