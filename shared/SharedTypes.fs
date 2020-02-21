module SharedTypes

type LogicLevel = | High | Low
type Operator = | And | Or | Not | Concat | Pass 
type Megablock = | Name of string

type Net = | Wire of Map<int,LogicLevel> | Bus of Map<int,LogicLevel>
type NamedNet = string * Net
type GeneralNet = (bool * NamedNet) 

type NGram = (char list * bool * bool) list
type Lexer = char list -> (char list * char list) option

type NetIdentifier = {
    Name: string;
    SliceIndices: (int * int option) option 
}
type TLogic = {
    Name: string
    ExpressionList: (Operator * NetIdentifier list * NetIdentifier list) list
    Inputs: NetIdentifier list
    Outputs: NetIdentifier list
    Wires: NetIdentifier list
}  

type Connection = Megablock * GeneralNet list * GeneralNet list 

type GraphEndPoint = |LogicLevel |BusInput of int

type DGraphNetNode = {
    NetName: string
    BusSize: int
}

type DGraphOpNode = Operator
type DGraphNode = |DGraphNetNode|DGraphOpNode
type DGraphEdge = {
    Input: DGraphNode
    Output: DGraphNode
    SliceIndicies: (int * int) option
    IsSliceOfInput: bool
}



