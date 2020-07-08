//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    partial class math
    {
        /// <summary>
        /// Negates the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Negate]
        public static sbyte negate(sbyte src)
            => (sbyte)(-src);

        /// <summary>
        /// Computes the two's complement negation of the source value
        /// For example, -3 = -0b00000010 = 0b11111101
        /// </summary>
        /// <param name="src">The source value</param>
        /// <remarks>See https://en.wikipedia.org/wiki/Two%27s_complement</remarks>
        [MethodImpl(Inline), Negate]
        public static byte negate(byte src)
            => (byte)(~src + 1);
     
        /// <summary>
        /// Negates the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Negate]
        public static short negate(short src)
            => (short)(-src);

        /// <summary>
        /// Computes the two's complement negation of the source value
        /// </summary>
        /// <param name="src">The source value</param>
        /// <remarks>See https://en.wikipedia.org/wiki/Two%27s_complement</remarks>
        [MethodImpl(Inline), Negate]
        public static ushort negate(ushort src)
            => (ushort)(~src + 1);

        /// <summary>
        /// Negates the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Negate]
        public static int negate(int src)
            => -src;

        /// <summary>
        /// Computes the two's complement negation of the source value
        /// </summary>
        /// <param name="src">The source value</param>
        /// <remarks>See https://en.wikipedia.org/wiki/Two%27s_complement</remarks>
        [MethodImpl(Inline), Negate]
        public static uint negate(uint src)
            => 0 - src;

            //=> ~src + 1;

        /// <summary>
        /// Negates the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Negate]
        public static long negate(long src)
            => -src;

        /// <summary>
        /// Computes the two's complement negation of the source value
        /// </summary>
        /// <param name="src">The source value</param>
        /// <remarks>See https://en.wikipedia.org/wiki/Two%27s_complement</remarks>
        [MethodImpl(Inline), Negate]
        public static ulong negate(ulong src)
            => 0 - src;
            //=> ~ src + 1;


        /// <summary>
        /// Negates the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Negate]
        public static float negate(float src)
            => -src;

        /// <summary>
        /// Negates the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Negate]
        public static double negate(double src)
            => -src;

        /// <summary>
        /// Computes the two's complement of a 128-bit integer
        /// </summary>
        /// <param name="x">The integer, represented via paired hi/lo components</param>
        [MethodImpl(Inline), Op]
        public static ConstPair<ulong> negate(ConstPair<ulong> x)
            => math.add(not(x), ConstPair.define(1ul,0ul));
   }
}