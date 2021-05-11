//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct ApiCodeBlockHeader
    {
        public string Separator {get;}

        public OpUri Uri {get;}

        public MethodDisplaySig DisplaySig {get;}

        public CodeBlock CodeBlock {get;}

        public ExtractTermCode TermCode {get;}

        [MethodImpl(Inline)]
        public ApiCodeBlockHeader(string sep, OpUri uri, MethodDisplaySig sig, CodeBlock code, ExtractTermCode term)
        {
            Separator = sep;
            Uri = uri;
            DisplaySig = sig;
            CodeBlock = code;
            TermCode = term;
        }
    }
}