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
    /// Defines a 32-bit operand
    /// </summary>
    public readonly struct Arg32 : IAsmOp<Arg32,W32,uint>
    {
        public uint Content {get;}

        public AsmOpKind OpKind {get;}

        [MethodImpl(Inline)]
        public Arg32(uint value, AsmOpKind kind)
        {
            Content = value;
            OpKind = kind;
        }
    }
}