//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct AsmRoutineHeader
    {
        public readonly OpUri Uri;

        public readonly string OpSig;

        public readonly string DataProp;

        public readonly MemoryAddress BaseAddress;

        public readonly ExtractTermCode TermCode;

        [MethodImpl(Inline)]
        public AsmRoutineHeader(OpUri uri, string sig, string prop, MemoryAddress @base, ExtractTermCode term)
        {
            Uri = uri;
            OpSig = sig;
            DataProp = prop;
            BaseAddress = @base;
            TermCode = term;
        }
    }
}