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

    partial struct gpack
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static T pack32x1<T>(Span<uint> src)
            where T : unmanaged
                => pack32x1_u<T>(src);

        /// <summary>
        /// Packs bitsize[T] values taken from the least significant bit of each source byte
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="mod">The bit selection modulus</param>
        /// <param name="offset">The source offset</param>
        /// <param name="t">A target type representative</param>
        /// <typeparam name="S">The source cell type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static T pack<S,T>(ReadOnlySpan<S> src, N8 mod, uint offset, T t = default)
            where S : unmanaged
            where T : unmanaged
                => pack_u<S,T>(src, mod, offset);

        /// <summary>
        /// Packs bitsize[T] values taken from the least significant bit of each source byte
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="mod">The bit selection modulus</param>
        /// <param name="offset">The source offset</param>
        /// <param name="t">A target type representative</param>
        /// <typeparam name="S">The source cell type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static T pack<S,T>(Span<S> src, N8 mod, uint offset, T t = default)
            where S : unmanaged
            where T : unmanaged
                => pack_u<S,T>(src.ReadOnly(), mod, offset);

        [MethodImpl(Inline)]
        static T pack_u<S,T>(ReadOnlySpan<S> src, N8 mod, uint offset)
            where S : unmanaged
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(pack8x8x1(src, offset));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(pack16x8x1(src, offset));
            else if(typeof(T) == typeof(uint))
                return generic<T>(pack32x8x1(src, offset));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(pack64x8x1(src, offset));
            else
                return pack_i<S,T>(src, mod, offset);
        }

        [MethodImpl(Inline)]
        static T pack_i<S,T>(ReadOnlySpan<S> src, N8 mod, uint offset)
            where S : unmanaged
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>((sbyte)pack8x8x1(src, offset));
            else if(typeof(T) == typeof(short))
                return generic<T>((short)pack16x8x1(src, offset));
            else if(typeof(T) == typeof(int))
                return generic<T>((int)pack32x8x1(src, offset));
            else if(typeof(T) == typeof(long))
                return generic<T>((long)pack64x8x1(src, offset));
            else
                throw no<T>();
        }

        [MethodImpl(Inline)]
        static T pack32x1_u<T>(Span<uint> src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(pack(src, n8));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(pack(src, n16));
            else if(typeof(T) == typeof(uint))
                return generic<T>(pack(src, n32));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(pack(src, n64));
            else
                return pack32x1_i<T>(src);
        }

        [MethodImpl(Inline)]
        static T pack32x1_i<T>(Span<uint> src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return Numeric.force<T>(BitPack.pack8x32x1(src));
            else if(typeof(T) == typeof(short))
                return Numeric.force<T>(BitPack.pack16x32x1(src));
            else if(typeof(T) == typeof(int))
                return Numeric.force<T>(BitPack.pack32x32x1(src));
            else if(typeof(T) == typeof(long))
                return Numeric.force<T>(BitPack.pack64x32x1(src));
            else
                throw no<T>();
        }

        /// <summary>
        /// Packs the leading 8 source bits
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="count">The number of bits to pack</param>
        [MethodImpl(Inline), Op]
        static byte pack(Span<uint> src, N8 count)
        {
            var v0 = cpu.vload(w256, first(convert(src, 0, width<byte>(w8))));
            return (byte)gcpu.vpacklsb(cpu.vpack128x8u(v0, w128));
        }

        /// <summary>
        /// Packs the 16 leading source bits
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="n">The number of bits to pack</param>
        [MethodImpl(Inline), Op]
        static ushort pack(Span<uint> src, N16 n)
        {
            ref readonly var unpacked = ref first(convert(src, 0, width<ushort>(w8)));
            var buffer = z16;
            return BitPack.pack16x32x1(unpacked, ref buffer);
        }

        /// <summary>
        /// Packs the 32 leading source bits
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="n">The number of bits to pack</param>
        [MethodImpl(Inline), Op]
        static uint pack(Span<uint> src, N32 n)
        {
            ref readonly var unpacked = ref first(src);
            var buffer = z32;
            return BitPack.pack32x32x1(unpacked, ref buffer);
        }

        /// <summary>
        /// Packs the 64 leading source bits
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="n">The number of bits to pack</param>
        [MethodImpl(Inline), Op]
        static ulong pack(Span<uint> src, N64 n)
        {
            ref readonly var unpacked = ref first(convert(src, 0, width<ulong>(w8)));
            var buffer = z64;
            return BitPack.pack64x32x1(unpacked, ref buffer);
        }

        [MethodImpl(Inline)]
        static Span<uint> convert(Span<uint> src, int offset, int count)
           => src.Slice(offset, count);
    }
}