//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static As;
    using static zfunc;

    partial class gfp
    {
        [MethodImpl(Inline), Op, PrimalClosures(NumericKind.Floats)]
        public static T square<T>(T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(fmath.square(float32(src)));
            else if(typeof(T) == typeof(double))
                return generic<T>(fmath.square(float64(src)));
            else            
                throw unsupported<T>();
        }           

    }

    partial class fmath
    {

        [MethodImpl(Inline), Op]
        public static float square(float src)
            => fmath.mul(src,src);

        [MethodImpl(Inline), Op]
        public static double square(double src)
            => fmath.mul(src,src);

        /// <summary>
        /// Computes the square root of the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static float sqrt(float src)
            => MathF.Sqrt(src);

        /// <summary>
        /// Computes the square root of the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static double sqrt(double src)
            => Math.Sqrt(src); 
    }

}
