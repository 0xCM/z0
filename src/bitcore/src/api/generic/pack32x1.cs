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

    partial class gbits
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static T pack32x1<T>(Span<uint> src, T t = default)
            where T : unmanaged
                => pack32x1_u<T>(src);

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
                return NumericCast.force<T>(pack(src, n8));
            else if(typeof(T) == typeof(short))
                return NumericCast.force<T>(pack(src, n16));
            else if(typeof(T) == typeof(int))
                return NumericCast.force<T>(pack(src, n32));
            else if(typeof(T) == typeof(long))
                return NumericCast.force<T>(pack(src, n64));
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
            var v0 = cpu.vload(n256, first(convert(src, 0, bitwidth<byte>(w8))));
            return (byte)gcpu.vpacklsb(cpu.vcompact8u(v0, w128));
        }

        /// <summary>
        /// Packs the 16 leading source bits
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="count">The number of bits to pack</param>
        [MethodImpl(Inline), Op]
        static ushort pack(Span<uint> src, N16 count)
        {
            ref readonly var unpacked = ref first(convert(src, 0, bitwidth<ushort>(w8)));
            var buffer = z16;
            return Bits.pack16x32x1(unpacked, ref buffer);
        }

        /// <summary>
        /// Packs the 32 leading source bits
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="count">The number of bits to pack</param>
        [MethodImpl(Inline), Op]
        static uint pack(Span<uint> src, N32 count)
        {
            ref readonly var unpacked = ref first(convert(src, 0, bitwidth<uint>(w8)));
            var buffer = z32;
            return Bits.pack32x32x1(unpacked, ref buffer);
        }

        /// <summary>
        /// Packs the 64 leading source bits
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="count">The number of bits to pack</param>
        [MethodImpl(Inline), Op]
        static ulong pack(Span<uint> src, N64 count)
        {
            ref readonly var unpacked = ref first(convert(src, 0, bitwidth<ulong>(w8)));
            var buffer = z64;
            return Bits.pack64x32x1(unpacked, ref buffer);
        }

        [MethodImpl(Inline)]
        static Span<uint> convert(Span<uint> src, int offset, int count)
           => src.Slice(offset, count);
    }
}