//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct AsmDocParts
    {
        public readonly struct BlockHeader
        {
            public string Separator {get;}

            public OpUri Uri {get;}

            public string Signature {get;}

            public CodeBlock CodeBlock {get;}

            public ExtractTermCode TermCode {get;}

            [MethodImpl(Inline)]
            public BlockHeader(string sep, OpUri uri, string sig, CodeBlock code, ExtractTermCode term)
            {
                Separator = sep;
                Uri = uri;
                Signature = sig;
                CodeBlock = code;
                TermCode = term;
            }
        }
    }
}