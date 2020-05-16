//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    
    public static partial class XTend
    {
        [MethodImpl(Inline)]
        public static unsafe Span<byte> AsBytes(this short src)
            => ByteReader.ReadAll(src);

        [MethodImpl(Inline)]
        public static unsafe Span<byte> AsBytes(this ushort src)
            => ByteReader.ReadAll(src);

        [MethodImpl(Inline)]
        public static unsafe Span<byte> AsBytes(this int src)
            => ByteReader.ReadAll(src);

        [MethodImpl(Inline)]
        public static unsafe Span<byte> AsBytes(this uint src)
            => ByteReader.ReadAll(src);

        [MethodImpl(Inline)]
        public static unsafe Span<byte> AsBytes(this long src)
            => ByteReader.ReadAll(src);

        [MethodImpl(Inline)]
        public static unsafe Span<byte> AsBytes(this ulong src)
            => ByteReader.ReadAll(src);

        [MethodImpl(Inline)]
        public static unsafe Span<byte> AsBytes(this double src)
            => ByteReader.ReadAll(src);

        [MethodImpl(Inline)]
        public static unsafe Span<byte> AsBytes(this float src)
            => ByteReader.ReadAll(src);


        [MethodImpl(Inline)]
        public static unsafe byte[] ToByteArray(this short src)
            => ByteReader.ReadAll(src).ToArray();

        [MethodImpl(Inline)]
        public static unsafe byte[] ToByteArray(this ushort src)
            => ByteReader.ReadAll(src).ToArray();

        [MethodImpl(Inline)]
        public static unsafe byte[] ToByteArray(this int src)
            => ByteReader.ReadAll(src).ToArray();

        [MethodImpl(Inline)]
        public static unsafe byte[] ToByteArray(this uint src)
            => ByteReader.ReadAll(src).ToArray();

        [MethodImpl(Inline)]
        public static unsafe byte[] ToByteArray(this long src)
            => ByteReader.ReadAll(src).ToArray();

        [MethodImpl(Inline)]
        public static unsafe byte[] ToByteArray(this ulong src)
            => ByteReader.ReadAll(src).ToArray();

        [MethodImpl(Inline)]
        public static unsafe byte[] ToByteArray(this float src)
            => ByteReader.ReadAll(src).ToArray();

        [MethodImpl(Inline)]
        public static unsafe byte[] ToByteArray(this double src)
            => ByteReader.ReadAll(src).ToArray();

    }
}