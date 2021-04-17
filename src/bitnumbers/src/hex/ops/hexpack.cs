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

    partial class Hex
    {
        [Op]
        public static Outcome<uint> digits(ReadOnlySpan<char> src, Span<HexDigit> dst)
        {
            var j=0u;
            var count = root.min(src.Length, dst.Length);
            for(var i=0; i<src.Length; i++)
            {
                if(!parse((AsciChar)skip(src,i), out seek(dst,i)))
                    return false;
            }
            return j;
        }

        [MethodImpl(Inline), Op]
        public static uint hexpack(ReadOnlySpan<byte> src, Span<char> dst)
        {
            var j = 0u;
            var count = root.min(src.Length, dst.Length);
            for(var i=0; i<count; i++)
            {
                ref readonly var b = ref skip(src,i);
                seek(dst,j++) = hexchar(LowerCase, b, 1);
                seek(dst,j++) = hexchar(LowerCase, b, 0);
            }
            return j;
        }

        [Op]
        public static ByteSize hexpack(ReadOnlySpan<ApiCodeBlock> src, Span<HexPacked> dst, Span<char> buffer)
        {
            var count = (uint)root.min(src.Length, dst.Length);
            var size = 0ul;
            for(var i=0u; i<count; i++)
            {
                ref readonly var block = ref skip(src,i);
                buffer.Clear();
                ref var package = ref seek(dst,i);
                package.Index = i;
                package.Address = block.BaseAddress;
                package.Size = block.Size;
                package.Data = Z0.text.format(slice(buffer,0, hexpack(block.View, buffer)));
                size += package.Size;
            }
            return size;
        }

        [Op]
        public static ByteSize hexpack(ReadOnlySpan<ApiCodeBlock> src, Span<HexPacked> dst)
            => hexpack(src,dst, alloc<char>(48400));
    }
}