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

    partial class BitSpans
    {
        [Op, Closures(Closure)]
        public static BitSpan create<T>(T src)
            where T : unmanaged
                => gpack.unpack(src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static BitSpan scalar<T>(T src)
            where T : unmanaged
        {
            if(size<T>() == 1)
            {
                var input = bw8(src);
                var storage = ByteBlocks.block(n8);
                var target = ByteBlocks.span<bit>(ref storage);
                BitPack.unpack1x8(input, target);
                return target;
            }
            else if(size<T>() == 2)
            {
                var input = bw16(src);
                var storage = ByteBlocks.block(n16);
                var target = ByteBlocks.span<bit>(ref storage);
                BitPack.unpack1x16(input, target);
                return target;
            }
            else if(size<T>() == 4)
            {
                var input = bw32(src);
                var storage = ByteBlocks.block(n32);
                var target = ByteBlocks.span<bit>(ref storage);
                BitPack.unpack1x32(input, target);
                return target;
            }
            else if(size<T>() == 8)
            {
                var input = bw64(src);
                var storage = ByteBlocks.block(n64);
                var target = ByteBlocks.span<bit>(ref storage);
                BitPack.unpack1x64(input, target);
                return target;
            }
            else
                throw no<T>();

        }

        [Op, Closures(Closure)]
        public static BitSpan create<T>(ReadOnlySpan<T> src)
            where T : unmanaged
                => gpack.unpack(src);

        [Op, Closures(Closure)]
        public static BitSpan create<T>(Span<T> src)
            where T : unmanaged
                => gpack.unpack(src.ReadOnly());

        [Op, Closures(Closure)]
        public static BitSpan create<T>(ReadOnlySpan<T> src, Span<bit> buffer)
            where T : unmanaged
        {
            gpack.unpack(src, buffer);
            return buffer;
        }
    }
}