//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.Intrinsics;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public readonly struct AsmInstructionDetails
    {
        readonly TableSpan<InstructionDetail> Data;

        [MethodImpl(Inline)]
        public static implicit operator AsmInstructionDetails(InstructionDetail[] src)
            => new AsmInstructionDetails(src);

        [MethodImpl(Inline)]
        public AsmInstructionDetails(InstructionDetail[] src)
        {
            Data = src;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Data.IsEmpty;
        }
    }
}