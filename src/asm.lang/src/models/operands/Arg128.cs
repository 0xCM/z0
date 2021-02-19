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
    /// Defines a 128-bit operand
    /// </summary>
    public readonly struct Arg128: IAsmOp<Arg128,W128,Cell128>
    {
        public Cell128 Content {get;}

        public AsmOpKind OpKind {get;}

        [MethodImpl(Inline)]
        public Arg128(Cell128 value, AsmOpKind kind)
        {
            Content = value;
            OpKind = kind;
        }
    }
}