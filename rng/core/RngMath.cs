//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    static class RngMath
    {
        [MethodImpl(Inline), Op]
        public static byte add(byte a, byte b)
            => (byte)(a + b);

        [MethodImpl(Inline), Op]
        public static ushort add(ushort a, ushort b)
            => (ushort)(a + b);

        /// <summary>
        /// Computes the two's complement negation of the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static byte negate(byte src)
            => (byte)(~src + 1);

        /// <summary>
        /// Computes the two's complement negation of the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static ushort negate(ushort src)
            => (ushort)(~src + 1);

        /// <summary>
        /// Computes the two's complement negation of the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static uint negate(uint src)
            => ~src + 1;

        /// <summary>
        /// Computes the two's complement negation of the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static ulong negate(ulong src)
            => ~src + 1;

        /// <summary>
        /// Computes b := a % m
        /// </summary>
        /// <param name="a">The source value</param>
        /// <param name="m">The modulus</param>
        [MethodImpl(Inline), Op]
        public static byte mod(byte a, byte m)
            => (byte)(a % m);

        /// <summary>
        /// Computes b := a % m
        /// </summary>
        /// <param name="a">The source value</param>
        /// <param name="m">The modulus</param>
        [MethodImpl(Inline), Op]
        public static ushort mod(ushort a, ushort m)
            => (ushort)(a % m);

        /// <summary>
        /// Computes b := a % m
        /// </summary>
        /// <param name="a">The source value</param>
        /// <param name="m">The modulus</param>
        [MethodImpl(Inline), Op]
        public static uint mod(uint a, uint m)
            => a % m;

        /// <summary>
        /// Computes b := a % m
        /// </summary>
        /// <param name="a">The source value</param>
        /// <param name="m">The modulus</param>
        [MethodImpl(Inline), Op]
        public static ulong mod(ulong a, ulong m)
            => a % m;

        /// <summary>
        /// Computes the XOR of the source value and the result of left-shifting 
        /// the source by a specified offset
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="offset">The number of bits to shift the source value leftwards</param>
        [MethodImpl(Inline)]
        public static uint xorsl(uint src, int offset)
            => src^(src << offset);

        /// <summary>
        /// Computes the XOR of the source value and the result of right-shifting 
        /// the source by a specified offset
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="offset">The number of bits to shift the source value rightwards</param>
        [MethodImpl(Inline)]
        public static uint xorsr(uint src, int offset)
            => src^(src >> offset);
    }
}