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

    [ApiHost]
    public readonly struct StringHeaps
    {
        [Op]
        public static unsafe StringHeap create(ReadOnlySpan<string> src)
        {
            var count = src.Length;
            var chars = 0;
            root.iter(src, x => chars += x.Length);
            var dst = alloc<char>(chars);
            var offsets = alloc<uint>(count);
            deposit(src, dst, offsets);
            return new StringHeap(dst, offsets);
        }

        [MethodImpl(Inline), Op]
        public static unsafe uint deposit(ReadOnlySpan<string> src, Span<char> dst, Span<uint> offsets)
        {
            var count = src.Length;
            var offset = 0u;
            for(var i=0; i<count; i++)
            {
                ref readonly var data = ref skip(src, i);
                var length = data.Length;
                fixed(char* pData = data)
                {
                    for(var j=0; j<length; j++)
                        seek(dst, offset++) = skip(pData, j);

                    seek(offsets,i) = offset-1;
                }
            }
            return offset;
        }

        [MethodImpl(Inline), Op]
        public static void lengths(StringHeap src, Span<uint> dst)
        {
            var count = src.EntryCount;
            for(var i=0u; i<count; i++)
                seek(dst,i) = (uint)src.Entry(i).Length;
        }

        [MethodImpl(Inline), Op]
        static uint delta(StringHeap src, uint index)
            => src.Offset(index + 1) - src.Offset(index);

        [MethodImpl(Inline), Op]
        public static uint length(StringHeap src, uint index)
            => index != src.EntryCount - 1 ? delta(src, index) : src.CharCount - src.Offset(index);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> entry(StringHeap src, uint index)
            => segment(src, src.Offset(index), length(src,index));

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> segment(StringHeap src, uint offset, uint length)
            => slice(src.Chars, offset,length);
    }
}