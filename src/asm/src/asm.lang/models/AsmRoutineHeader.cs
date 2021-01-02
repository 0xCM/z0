//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public struct AsmRoutineHeader
    {
        public OpUri Uri;

        public string OpSig;

        public string DataProp;

        public MemoryAddress BaseAddress;

        public ExtractTermCode TermCode;

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