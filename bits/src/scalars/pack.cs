//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using Z0;
 
    using static zfunc;
    
    partial class Bits
    {         
        /// <summary>
        /// Packs 2 bits into the least bits of an unsigned integer
        /// </summary>
        [MethodImpl(Inline)]
        public static uint pack(bit b0, bit b1)
        {
            var dst = (uint)b0;
            dst |= ((uint)b1 << 1);
            return dst;
        }

        /// <summary>
        /// Packs 3 bits into the least bits of an unsigned integer
        /// </summary>
        [MethodImpl(Inline)]
        public static uint pack(bit b0, bit b1, bit b2)
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
        public static uint pack(bit b0, bit b1, bit b2, bit b3)
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
        public static uint pack(bit b0, bit b1, bit b2, bit b3, bit b4)
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
        public static uint pack(bit b0, bit b1, bit b2, bit b3, bit b4, bit b5, bit b6, bit b7)
        {
            var dst = pack(b0, b1, b2, b3);
            dst |= (pack(b4, b5, b6, b7) << 4);
            return dst;
        }

        /// <summary>
        /// Packs up to 32 source bits into the target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="dst">The bit taget</param>
        [MethodImpl(Inline)]
        public static ref uint pack(ReadOnlySpan<bit> src, ref uint dst)
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
        public static ref uint pack(N1 n, in bit src, ref uint dst)
        {
            dst |= (uint)src;
            return ref dst;
        }

        /// <summary>
        /// Packs 2 bits into the least bits of an unsigned integer
        /// </summary>
        [MethodImpl(Inline)]
        public static ref uint pack(N2 n, in bit src, ref uint dst)
        {
            dst |= ((uint)skip(in src, 0)) << 0;
            dst |= ((uint)skip(in src, 1)) << 1;
            return ref dst;
        }

        /// <summary>
        /// Packs 3 bits into the least bits of an unsigned integer
        /// </summary>
        [MethodImpl(Inline)]
        public static ref uint pack(N3 n, in bit src, ref uint dst)
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
        public static ref uint pack(N4 n, in bit src, ref uint dst)
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
        public static ref uint pack(N8 n, in bit src, ref uint dst)
        {
            pack(n4, in src, ref dst);
            pack(n4, in skip(in src,4), ref seek(ref dst,4));
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref uint pack(N16 n, in bit src, ref uint dst)
        {
            pack(n8, in src, ref dst);
            pack(n8, in skip(in src,8), ref seek(ref dst,8));
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref uint pack(N32 n, in bit src, ref uint dst)
        {
            pack(n16, in src, ref dst);
            pack(n16, in skip(in src,16), ref seek(ref dst,16));
            return ref dst;
        }

        /// <summary>
        /// Packs 2 bytes into an unsigned 16-bit integer
        /// </summary>
        [MethodImpl(Inline)]
        public static ushort pack(byte x0, byte x1)
            => (ushort)((ushort)x0 << 0 * 8 | (ushort)x1 << 1 * 8);

        /// <summary>
        /// Packs 2 unsigned 16-bit integers into an unsigned 32-bit integer
        /// </summary>
        [MethodImpl(Inline)]
        public static uint pack(ushort x0, ushort x1)
              => (uint)x0 << 0 * 16 | (uint)x1 << 1 * 16;

        /// <summary>
        /// Packs 2 unsigned 32-bit integers into an unsigned 64-bit integer
        /// </summary>
        [MethodImpl(Inline)]
        public static ulong pack(in uint x0, in uint x1)
              => (ulong)x0 | (ulong)x1 << 32;
        
        /// <summary>
        /// Packs 4 bytes into an unsigned 32-bit integer
        /// </summary>
        [MethodImpl(Inline)]
        public static uint pack(byte x0, byte x1, byte x2, byte x3)
            => (uint)x0 << 0 * 8 | (uint)x1 << 1 * 8 | (uint)x2 << 2 * 8 | (uint)x3 << 3 * 8;

        /// <summary>
        /// Packs 4 unsigned 16-bit integers into an unsigned 64-bit integer
        /// </summary>
        [MethodImpl(Inline)]
        public static ulong pack(ushort x0, ushort x1, ushort x2, ushort x3)
            => (uint)x0 << 0 * 16 | (uint)x1 << 1 * 16 | (uint)x2 << 2 * 16 | (uint)x3 << 3 * 16;

        /// <summary>
        /// Packs 8 bytes into an unsigned 64-bit integer
        /// </summary>
        [MethodImpl(Inline)]
        public static ulong pack(byte x0, byte x1, byte x2, byte x3, byte x4, byte x5, byte x6, byte x7)
        {            
            return 
              (ulong)x0 << 0 * 8
            | (ulong)x1 << 1 * 8
            | (ulong)x2 << 2 * 8
            | (ulong)x3 << 3 * 8
            | (ulong)x4 << 4 * 8
            | (ulong)x5 << 5 * 8
            | (ulong)x6 << 6 * 8
            | (ulong)x7 << 7 * 8
            ;
        }        
    }
}