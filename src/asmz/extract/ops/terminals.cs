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

        [Op]
        public static ExtractTermInfo terminal(in ApiMemberCode src)
        {
            const byte MaxSeg = 6;

            var data = src.Encoded.View;
            var size = data.Length;
            var found = NotFound;
            var max = size + MaxSeg - 1;
            var kind = ExtractTermKind.None;
            for(var offset=0; offset<max; offset++)
            {
                if(slice(data, offset, 3).SequenceEqual(Term3A))
                {
                    found = offset;
                    kind = ExtractTermKind.Term3A;
                    break;
                }
                else if(slice(data, offset, 6).SequenceEqual(Term6A))
                {
                    found = offset;
                    kind = ExtractTermKind.Term6A;
                    break;
                }
                else if(slice(data, offset, 5).SequenceEqual(Term5A))
                {
                    found = offset;
                    kind = ExtractTermKind.Term5A;
                    break;
                }
                else if(slice(data, offset, 4).SequenceEqual(Term4A))
                {
                    found = offset;
                    kind = ExtractTermKind.Term4A;
                    break;
                }
                else if(slice(data, offset, 3).SequenceEqual(Term3B))
                {
                    found = offset;
                    kind = ExtractTermKind.Term3B;
                    break;
                }
                else if(slice(data, offset, 4).SequenceEqual(Term4B))
                {
                    found = offset;
                    kind = ExtractTermKind.Term4B;
                    break;
                }
            }

            return new ExtractTermInfo(kind, found);
        }

        [Op]
        public static uint terminals(ReadOnlySpan<ApiMemberCode> src, Span<MemoryBlock> dst)
        {
            var count = src.Length;
            var j = 0u;
            for(var i=0; i<count; i++)
            {
                ref readonly var extract = ref skip(src,i);
                var term = terminal(extract);
                if(term.IsNonEmpty)
                    seek(dst, j++) = block(extract, term);
            }
            return j;
        }
    }
}