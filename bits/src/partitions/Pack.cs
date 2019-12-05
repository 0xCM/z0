//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics.X86;
 
    using static zfunc;

    partial class BitParts
    {            

        [MethodImpl(Inline)]
        public static void pack8x1(in byte src, ref ulong dst)
            => dst = Bits.gather(src, (ulong)BitMask.Lsb64x8);

        [MethodImpl(Inline)]
        public static void unpack8x1(uint src, Span<byte> dst)
            => unpack8x1(src, ref head64(dst));

        [MethodImpl(Inline)]
        public static void unpack8x1(uint src, ref ulong dst)
            => dst = Bits.scatter(src, (ulong)BitMask.Lsb64x8);

        [MethodImpl(Inline)]
        public static void pack16x1(in byte src, ref ulong dst)
        {            
            const int width = 8;
            const ulong M = (ulong)BitMask.Lsb64x8;

            ref readonly var start = ref src;
            seekb(ref dst, 0) = Bits.gather(start, M);
            seekb(ref dst, width) = Bits.gather(skipb(in start, width), M);
        }

        [MethodImpl(Inline)]
        public static void pack16x1(ReadOnlySpan<byte> src, Span<byte> dst)
            => pack16x1(head(src), ref head64(dst));

        [MethodImpl(Inline)]
        public static void unpack16x1(uint src, ref ulong dst)
        {
            const ulong M = (ulong)BitMask.Lsb64x8;

            seek(ref dst, 0) = Bits.scatter(src, M);
            seek(ref dst, 1) = Bits.scatter(src >> 8, M);
        }

        [MethodImpl(Inline)]
        public static void unpack16x1(uint src, Span<byte> dst)
            => unpack16x1(src, ref head64(dst));        

        [MethodImpl(Inline)]
        public static void pack32x1(in byte src, ref ulong dst)
        {            
            const int width = 8;
            const ulong M = (ulong)BitMask.Lsb64x8;

            seekb(ref dst, 0*width) = Bits.gather(skipb(in src, 0*width), M);
            seekb(ref dst, 1*width) = Bits.gather(skipb(in src, 1*width), M);
            seekb(ref dst, 2*width) = Bits.gather(skipb(in src, 2*width), M);
            seekb(ref dst, 3*width) = Bits.gather(skipb(in src, 3*width), M);
        }

        [MethodImpl(Inline)]
        public static void pack64x1(in byte src, ref ulong dst)
        {            
            pack32x1(in src, ref dst);
            pack32x1(in skip(in src, 4), ref seekb(ref dst, 4));
        }

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