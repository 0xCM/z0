//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct AsmFunctionHeader
    {        
        public readonly OpUri Uri;

        public string OpSig {get;}

        public string DataProp {get;}

        public MemoryAddress BaseAddress {get;}

        public ExtractTermCode TermCode {get;}


        [MethodImpl(Inline)]
        public AsmFunctionHeader(OpUri uri, string sig, string prop, MemoryAddress @base, ExtractTermCode term)
        {
            Uri = uri;
            OpSig = sig;
            DataProp = prop;
            BaseAddress = @base;
            TermCode = term;
        }

    }
}