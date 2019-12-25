//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static zfunc;    
    using static As;

    partial class gfp
    {
        [MethodImpl(Inline)]
        public static T ceil<T>(T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(fmath.ceil(float32(src)));
            else if(typeof(T) == typeof(double))
                return generic<T>(fmath.ceil(float64(src)));
            else
                throw unsupported<T>();
        }

    }

    partial class fmath
    {
        /// <summary>
        /// Computes the smallest integral value greater than or equal to the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static float ceil(float src)
            => MathF.Ceiling(src);

        /// <summary>
        /// Computes the smallest integral value greater than or equal to the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static double ceil(double src)
            => Math.Ceiling(src);

        /// <summary>
        /// Clamps the source value to an inclusive maximum
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="max">The maximum value</param>
        [MethodImpl(Inline)]
        public static float clamp(float src, float max)
            => src > max ? max : src;

        /// <summary>
        /// Clamps the source value to an inclusive maximum
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="max">The maximum value</param>
        [MethodImpl(Inline)]
        public static double clamp(double src, double max)
            => src > max ? max : src;

    }    
}