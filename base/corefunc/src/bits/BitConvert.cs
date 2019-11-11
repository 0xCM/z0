//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using static AsIn;
    using static As;

    using static zfunc;

    public static class BitConvert
    {
        [MethodImpl(Inline)]
        public static T Convert<T>(ReadOnlySpan<T> src, int offset = 0)
            where T : unmanaged
                => Bytes.read<T>(src.AsBytes(), offset*size<T>());

        [MethodImpl(Inline)]
        public static Span<byte> GetBytes<T>(in T src)
            where T : unmanaged
                => Bytes.read(in src);

        [MethodImpl(Inline)]
        public static void GetBytes<T>(in T src, Span<byte> dst)
            where T : unmanaged
                => Bytes.read(in src, dst);

        [MethodImpl(Inline)]
        public static short ToInt16(ReadOnlySpan<byte> src, int offset = 0)
            => Bytes.read<short>(src, offset);

        [MethodImpl(Inline)]
        public static ushort ToUInt16(ReadOnlySpan<byte> src, int offset = 0)
            => Bytes.read<ushort>(src, offset);

        [MethodImpl(Inline)]
        public static int ToInt32(ReadOnlySpan<byte> src, int offset = 0)
            => Bytes.read<int>(src,offset);

        [MethodImpl(Inline)]
        public static uint ToUInt32(ReadOnlySpan<byte> src, int offset = 0)
            => Bytes.read<uint>(src,offset);

        [MethodImpl(Inline)]
        public static long ToInt64(ReadOnlySpan<byte> src, int offset = 0)
            => Bytes.read<long>(src, offset);

        [MethodImpl(Inline)]
        public static ulong ToUInt64(ReadOnlySpan<byte> src, int offset = 0)
            => Bytes.read<ulong>(src, offset);

        [MethodImpl(Inline)]
        public static float ToSingle(int src)
            => BitConverter.Int32BitsToSingle(src);

        [MethodImpl(Inline)]
        public static float ToSingle(uint src)
            => BitConverter.Int32BitsToSingle((int)src);

        [MethodImpl(Inline)]
        public static double ToDouble(long src)
            => BitConverter.Int64BitsToDouble(src);

        [MethodImpl(Inline)]
        public static double ToDouble(ulong src)
            => BitConverter.Int64BitsToDouble((long)src);

        [MethodImpl(Inline)]
        public static int ToInt32(float src)
            => BitConverter.SingleToInt32Bits(src);

        [MethodImpl(Inline)]
        public static uint ToUInt32(float src)
            => (uint) BitConverter.SingleToInt32Bits(src);

        [MethodImpl(Inline)]
        public static long ToInt64(double src)
            => BitConverter.DoubleToInt64Bits(src);

        [MethodImpl(Inline)]
        public static ulong ToUInt64(double src)
            => (ulong)BitConverter.DoubleToInt64Bits(src);


    }

}