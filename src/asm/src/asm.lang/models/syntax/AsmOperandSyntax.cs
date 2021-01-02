//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct AsmOperandSyntax
    {
        readonly ulong Data;

        public AsmOperandKind Kind => (AsmOperandKind)(0b111 & Data);

        [MethodImpl(Inline)]
        public AsmOperandSyntax(ulong src)
            => Data = src;

        public AsmOperandSyntax(RegisterKind reg)
            => Data = (ulong)AsmOperandKind.R | ((ulong)reg << 32);
    }
}