//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    
    using System;
    using System.Runtime.CompilerServices;

    using static math;    

    public static class fmathx
    {
        [MethodImpl(Inline)]
        public static float Round(this float src, int scale)
            => fmath.round(src, scale);

        [MethodImpl(Inline)]
        public static double Round(this double src, int scale)
            => fmath.round(src, scale);

        [MethodImpl(Inline)]
        public static float Truncate(this float src)
            => (int)src;

        [MethodImpl(Inline)]
        public static double Truncate(this double src)
            => (long)src;

        [MethodImpl(Inline)]
        public static int ToBits(this float src)
            => BitConvert.ToInt32(src);

        [MethodImpl(Inline)]
        public static long ToBits(this double src)
            => BitConvert.ToInt64(src);

        /// <summary>
        /// Returns true if a value is the NaN representative
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static bool IsNaN(this float src)
            => float.IsNaN(src);

        /// <summary>
        /// Returns true if a value is the NaN representative
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static bool IsNaN(this double src)
            => double.IsNaN(src);

        /// <summary>
        /// Returns true if a floating point value represents an infinite value, false otherwise
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static bool Infinite(this float src)
            => float.IsPositiveInfinity(src) || float.IsNegativeInfinity(src);

        /// <summary>
        /// Returns true if a floating point value represents an infinite value, false otherwise
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static bool Infinite(this double src)
            => double.IsPositiveInfinity(src) || double.IsNegativeInfinity(src);

        /// <summary>
        /// Returns true if a floating point value is non-infinite
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static bool Finite(this float src)
            => !float.IsPositiveInfinity(src) && !float.IsNegativeInfinity(src) && !float.IsNaN(src);

        /// <summary>
        /// Returns true if a floating point value is non-infinite
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static bool Finite(this double src)
            => !double.IsPositiveInfinity(src) && !double.IsNegativeInfinity(src) && !double.IsNaN(src);

    }
}