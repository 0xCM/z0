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

    partial struct asm
    {
        [Op]
        public static Index<AsmEncodingSummary> summarize(AsmEncodings encodings)
        {
            var src = encodings.SortDistinct().View;
            var count = src.Length;
            var buffer = alloc<AsmEncodingSummary>(count);
            ref var dst = ref first(buffer);
            for(var i=0; i<count; i++)
            {
                ref var row = ref seek(dst,i);
                ref readonly var encoding = ref skip(src,i);
                row.Statement = encoding.Statement;
                row.Encoded = encoding.Encoded;
                row.OpCode = encoding.Specifier.OpCode;
                row.Sig = encoding.Specifier.Sig;
            }
            return buffer;
        }
    }
}