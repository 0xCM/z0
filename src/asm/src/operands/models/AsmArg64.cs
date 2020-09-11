//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Defines a 64-bit operand
    /// </summary>
    public readonly struct AsmArg64 : IAsmArg<AsmArg64,W64,ulong>
    {
        public ulong Content {get;}

        public SignKind Sign {get;}

        public AsmOperandKind OpKind {get;}

        [MethodImpl(Inline)]
        public AsmArg64(ulong value, SignKind sign, AsmOperandKind kind)
        {
            Content = value;
            OpKind = kind;
            Sign = sign;
        }
    }
}