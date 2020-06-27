//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    /// <summary>
    /// Defines operand kind identifiers
    /// </summary>
    public enum OpKindId : ulong
    {
        /// <summary>
        /// The empty identity
        /// </summary>
        None = 0,

        And = 0b0001,

        CNonImpl = 0b0010,               

        LProject = 0b0011, 

        NonImpl = 0b0100,

        RProject = 0b0101,

        Xor = 0b0110,

        Or = 0b0111,

        Nor = 0b1000, 

        Xnor = 0b1001, 

        RNot = 0b1010, 

        Impl = 0b1011,

        LNot = 0b1100, 

        CImpl = 0b1101,

        Nand = 0b1110, 
        
        True = 0b1111,
        
        Not,

        Reverse,

        Select,

        Inc,

        Dec,

        Negate,

        Negative,

        Positive,

        /// <summary>
        /// Classifies a unary operator that returns true iff its operand has a non-zero value
        /// </summary>
        Nonz,

        Abs,

        Square,

        Sqrt,

        Add,

        /// <summary>
        /// Saturated addition
        /// </summary>        
        AddS,

        /// <summary>
        /// Horizontal addition
        /// </summary>        
        AddH,

        /// <summary>
        /// Horizontal saturated addition
        /// </summary>        
        AddHS,

        /// <summary>
        /// Sum absolute differences
        /// </summary>        
        Sad,

        /// <summary>
        /// Horizontal subtraction
        /// </summary>        
        Sub,

        SubH,

        SubHS,

        SubS,

        Mul,

        MulLo,

        MulHi,

        Div,

        Divides,

        Mod,

        Clamp,

        Dist,

        ClMul,

        Dot,

        Sll,

        Sllv,

        Srl,

        Srlv,

        Sal,

        Sra,

        Rotl,

        Rotr,

        XorSl,

        XorSr,

        Xors,

        Eq,


        Eqz,

        Neq,

        Lt,

        Ltz,

        LtEq,

        Gt,

        Gtz,

        GtEq,
        
        Between,

        EqB,
        
        NeqB,

        
        LtB,

        LtEqB,

        GtB,

        GtEqB,

        Within,

        Max,

        Min,

        Identity,

        Sum,

        Avg,

        Avgz,

        Avgi,

        AggMax,

        AggMin,

        TestC,

        TestZ,

        Fma,

        ModMul,

        Concat,

        Broadcast,

        Ceil,

        Floor,

        Even,

        Odd,

        Round,

        Pow,

        Ntz,

        Nlz,

        Pop,

        Mux,

        Scatter,

        Gather,

        Mix,

        Rank,

        Bsrl,

        Bsll,

        XorNot,

        Parse,

        EqPred,

        NeqPred,

        LtPred,

        LtEqPred,

        GtPred,

        GtEqPred,

        Rotrx,

        Rotlx,

        Sllx,

        Srlx,

        Extract,

        TestBit,

        SetBit,

        TestBits,

        Stitch,

        Slice,


        BitCell,

        Enable,

        Disable,

        Hi,

        Lo,

        HiPos,

        LoPos,

        Left,

        Right,

        Replicate,

        HiSeg,

        LoSeg,

        ZHi,

        Log2,

        Log10,

        Ln,

        Log,

        Split,

        Toggle,

        Pack,

        Unpack,

        HProd,

        TestZnC,

        Same,

        Alloc,

        Init,        

        Load,

        Store,

        Zero,

        One,

        Kind,

        /// <summary>
        /// Identifies an operation that evaluates one or more operands to determine that a subject is, or is not, of some target kind
        /// </summary>
        Test,

        Ones,

        Zeroes,

        /// <summary>
        /// Identifies an operation that reifies a swich expression
        /// </summary>
        Switch,

        Copy,

        DivMod,

        /// <summary>
        /// Identifies an operation that computes the effective bit-width of a value
        /// </summary>        
        EffWidth,

        /// <summary>
        /// Identifies an operation that computes the effective byte-width of a value
        /// </summary>        
        EffSize,

        /// <summary>
        /// Identifies a function that accepts two homogenous componentized values, and perhaps other ingredients, and produces
        /// an componentized output value where each target component represents a join, via some means, of corresponding operand components
        /// </summary>        
        
        Zip,

        Map,

        VZip,

        VMap,

        
        /// <summary>
        /// Identifies a function that invokes framework/system operations wich are located in an external scope that does not disolve
        /// </summary>        
        Opaque = uint.MaxValue + 1ul,
    
    }    

    public enum OpacityKind : ulong
    {
        None = 0,

        Closure = NumericKind.All,
        
        Root = OpKindId.Opaque,

        First = Root + 1,

        Unbox = First,

        CreateString,

        Alloc,
        
        Equals,

        GetType,

        GetTypeCode,

        Write,

        Copy,


    }
}