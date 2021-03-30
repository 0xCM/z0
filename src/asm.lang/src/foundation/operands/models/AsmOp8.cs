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
    /// Defines an 8-bit operand
    /// </summary>
    public readonly struct AsmOp8 : IAsmOp<AsmOp8,W8,byte>
    {
        public byte Content {get;}

        public AsmOpKind OpKind {get;}

        [MethodImpl(Inline)]
        public AsmOp8(byte value, AsmOpKind kind)
        {
            Content = value;
            OpKind = kind;
        }
    }
}