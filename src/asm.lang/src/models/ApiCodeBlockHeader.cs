//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    public readonly struct ApiCodeBlockHeader
    {
        public string Separator {get;}

        public OpUri Uri {get;}

        public ClrDisplaySig DisplaySig {get;}

        public CodeBlock CodeBlock {get;}

        public ExtractTermCode TermCode {get;}

        public AsmDocPartKind Kind
            => AsmDocPartKind.BlockHeader;

        [MethodImpl(Inline)]
        public ApiCodeBlockHeader(string sep, OpUri uri, ClrDisplaySig sig, CodeBlock code, ExtractTermCode term)
        {
            Separator = sep;
            Uri = uri;
            DisplaySig = sig;
            CodeBlock = code;
            TermCode = term;
        }
    }
}