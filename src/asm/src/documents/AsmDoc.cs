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
        public Index<AsmDocLine> Lines {get;}

        [MethodImpl(Inline)]
        public AsmDoc(AsmDocLine[] lines)
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