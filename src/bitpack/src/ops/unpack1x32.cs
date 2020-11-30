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
        /// Distributes 32 packed source bits to 32 corresponding target bits
        /// </summary>
        /// <param name="src">The packed source bits</param>
        /// <param name="dst">The target buffer</param>
        [MethodImpl(Inline), Op]
        public static void unpack1x32(uint src, Span<bit> dst)
            => unpack1x8x32(src, ref u8(first(dst)));

        /// <summary>
        /// Unpacks 8 source bits over 8 32-bit target segments
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="buffer">The intermediate buffer</param>
        /// <param name="dst">The target buffer</param>
        [MethodImpl(Inline), Op]
        public static void unpack1x32x8(byte src, Span<uint> dst)
        {
            var buffer = z64;
            ref var tmp = ref uint8(ref buffer);
            ref var lead = ref first(dst);
            Bits.unpack1x8x8(src, ref tmp);
            vconvert(n64, in tmp, n256, n32).StoreTo(ref lead);
        }

        /// <summary>
        /// Unpacks 16 source bits over 16 32-bit target segments
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="buffer">The intermediate buffer</param>
        /// <param name="dst">The target buffer</param>
        [MethodImpl(Inline), Op]
        public static void unpack1x32x16(ushort src, Span<uint> dst)
        {
            var buffer = z64;
            ref var tmp = ref uint8(ref buffer);
            ref var lead = ref first(dst);

            Bits.unpack1x8x8((byte)src, ref tmp);
            vconvert(n64, in tmp, n256, n32).StoreTo(ref lead);
            Bits.unpack1x8x8((byte)(src >> 8), ref tmp);
            vconvert(n64, in tmp, n256, n32).StoreTo(ref lead, 8);
        }

        /// <summary>
        /// Unpacks 32 source bits over 32 32-bit target segments
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="buffer">The intermediate buffer</param>
        /// <param name="dst">The target buffer</param>
        [MethodImpl(Inline), Op]
        public static void unpack1x32x32(uint src, Span<uint> dst)
        {
            var buffer = z64;
            ref var tmp = ref z.uint8(ref buffer);
            ref var lead = ref z.first(dst);

            Bits.unpack1x8x8((byte)src, ref tmp);
            vconvert(n64, in tmp, n256, n32).StoreTo(ref lead);
            Bits.unpack1x8x8((byte)(src >> 8), ref tmp);
            vconvert(n64, in tmp, n256, n32).StoreTo(ref lead, 8);
            Bits.unpack1x8x8((byte)(src >> 16), ref tmp);
            vconvert(n64, in tmp, n256, n32).StoreTo(ref lead, 16);
            Bits.unpack1x8x8((byte)(src >> 24), ref tmp);
            vconvert(n64, in tmp, n256, n32).StoreTo(ref lead, 24);
        }

        /// <summary>
        /// Unpacks 64 source bits over 64 32-bit target segments
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="buffer">The intermediate buffer</param>
        /// <param name="dst">The target buffer</param>
        [MethodImpl(Inline), Op]
        public static void unpack1x32x64(ulong src, Span<uint> dst)
        {
            var buffer = z64;
            ref var tmp = ref uint8(ref buffer);
            ref var lead = ref first(dst);
            Bits.unpack1x8x8((byte)src, ref tmp);
            vconvert(n64, in tmp, n256, n32).StoreTo(ref lead);
            Bits.unpack1x8x8((byte)(src >> 8), ref tmp);
            vconvert(n64, in tmp, n256, n32).StoreTo(ref lead, 8);
            Bits.unpack1x8x8((byte)(src >> 16), ref tmp);
            vconvert(n64, in tmp, n256, n32).StoreTo(ref lead, 16);
            Bits.unpack1x8x8((byte)(src >> 24), ref tmp);
            vconvert(n64, in tmp, n256, n32).StoreTo(ref lead, 24);
            Bits.unpack1x8x8((byte)(src >> 32), ref tmp);
            vconvert(n64, in tmp, n256, n32).StoreTo(ref lead, 32);
            Bits.unpack1x8x8((byte)(src >> 40), ref tmp);
            vconvert(n64, in tmp, n256, n32).StoreTo(ref lead, 40);
            Bits.unpack1x8x8((byte)(src >> 48), ref tmp);
            vconvert(n64, in tmp, n256, n32).StoreTo(ref lead, 48);
            Bits.unpack1x8x8((byte)(src >> 56), ref tmp);
            vconvert(n64, in tmp, n256, n32).StoreTo(ref lead, 56);
        }

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
                unpack1x32x8(uint8(src), dst);
            else if(typeof(T) == typeof(ushort))
                unpack1x32x16(uint16(src), dst);
            else if(typeof(T) == typeof(uint))
                unpack1x32x32(uint32(src), dst);
            else if(typeof(T) == typeof(ulong))
                unpack1x32x64(uint64(src), dst);
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
                unpack1x32x8(skip(bitsrc, block), dst.Block(block));
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