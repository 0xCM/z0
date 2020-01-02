//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static zfunc;    
    
    partial class MathX
    {
        /// <summary>
        /// Negates the source value in-place
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static sbyte Negate(this sbyte src)
            => math.negate(src);

        /// <summary>
        /// Computes the two's complement negation of the source value in-place
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static byte Negate(this byte src)
            => math.negate(src);

        /// <summary>
        /// Negates the source value in-place
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static short Negate(this short src)
            => math.negate(src);

        /// <summary>
        /// Computes the two's complement negation of the source value in-place
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static ushort Negate(this ushort src)
            => math.negate(src);

        /// <summary>
        /// Negates the source value in-place
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static int Negate(this int src)
            => math.negate(src);

        /// <summary>
        /// Computes the two's complement negation of the source value in-place
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static uint Negate(this uint src)
            => math.negate(src);

        /// <summary>
        /// Negates the source value in-place
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static long Negate(this long src)
            => math.negate(src);

        /// <summary>
        /// Computes the two's complement negation of the source value in-place
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static ulong Negate(this ulong src)
            => math.negate(src);

        /// <summary>
        /// Negates the source value in-place
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static float Negate(this float src)
            => math.negate(src);

        /// <summary>
        /// Negates the source value in-place
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static double Negate(this double src)
            => math.negate(src);
    }
}