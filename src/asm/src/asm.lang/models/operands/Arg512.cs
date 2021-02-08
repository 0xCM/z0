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
    public readonly struct Arg512: IAsmOp<Arg512,W512,Cell512>
    {
        public Cell512 Content {get;}

        public AsmOpKind OpKind {get;}

        [MethodImpl(Inline)]
        public Arg512(Cell512 value, AsmOpKind kind)
        {
            Content = value;
            OpKind = kind;
        }
    }
}