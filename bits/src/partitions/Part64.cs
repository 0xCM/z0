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

    /// <summary>
    /// Defines packing/unpacking operators that project to a 64-bit target
    /// </summary>
    static class Part64
    {        
        const ulong MLsb8 = (ulong)BitMask.Lsb64x8;

        [MethodImpl(Inline)]
        public static void pack8x1(in byte src, ref ulong dst)
            => dst = Bits.gather(src, MLsb8);

        [MethodImpl(Inline)]
        public static void unpack8x1(uint src, ref ulong dst)
            => dst = Bits.scatter(src, MLsb8);

        [MethodImpl(Inline)]
        public static void pack16x1(in byte src, ref ulong dst)
        {            
            const int width = 8;
            ref readonly var start = ref src;

            seekb(ref dst, 0) = Bits.gather(start, MLsb8);
            seekb(ref dst, width) = Bits.gather(skipb(in start, width), MLsb8);
        }

        [MethodImpl(Inline)]
        public static void unpack16x1(uint src, ref ulong dst)
        {
            seek(ref dst, 0) = Bits.scatter(src, MLsb8);
            seek(ref dst, 1) = Bits.scatter(src >> 8, MLsb8);
        }

        [MethodImpl(Inline)]
        public static void pack32x1(in byte src, ref ulong dst)
        {            
            const int width = 8;

            seekb(ref dst, 0*width) = Bits.gather(skipb(in src, 0*width), MLsb8);
            seekb(ref dst, 1*width) = Bits.gather(skipb(in src, 1*width), MLsb8);
            seekb(ref dst, 2*width) = Bits.gather(skipb(in src, 2*width), MLsb8);
            seekb(ref dst, 3*width) = Bits.gather(skipb(in src, 3*width), MLsb8);
        }

        [MethodImpl(Inline)]
        public static void unpack32x1(uint src, ref ulong dst)
        {
            unpack16x1(src, ref dst);
            unpack16x1(src >> 16, ref seekb(ref dst, 16));
        }

        [MethodImpl(Inline)]
        public static void pack64x1(in byte src, ref ulong dst)
        {            
            pack32x1(in src, ref dst);
            pack32x1(in skip(in src, 4), ref seekb(ref dst, 4));
        }

        [MethodImpl(Inline)]
        public static void unpack64x1(ulong src, ref ulong dst)
        {
            unpack32x1((uint)src, ref dst);
            unpack32x1((uint)(src >> 32), ref seekb(ref dst, 32));
        }
    }
}