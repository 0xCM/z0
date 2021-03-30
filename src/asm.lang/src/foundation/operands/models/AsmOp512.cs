//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    /// <summary>
    /// Defines a 512-bit operand
    /// </summary>
    public readonly struct AsmOp512 : IAsmOp<AsmOp512,W512,Cell512>
    {
        public Cell512 Content {get;}

        public AsmOpKind OpKind {get;}

        [MethodImpl(Inline)]
        public AsmOp512(Cell512 value, AsmOpKind kind)
        {
            Content = value;
            OpKind = kind;
        }
    }
}