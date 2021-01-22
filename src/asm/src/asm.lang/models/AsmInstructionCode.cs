//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct AsmInstructionCode
    {
        readonly ulong Data;

        [MethodImpl(Inline)]
        public AsmInstructionCode(ulong src)
            => Data = src;

        [MethodImpl(Inline)]
        public static implicit operator ulong(AsmInstructionCode src)
            => src.Data;

        [MethodImpl(Inline)]
        public static implicit operator AsmInstructionCode(ulong src)
            => new AsmInstructionCode(src);
    }
}