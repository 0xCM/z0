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
        False = 0,

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

        Mod,

        Clamp,

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

    public static class OpKindIdOps
    {
        public static string Format(this OpKindId id)
            => id.ToString().ToLower();

        public static string Format(this OpKindId? id)
            => id.HasValue ? id.Value.Format() : "unkinded";

    }
}