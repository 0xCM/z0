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
        /// <summary>
        /// Defines a statement block header
        /// </summary>
        public readonly struct BlockHeader
        {
            public string Separator {get;}

            public OpUri Uri {get;}

            public ClrDisplaySig DisplaySig {get;}

            public CodeBlock CodeBlock {get;}

            public ExtractTermCode TermCode {get;}

            public AsmDocPartKind Kind
                => AsmDocPartKind.BlockHeader;

            [MethodImpl(Inline)]
            public BlockHeader(string sep, OpUri uri, ClrDisplaySig sig, CodeBlock code, ExtractTermCode term)
            {
                Separator = sep;
                Uri = uri;
                DisplaySig = sig;
                CodeBlock = code;
                TermCode = term;
            }
        }
    }
}