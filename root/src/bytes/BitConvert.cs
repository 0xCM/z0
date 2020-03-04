//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Root;

    [ApiHost("bitconvert")]
    public static class BitConvert
    {
        /// <summary>
        /// Allocates and fills a buffer with source bytes
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static Span<byte> GetBytes<T>(in T src)
            where T : unmanaged
                => Bytes.get(in src);

        /// <summary>
        /// Converts a specified number of source elements to bytes
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="offset">The source offset</param>
        /// <param name="count">The number of source elements to convert</param>
        /// <typeparam name="T">The source element type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ReadOnlySpan<byte> GetBytes<T>(ReadOnlySpan<T> src, int offset, int count)
            where T : unmanaged
                => src.Slice(offset,count).AsBytes();

        /// <summary>
        /// Fills a caller-supplied buffer with source bytes
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="dst">The target buffer</param>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static void GetBytes<T>(in T src, Span<byte> dst)
            where T : unmanaged
                => Bytes.to(in src, dst);

        [MethodImpl(Inline), Op]
        public static short ToInt16(ReadOnlySpan<byte> src, int offset = 0)
            => Bytes.cell<short>(src, offset);

        [MethodImpl(Inline), Op]
        public static ushort ToUInt16(ReadOnlySpan<byte> src, int offset = 0)
            => Bytes.cell<ushort>(src, offset);

        [MethodImpl(Inline), Op]
        public static int ToInt32(ReadOnlySpan<byte> src, int offset = 0)
            => Bytes.cell<int>(src,offset);

        [MethodImpl(Inline), Op]
        public static uint ToUInt32(ReadOnlySpan<byte> src, int offset = 0)
            => Bytes.cell<uint>(src,offset);

        [MethodImpl(Inline), Op]
        public static long ToInt64(ReadOnlySpan<byte> src, int offset = 0)
            => Bytes.cell<long>(src, offset);
        
        [MethodImpl(Inline), Op]
        public static ulong ToUInt64(ReadOnlySpan<byte> src, int offset = 0)
            => Bytes.cell<ulong>(src, offset);

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