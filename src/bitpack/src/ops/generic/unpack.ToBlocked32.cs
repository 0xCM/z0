//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Memories;

    partial class BitPack
    {
        /// <summary>
        /// Unpacks each primal source bit to a 32-bit target
        /// </summary>
        /// <param name="src">The packed bit source</param>
        /// <param name="dst">The unpacked bit target</param>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static void unpack<T>(ReadOnlySpan<T> src, in SpanBlock256<uint> dst)
            where T : unmanaged
        {
            var blockcount = dst.BlockCount;
            var bytes = src.Bytes();
            ref readonly var bitsrc = ref head(bytes);

            for(var block=0; block < blockcount; block++)
                unpack(skip(bitsrc, block), dst.Block(block));
        }

        /// <summary>
        /// Unpacks each primal source bit to a 32-bit blocked target
        /// </summary>
        /// <param name="src">The packed bit source</param>
        /// <param name="dst">The unpacked bit target</param>
        /// <param name="block">The target block index</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref readonly SpanBlock256<uint> unpack<T>(ReadOnlySpan<T> src, in SpanBlock256<uint> dst, int block)
            where T : unmanaged
        {
            const int blocklen = 8;
            const int blockcount = 1;

            unpack(skip(src, block), dst.Block(block));
            return ref dst;
        }

        /// <summary>
        /// Unpacks each primal source bit to a 32-bit target
        /// </summary>
        /// <param name="src">The packed bit source</param>
        /// <param name="dst">The unpacked bit target</param>
        [MethodImpl(Inline)]
        public static void unpack<T>(Span<T> src, in SpanBlock256<uint> dst)
            where T : unmanaged
                => unpack(src.ReadOnly(),dst);

        /// <summary>
        /// Unpacks each primal source bit to a 32-bit blocked target
        /// </summary>
        /// <param name="src">The packed bit source</param>
        /// <param name="dst">The unpacked bit target</param>
        /// <param name="block">The target block index</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly SpanBlock256<uint> unpack<T>(Span<T> src, in SpanBlock256<uint> dst, int block)
            where T : unmanaged
                => ref unpack(src.ReadOnly(),dst,block);
    }
}