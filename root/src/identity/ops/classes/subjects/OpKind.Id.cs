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

        False = 1,

        And,

        CNonImpl,
     
        LProject,

        NonImpl,

        RProject,

        Xor,
        
        Or,

        Nor,

        Xnor,

        RNot,

        Impl,

        LNot,

        CImpl,

        Nand,
        
        True,

        Not,

        Select,

        Inc = 100,

        Dec,

        Negate,

        Abs,

        Square,

        Sqrt,

        Add = 200,

        Sub,

        Mul,

        Div,

        Divides,

        Mod,

        Clamp,

        Distance,

        Dot,

        Sll = 300,

        Srl,

        Sal,

        Sar,

        Rotl,

        Rotr,

        XorSl,

        XorSr,

        Xors,

        Pred = 400,

        Eq = 500,

        Neq,

        Lt,

        LtEq,

        Gt,

        GtEq,

        Between,

        Identity = 600,

        Sum = 700,

        Avg,
    }
}