//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
 
    using static zfunc;
    using static As;

    partial class Bits
    {         
        /// <summary>
        /// Packs 2 bits into the least bits of an unsigned integer
        /// </summary>
        [MethodImpl(Inline)]
        public static uint bitpack(bit b0, bit b1)
        {
            var dst = (uint)b0;
            dst |= ((uint)b1 << 1);
            return dst;
        }

        /// <summary>
        /// Packs 3 bits into the least bits of an unsigned integer
        /// </summary>
        [MethodImpl(Inline)]
        public static uint bitpack(bit b0, bit b1, bit b2)
        {
            var dst = (uint)b0;
            dst |= ((uint)b1 << 1);
            dst |= ((uint)b2 << 2);
            return dst;
        }

        /// <summary>
        /// Packs 4 bits into the least bits of an unsigned integer
        /// </summary>
        [MethodImpl(Inline)]
        public static uint bitpack(bit b0, bit b1, bit b2, bit b3)
        {
            var dst = (uint)b0;
            dst |= ((uint)b1 << 1);
            dst |= ((uint)b2 << 2);
            dst |= ((uint)b3 << 3);
            return dst;
        }

        /// <summary>
        /// Packs 5 bits into the least bits of an unsigned integer
        /// </summary>
        [MethodImpl(Inline)]
        public static uint bitpack(bit b0, bit b1, bit b2, bit b3, bit b4)
        {
            var dst = (uint)b0;
            dst |= ((uint)b1 << 1);
            dst |= ((uint)b2 << 2);
            dst |= ((uint)b3 << 3);
            dst |= ((uint)b4 << 4);
            return dst;
        }

        /// <summary>
        /// Packs 8 bits into the least bits of an unsigned integer
        /// </summary>
        [MethodImpl(Inline)]
        public static uint bitpack(bit b0, bit b1, bit b2, bit b3, bit b4, bit b5, bit b6, bit b7)
        {
            var dst = bitpack(b0, b1, b2, b3);
            dst |= (bitpack(b4, b5, b6, b7) << 4);
            return dst;
        }

        /// <summary>
        /// Packs up to 32 source bits into the target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="dst">The bit taget</param>
        [MethodImpl(Inline)]
        public static ref uint bitpack(ReadOnlySpan<bit> src, ref uint dst)
        {
            var count = math.min(src.Length,32);
            ref readonly var start = ref head(src);
            for(var i=0; i<count; i++)
                dst |= ((uint)skip(in start, i) << i);
            return ref dst;
        }

        /// <summary>
        /// Packs 1 bits into the least bits of an unsigned integer
        /// </summary>
        [MethodImpl(Inline)]
        public static ref uint bitpack(N1 n, in bit src, ref uint dst)
        {
            dst |= (uint)src;
            return ref dst;
        }

        /// <summary>
        /// Packs 2 bits into the least bits of an unsigned integer
        /// </summary>
        [MethodImpl(Inline)]
        public static ref uint bitpack(N2 n, in bit src, ref uint dst)
        {
            dst |= ((uint)skip(in src, 0)) << 0;
            dst |= ((uint)skip(in src, 1)) << 1;
            return ref dst;
        }

        /// <summary>
        /// Packs 3 bits into the least bits of an unsigned integer
        /// </summary>
        [MethodImpl(Inline)]
        public static ref uint bitpack(N3 n, in bit src, ref uint dst)
        {
            dst |= ((uint)skip(in src, 0)) << 0;
            dst |= ((uint)skip(in src, 1)) << 1;
            dst |= ((uint)skip(in src, 2)) << 2;
            return ref dst;
        }

        /// <summary>
        /// Packs 4 bits into the least bits of an unsigned integer
        /// </summary>
        [MethodImpl(Inline)]
        public static ref uint bitpack(N4 n, in bit src, ref uint dst)
        {
            dst |= ((uint)skip(in src, 0)) << 0;
            dst |= ((uint)skip(in src, 1)) << 1;
            dst |= ((uint)skip(in src, 2)) << 2;
            dst |= ((uint)skip(in src, 3)) << 3;
            return ref dst;
        }

        /// <summary>
        /// Packs 8 bits into the least bits of an unsigned integer
        /// </summary>
        [MethodImpl(Inline)]
        public static ref uint bitpack(N8 n, in bit src, ref uint dst)
        {
            bitpack(n4, in src, ref dst);
            bitpack(n4, in skip(in src,4), ref seek(ref dst,4));
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref uint bitpack(N16 n, in bit src, ref uint dst)
        {
            bitpack(n8, in src, ref dst);
            bitpack(n8, in skip(in src,8), ref seek(ref dst,8));
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref uint bitpack(N32 n, in bit src, ref uint dst)
        {
            bitpack(n16, in src, ref dst);
            bitpack(n16, in skip(in src,16), ref seek(ref dst,16));
            return ref dst;
        }
    }
}