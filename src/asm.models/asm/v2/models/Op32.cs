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
    /// Defines a 32-bit operand
    /// </summary>
    public readonly struct Op32 : IAsmOperand<Op32,W32,uint>
    {
        public uint Content {get;}

        public SignKind Sign {get;}

        public AsmOperandKind OpKind {get;}

        [MethodImpl(Inline)]
        public Op32(uint value, SignKind sign, AsmOperandKind kind)
        {
            Content = value;
            OpKind = kind;
            Sign = sign;
        }
    }
}