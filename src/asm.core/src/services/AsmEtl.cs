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
        public static ReadOnlySpan<AsmIndex> LoadStatementIndex(FS.FilePath src)
        {
            var dst = list<AsmIndex>();
            var counter = 1u;

            using var reader = src.Reader();
            var header = reader.ReadLine();
            var line = reader.ReadLine();
            var result = Outcome.Success;
            while(line != null && result.Ok)
            {
                result = AsmParser.parse(counter++, line, out var row);
                if(result.Ok)
                    dst.Add(row);

                line = reader.ReadLine();
            }

            return dst.ViewDeposited();
        }

        public static void traverse(FS.FilePath src, Receiver<AsmIndex> dst)
        {
            var counter = 1u;
            using var reader = src.Reader();
            var header = reader.ReadLine();
            var line = reader.ReadLine();
            var result = Outcome.Success;
            while(line != null && result.Ok)
            {
                result = AsmParser.parse(counter++, line, out var row);
                if(result.Ok)
                    dst(row);
                line = reader.ReadLine();
            }
        }

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

        public static SortedSpan<AsmEncodingInfo> DistinctEncodings(ReadOnlySpan<AsmIndex> src)
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