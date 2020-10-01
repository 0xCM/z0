//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct AsmOperand
    {
        readonly ulong Data;

        public AsmOperandKind Kind => (AsmOperandKind)(0b111 & Data);

        [MethodImpl(Inline)]
        public AsmOperand(ulong src)
        {
            Data = src;
        }

        public AsmOperand(RegisterKind register)
        {
            Data = (ulong)AsmOperandKind.R | ((ulong)register << 32);
        }
    }
}