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
        
        BinaryTrue = 0b1111,
        

        Not,

        Select,

        Inc,

        Dec,

        Negate,

        Negative,

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
        /// Horizontal subtraction
        /// </summary>        
        Sub,

        SubH,

        Mul,

        Div,

        Divides,

        Mod,

        Clamp,

        Distance,

        Dot,

        Sll,

        Srl,

        Sal,

        Sar,

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

        Max,

        Min,

        Identity,

        Sum,

        Avg,

        Avgz,

        AggMax,

        AggMin,
    }
}