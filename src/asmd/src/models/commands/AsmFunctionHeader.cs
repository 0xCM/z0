//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Memories;

    public readonly struct AsmFunctionHeader
    {
        [MethodImpl(Inline)]
        public AsmFunctionHeader(OpUri uri, string sig, string prop, MemoryAddress @base, ExtractTermCode term)
        {
            this.Uri = uri;
            this.OpSig = sig;
            this.DataProp = prop;
            this.BaseAddress = @base;
            this.TermCode = term;
        }
        
        public readonly OpUri Uri;

        public string OpSig {get;}

        public string DataProp {get;}

        public MemoryAddress BaseAddress {get;}

        public ExtractTermCode TermCode {get;}
    }
}