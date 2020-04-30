//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Numerics;
        
    partial class math
    {
        /// <summary>
        /// Computes floor(log(src,2))
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Log2]
        public static byte log2(byte src)
            => (byte)BitOperations.Log2((uint)src);

        /// <summary>
        /// Computes floor(log(src,2))
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Log2]
        public static ushort log2(ushort src)
            => (ushort)BitOperations.Log2((uint)src);

        /// <summary>
        /// Computes floor(log(src,2))
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Log2]
        public static uint log2(uint src)
            => (uint)BitOperations.Log2(src);

        /// <summary>
        /// Computes floor(log(src,2))
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Log2]
        public static ulong log2(ulong src)
            => (ulong)BitOperations.Log2(src);

        // [MethodImpl(Inline)]
        // static ref ulong log2(ref ulong dst, ref ulong x, ulong power)
        // {
        //     if(x >= 1ul << (int)power)
        //     {
        //         x >>= (int)power;
        //         dst |= power;
        //     }
        //     return ref dst;
        // }

        // [MethodImpl(Inline)]
        // static ulong log2(ulong x, ref ulong y, byte n)
        // {
        //     var z  = x;
        //     if(y >= 1ul << n)
        //     {
        //         y >>= n;
        //         z |= n;
        //     }
        //     return z;
        // }

        // [MethodImpl(Inline), Op]
        // public static ulong log2_new(ulong src)
        // {
        //     var x = 0ul;
        //     var y = src;
        //     x = log2(x, ref y, Pow2.T05);
        //     x = log2(x, ref y, Pow2.T04);
        //     x = log2(x, ref y, Pow2.T03);
        //     x = log2(x, ref y, Pow2.T02);
        //     x = log2(x, ref y, Pow2.T01);
            
        //     if(y >= 1 << 1)
        //         x |= 1;
        //     return x;
        // }

        // [MethodImpl(Inline), Op]
        // public static ulong log2(ulong src)
        // {
        //     var x = 0ul;
        //     var y = src;
        //     log2(ref x, ref y, Pow2.T05);
        //     log2(ref x, ref y, Pow2.T04);
        //     log2(ref x, ref y, Pow2.T03);
        //     log2(ref x, ref y, Pow2.T02);
        //     log2(ref x, ref y, Pow2.T01);
            
        //     if(y >= 1 << 1)
        //         x |= 1;
        //     return x;
        // }

        // [MethodImpl(Inline), Op]
        // public static uint log2(uint src)
        //     => (uint)log2((ulong)src);

        // [MethodImpl(Inline), Op]
        // public static byte log2(byte src)
        //     => (byte)log2((ulong)src);

        // [MethodImpl(Inline), Op]
        // public static ushort log2(ushort src)
        //     => (ushort)log2((ulong)src);
    }
}