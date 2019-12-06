//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
 
    using static zfunc;

    partial class Bits
    {
        [MethodImpl(Inline)]
        public static void unpack8x1(uint src, Span<byte> dst)
            => unpack8x1(src, ref head64(dst));

        [MethodImpl(Inline)]
        public static void unpack8x1(uint src, ref ulong dst)
            => dst = dinx.scatter(src, (ulong)BitMask.Lsb64x8);

        [MethodImpl(Inline)]
        public static void unpack16x1(uint src, ref ulong dst)
        {
            const ulong M = (ulong)BitMask.Lsb64x8;

            seek(ref dst, 0) = dinx.scatter(src, M);
            seek(ref dst, 1) = dinx.scatter(src >> 8, M);
        }

        [MethodImpl(Inline)]
        public static void unpack16x1(uint src, Span<byte> dst)
            => unpack16x1(src, ref head64(dst));        


        [MethodImpl(Inline)]
        public static void unpack32x1(uint src, ref ulong dst)
        {
            unpack16x1(src, ref dst);
            unpack16x1(src >> 16, ref seekb(ref dst, 16));
        }

        [MethodImpl(Inline)]
        public static void unpack32x1(uint src, Span<byte> dst)
            => unpack32x1(src, ref head64(dst));

        [MethodImpl(Inline)]
        public static void unpack64x1(ulong src, ref ulong dst)
        {
            unpack32x1((uint)src, ref dst);
            unpack32x1((uint)(src >> 32), ref seekb(ref dst, 32));
        }

        [MethodImpl(Inline)]
        public static void unpack64x1(ulong src, Span<byte> dst)
            => unpack64x1(src, ref head64(dst));
    }
}