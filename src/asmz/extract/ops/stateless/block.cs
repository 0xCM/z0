//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;
    using static ExtractTermData;

    partial class ApiExtractor
    {
        [Op]
        public static MemoryBlock block(in ApiMemberCode src, ExtractTermInfo term)
        {
            if(term.IsEmpty)
                return MemoryBlock.Empty;

            var kind = term.Kind;
            var size = ByteSize.Zero;
            var modifier = skip(TermModifiers,(byte)kind);
            if(kind == ExtractTermKind.Term5A)
                size = term.Offset + modifier;
            else
                size = term.Offset;

            var origin = new MemoryRange(src.Address, size);
            var data = slice(src.Encoded.View,0, size);
            return memory.memblock(origin, data.ToArray());
        }
    }
}