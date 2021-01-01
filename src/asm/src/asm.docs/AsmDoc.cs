//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;
    using static AsmDocParts;

    public struct AsmDoc
    {
        public Index<DocLine> Lines {get;}

        [MethodImpl(Inline)]
        public AsmDoc(DocLine[] lines)
        {
            Lines = lines;
        }

        public string Format()
        {
            var dst = Buffers.text();
            iter(Lines, line => dst.AppendLine(line.Text.Content));
            return dst.Emit();
        }

        public override string ToString()
            => Format();
    }
}