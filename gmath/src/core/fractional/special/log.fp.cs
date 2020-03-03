//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Root;    
    
    partial class fmath
    {
        /// <summary>
        /// Computes the base-2 log of the operand
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static float log2(float src)
            => MathF.Log2(src);

        /// <summary>
        /// Computes the base-2 log of the operand
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static double log2(double src)
            => Math.Log2(src);

        /// <summary>
        /// Computes the base-e log of the operand
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static float ln(float src)
            => MathF.Log(src);

        /// <summary>
        /// Computes the base-e log of the operand
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static double ln(double src)
            => Math.Log(src);

        /// <summary>
        /// Computes the log of the source value relative to an optionally-specified base
        /// which otherwise defaults to base-10
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="b">The log base</param>
        [MethodImpl(Inline), Op]
        public static float log(float src, float? b = null)
            => MathF.Log(src, b ?? 10);

        /// <summary>
        /// Computes the log of the source value relative to an optionally-specified base
        /// which otherwise defaults to base-10
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="b">The log base</param>
        [MethodImpl(Inline), Op]
        public static double log(double src, double? b = null)
            => Math.Log(src, b ?? 10);
    }
}