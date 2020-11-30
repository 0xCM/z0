//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial class BitPack
    {
        /// <summary>
        /// Unpacks each primal source bit to a 32-bit target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="dst">The bit target</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static void unpack1x32<T>(T src, Span<uint> dst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                Bits.unpack1x32x8(uint8(src), dst);
            else if(typeof(T) == typeof(ushort))
                Bits.unpack1x32x16(uint16(src), dst);
            else if(typeof(T) == typeof(uint))
                Bits.unpack1x32x32(uint32(src), dst);
            else if(typeof(T) == typeof(ulong))
                Bits.unpack1x32x64(uint64(src), dst);
            else
                throw no<T>();
        }

        /// <summary>
        /// Unpacks each primal source bit to a 32-bit target
        /// </summary>
        /// <param name="src">The packed bit source</param>
        /// <param name="dst">The unpacked bit target</param>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static void unpack1x32<T>(ReadOnlySpan<T> src, in SpanBlock256<uint> dst)
            where T : unmanaged
        {
            var blockcount = dst.BlockCount;
            var bytes = src.Bytes();
            ref readonly var bitsrc = ref first(bytes);

            for(var block=0; block < blockcount; block++)
                Bits.unpack1x32x8(skip(bitsrc, block), dst.Block(block));
        }

        /// <summary>
        /// Unpacks each primal source bit to a 32-bit blocked target
        /// </summary>
        /// <param name="src">The packed bit source</param>
        /// <param name="dst">The unpacked bit target</param>
        /// <param name="block">The target block index</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly SpanBlock256<uint> unpack1x32<T>(ReadOnlySpan<T> src, in SpanBlock256<uint> dst, int block)
            where T : unmanaged
        {
            const int blocklen = 8;
            const int blockcount = 1;

            unpack1x32(skip(src, block), dst.Block(block));
            return ref dst;
        }

        /// <summary>
        /// Unpacks each primal source bit to a 32-bit target
        /// </summary>
        /// <param name="src">The packed bit source</param>
        /// <param name="dst">The unpacked bit target</param>
        [MethodImpl(Inline)]
        public static void unpack1x32<T>(Span<T> src, in SpanBlock256<uint> dst)
            where T : unmanaged
                => unpack1x32(src.ReadOnly(),dst);

        /// <summary>
        /// Unpacks each primal source bit to a 32-bit blocked target
        /// </summary>
        /// <param name="src">The packed bit source</param>
        /// <param name="dst">The unpacked bit target</param>
        /// <param name="block">The target block index</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly SpanBlock256<uint> unpack1x32<T>(Span<T> src, in SpanBlock256<uint> dst, int block)
            where T : unmanaged
                => ref unpack1x32(src.ReadOnly(), dst, block);
    }
}