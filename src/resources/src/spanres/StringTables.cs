//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;
    using static CsPatterns;

    [ApiHost]
    public readonly struct StringTables
    {
        const NumericKind Closure = UnsignedInts;

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ReadOnlySpan<char> entry<T>(StringTable<T> src, T index)
            where T : unmanaged
                => entry(src,bw64(index));

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ReadOnlySpan<char> entry<T>(StringTable<T> src, ulong i)
            where T : unmanaged
        {
            var offsets = src.Offsets;
            var i0 = bw64(skip(offsets, i));
            var count = src.EntryCount;
            var data = src.Data;
            if(i < count - 1)
            {
                var i1 = bw64(skip(offsets, i + 1));
                var length = i1 - i0;
                return slice(data,i0,length);
            }
            else
                return slice(data,i0);
        }

        public static StringTable<T> create<T>(Identifier name, ReadOnlySpan<string> src)
            where T : unmanaged
        {
            var count = src.Length;
            var offset = 0u;
            var offsets = alloc<T>(count);
            var chars = alloc<char>(text.length(src));
            ref var joined = ref first(chars);
            ref var cuts = ref first(offsets);
            var j = 0ul;
            for(var i=0; i<count; i++)
            {
                ref readonly var entry = ref skip(src,i);
                seek(cuts,i) = @as<ulong,T>(j);
                copy(entry, ref j, chars);
            }
            return new StringTable<T>(name, new string(chars), offsets);
        }

        [MethodImpl(Inline), Op]
        static ulong copy(ReadOnlySpan<char> src, ref ulong i, Span<char> dst)
        {
            var i0 = i;
            var count = src.Length;
            for(var j=0; j<count; j++)
                seek(dst,i++) = skip(src,j);
            return i - i0;
        }

        public static string format<T>(in StringTable<T> src, uint margin = 0)
            where T : unmanaged
        {
            var dst = TextTools.buffer();
            emit(margin,src,dst);
            return dst.Emit();
        }

        public static void emit<T>(uint margin, in StringTable<T> src, ITextBuffer dst)
            where T : unmanaged
        {
            dst.IndentLine(margin, PublicReadonlyStruct(src.Name));
            dst.IndentLine(margin, Open());
            margin+=4;

            dst.IndentLine(margin, SpanRes.bytespan("Offsets", src.OffsetStorage).Format());
            dst.AppendLine();
            dst.IndentLine(margin, SpanRes.charspan("Data", src.Content).Format());

            margin-=4;
            dst.IndentLine(margin, Close());
        }
    }
}