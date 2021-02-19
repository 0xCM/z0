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

    partial struct AsmDocParts
    {
        [Op]
        public static byte lines(in BlockHeader src, Span<string> dst)
        {
            var i = z8;
            seek(dst, i++) = src.Separator;
            seek(dst, i++) = asm.comment($"{src.DisplaySig}::{src.Uri}");
            seek(dst, i++) = ByteSpans.property(src.CodeBlock, src.Uri.OpId);
            seek(dst, i++) = asm.comment(text.concat(nameof(src.CodeBlock.BaseAddress), text.spaced(Chars.Eq), src.CodeBlock.BaseAddress));
            seek(dst, i++) = asm.comment(text.concat(nameof(src.TermCode), text.spaced(Chars.Eq), src.TermCode.ToString()));
            return i;
        }

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