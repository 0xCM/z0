//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    [ApiHost]
    public readonly struct AsmEtl
    {
        [MethodImpl(Inline), Op]
        public static void resequence(Span<AsmDetailRow> src)
        {
            var count = src.Length;
            ref var row = ref first(src);
            for(var i=0u; i<count;i++)
                seek(row,i).Sequence = i;
        }

        public static BinaryCode serialize(in AsmExpr expr)
        {
            var content = expr.Content;
            var count = content.Length;
            if(count != 0)
            {
                var buffer = alloc<byte>(count);
                ref var dst = ref first(buffer);
                var src = content.View;
                for(var i=0; i<count; i++)
                    seek(dst,i) = (byte)skip(src,i);
                return buffer;
            }
            else
                return BinaryCode.Empty;
        }

        [MethodImpl(Inline), Op]
        public static BinaryCode code(in CodeBlock src, uint offset, byte size)
            => slice(src.View, offset, size).ToArray();

        public static SortedSpan<AsmEncodingInfo> encodings(ReadOnlySpan<AsmIndex> src)
        {
            var collected = hashset<AsmEncodingInfo>();
            var count = src.Length;
            var counter = 0u;
            for(var i=0; i<count; i++)
            {
                ref readonly var statement = ref skip(src,i);
                if(collected.Add(asm.encoding(statement)))
                    counter++;
            }
            return collected.Array().ToSortedSpan();
        }

        [MethodImpl(Inline), Op, Closures(UInt64k)]
        public static AsmRowSet<T> rowset<T>(T key, AsmDetailRow[] src)
            => new AsmRowSet<T>(key,src);

        [Op]
        public static HexVector16 offsets(W16 w, ReadOnlySpan<AsmDetailRow> src)
        {
            var count = src.Length;
            var buffer = alloc<Hex16>(count);
            ref var dst = ref first(buffer);
            for(var i=0; i<count; i++)
                seek(dst,i) = skip(src,i).LocalOffset;
            return buffer;
        }
    }
}