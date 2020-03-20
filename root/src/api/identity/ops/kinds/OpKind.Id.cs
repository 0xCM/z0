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

        Inc,

        Dec,

        Negate,

        Abs,

        Square,

        Sqrt,

        Add,

        Sub,

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

        Neq,

        Lt,

        LtEq,

        Gt,

        GtEq,

        Between,

        Identity,

        Sum,

        Avg,
    }
}