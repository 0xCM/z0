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
        /// Raises e to a specified exponent
        /// </summary>
        /// <param name="src">The soruce value</param>
        /// <typeparam name="T">The FP type</typeparam>
        [MethodImpl(Inline), Op]
        public static T exp<T>(T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(fmath.exp(float32(src)));
            else if(typeof(T) == typeof(double))
                return generic<T>(fmath.exp(float64(src)));
            else
                throw unsupported<T>();
        }        
    }

    partial class fmath
    {
        /// <summary>
        /// Raises e to a specified exponent
        /// </summary>
        /// <param name="pow">The exponent</param>
        [MethodImpl(Inline), Op]
        public static float exp(float pow)
            => MathF.Exp(pow);

        /// <summary>
        /// Raises e to a specified exponent
        /// </summary>
        /// <param name="pow">The exponent</param>
        [MethodImpl(Inline), Op]
        public static double exp(double pow)
            => Math.Exp(pow);

    }

}