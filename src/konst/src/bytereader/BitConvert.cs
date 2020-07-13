//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    [ApiHost("bitconvert")]
    public static class BitConvert
    {
        /// <summary>
        /// Allocates and fills a buffer with source bytes
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Span<byte> bytes<T>(in T src)
            where T : struct
                => z.bytes(src);

        [MethodImpl(Inline), Op]
        public static short ToInt16(ReadOnlySpan<byte> src, int offset = 0)
            => z.cell<short>(src, offset);

        [MethodImpl(Inline), Op]
        public static ushort ToUInt16(ReadOnlySpan<byte> src, int offset = 0)
            => z.cell<ushort>(src, offset);

        [MethodImpl(Inline), Op]
        public static int ToInt32(ReadOnlySpan<byte> src, int offset = 0)
            => z.cell<int>(src,offset);

        [MethodImpl(Inline), Op]
        public static uint ToUInt32(ReadOnlySpan<byte> src, int offset = 0)
            => z.cell<uint>(src,offset);

        [MethodImpl(Inline), Op]
        public static long ToInt64(ReadOnlySpan<byte> src, int offset = 0)
            => z.cell<long>(src, offset);
        
        [MethodImpl(Inline), Op]
        public static ulong ToUInt64(ReadOnlySpan<byte> src, int offset = 0)
            => z.cell<ulong>(src, offset);

        [MethodImpl(Inline), Op]
        public static float ToSingle(int src)
            => BitConverter.Int32BitsToSingle(src);

        [MethodImpl(Inline), Op]
        public static float ToSingle(uint src)
            => BitConverter.Int32BitsToSingle((int)src);

        [MethodImpl(Inline), Op]
        public static double ToDouble(long src)
            => BitConverter.Int64BitsToDouble(src);

        [MethodImpl(Inline), Op]
        public static double ToDouble(ulong src)
            => BitConverter.Int64BitsToDouble((long)src);

        [MethodImpl(Inline), Op]
        public static int ToInt32(float src)
            => BitConverter.SingleToInt32Bits(src);

        [MethodImpl(Inline), Op]
        public static uint ToUInt32(float src)
            => (uint)BitConverter.SingleToInt32Bits(src);

        [MethodImpl(Inline), Op]
        public static long ToInt64(double src)
            => BitConverter.DoubleToInt64Bits(src);

        [MethodImpl(Inline), Op]
        public static ulong ToUInt64(double src)
            => (ulong)BitConverter.DoubleToInt64Bits(src);
    }
}