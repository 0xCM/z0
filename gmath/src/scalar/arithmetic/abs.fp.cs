//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
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
        /// <summary>
        /// Computes the absolute value of a primal FP scalar
        /// </summary>
        /// <param name="src">The soruce value</param>
        /// <typeparam name="T">The FP type</typeparam>
        [MethodImpl(Inline)]
        public static T abs<T>(T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(fmath.abs(float32(src)));
            else if(typeof(T) == typeof(double))
                return generic<T>(fmath.abs(float64(src)));
            else
                throw unsupported<T>();
        }        

    }

    partial class fmath
    {
        /// <summary>
        /// Computes the absolute value of the source
        /// </summary>
        /// <param name="a">The source value</param>
        [MethodImpl(Inline)]
        public static float abs(float a)
            => MathF.Abs(a);

        /// <summary>
        /// Computes the absolute value of the source
        /// </summary>
        /// <param name="a">The source value</param>
        [MethodImpl(Inline)]
        public static double abs(double a)
            => Math.Abs(a);

    }
}