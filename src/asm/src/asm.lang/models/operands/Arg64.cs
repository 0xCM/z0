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
    /// Defines a 64-bit operand
    /// </summary>
    public readonly struct Arg64 : IAsmOp<Arg64,W64,ulong>
    {
        public ulong Content {get;}

        public AsmOpKind OpKind {get;}

        [MethodImpl(Inline)]
        public Arg64(ulong value, AsmOpKind kind)
        {
            Content = value;
            OpKind = kind;
        }
    }
}