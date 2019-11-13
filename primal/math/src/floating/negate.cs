//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static zfunc;    
    
    partial class fmath
    {
        /// <summary>
        /// Negates the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static float negate(float src)
            => -src;

        /// <summary>
        /// Negates the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static double negate(double src)
            => -src;
 
        /// <summary>
        /// Negates the source value in-place
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static ref float negate(ref float src)
        {
            src = - src;
            return ref src;
        }

        /// <summary>
        /// Negates the source value in-place
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static ref double negate(ref double src)
        {
            src = - src;
            return ref src;
        } 
    }
}