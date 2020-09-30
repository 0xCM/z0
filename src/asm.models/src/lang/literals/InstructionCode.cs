//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct AsmLang
    {
        public readonly struct InstructionCode
        {
            readonly ulong Data;

            [MethodImpl(Inline)]
            public InstructionCode(ulong src)
                => Data = src;

            [MethodImpl(Inline)]
            public static implicit operator ulong(InstructionCode src)
                => src.Data;

            [MethodImpl(Inline)]
            public static implicit operator InstructionCode(ulong src)
                => new InstructionCode(src);
        }
    }
}