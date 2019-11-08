//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Diagnostics;
    
    using static zfunc;    
    
    partial class fmath
    {

        [MethodImpl(Inline)]
        public static ref float and(ref float lhs, float rhs)
        {
            lhs = and(lhs,rhs);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref double and(ref double lhs, double rhs)
        {
            lhs = and(lhs,rhs);
            return ref lhs;
        }

        /// <summary>
        /// Computes the absolute value of the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static float abs(float src)
            => MathF.Abs(src);

        /// <summary>
        /// Computes the absolute value of the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static double abs(double src)
            => Math.Abs(src);

        /// <summary>
        /// Computes the absolute value of the source in-place
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static ref float abs(ref float src)
        {
            src = abs(src);
            return ref src;
        }

        /// <summary>
        /// Computes the absolute value of the source in-place
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static ref double abs(ref double src)
        {
            src = abs(src);
            return ref src;
        }
    }
}