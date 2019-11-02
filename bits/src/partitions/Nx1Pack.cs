//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics.X86;
    using Z0;
 
    using static zfunc;
    using static Bits;

    partial class BitParts
    {        
        const ulong MPack1 = (ulong)BitMask64.Lsb8;


        [MethodImpl(Inline)]
        public static void pack16x1(ReadOnlySpan<byte> src, Span<byte> dst)
            => pack16x1(src, ref head64(dst));

        [MethodImpl(Inline)]
        public static void pack32x1(ReadOnlySpan<byte> src, Span<byte> dst)
        {            
            pack16x1(src, dst);
            pack16x1(src.Slice(16), dst.Slice(2));
        }

        [MethodImpl(Inline)]
        public static void pack64x1(ReadOnlySpan<byte> src, Span<byte> dst)
        {
            pack32x1(src,dst);
            pack32x1(src.Slice(32), dst.Slice(4));
        }

        [MethodImpl(Inline)]
        public static void unpack8x1(uint src, Span<byte> dst)
            => unpack8x1(src, ref head64(dst));

        [MethodImpl(Inline)]
        public static void unpack16x1(uint src, Span<byte> dst)
            => unpack16x1(src, ref head64(dst));        

        [MethodImpl(Inline)]
        public static void unpack32x1(uint src, Span<byte> dst)
            => unpack32x1(src, ref head64(dst));

        [MethodImpl(Inline)]
        public static void unpack64x1(ulong src, Span<byte> dst)
            => unpack64x1(src, ref head64(dst));

        [MethodImpl(Inline)]
        static void unpack32x1(uint src, ref ulong dst)
        {
            unpack16x1(src, ref dst);
            unpack16x1(src >> 16, ref seekb(ref dst, 16));
        }

        [MethodImpl(Inline)]
        static void unpack64x1(ulong src, ref ulong dst)
        {
            unpack32x1((uint)src, ref dst);
            unpack32x1((uint)(src >> 32), ref seekb(ref dst, 32));
        }

        [MethodImpl(Inline)]
        static void unpack8x1(uint src, ref ulong dst)
            => dst = Bits.scatter(src, MPack1);

        [MethodImpl(Inline)]
        static void unpack16x1(uint src, ref ulong dst)
        {
            seek(ref dst, 0) = Bits.scatter(src, MPack1);
            seek(ref dst, 1) = Bits.scatter(src >> 8, MPack1);
        }

        [MethodImpl(Inline)]
        static void pack16x1(ReadOnlySpan<byte> src, ref ulong dst)
        {            
            const int width = 8;
            ref readonly var start = ref head64(src);

            seekb(ref dst, 0) = Bits.gather(start, MPack1);
            seekb(ref dst, width) = Bits.gather(skipb(in start, width), MPack1);
        }

        [MethodImpl(Inline)]
        static void pack32x1(ReadOnlySpan<byte> src, ref ulong dst)
        {   
            pack16x1(src, ref dst);
            pack16x1(src.Slice(16), ref seekb(ref dst, 2));
        }
    }
}