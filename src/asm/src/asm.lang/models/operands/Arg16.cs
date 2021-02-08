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
    /// Defines a 16-bit operand
    /// </summary>
    public readonly struct Arg16 : IAsmOp<Arg16,W16,ushort>
    {
        public ushort Content {get;}

        public AsmOpKind OpKind {get;}

        [MethodImpl(Inline)]
        public Arg16(ushort value, AsmOpKind kind)
        {
            Content = value;
            OpKind = kind;
        }
    }
}