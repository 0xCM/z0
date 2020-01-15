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
        /// Decrements the source value
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline), Op]
        public static T dec<T>(T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return(generic<T>(fmath.dec(float32(src))));
            else if(typeof(T) == typeof(double))
                return(generic<T>(fmath.dec(float64(src))));
            else            
                throw unsupported<T>();
        }           
    }

    partial class fmath
    {
        /// <summary>
        /// Decrements the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static float dec(float src)
            => --src;

        /// <summary>
        /// Decrements the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static double dec(double src)
            => --src;

        /// <summary>
        /// Computes the nonnegative distance between two values
        /// </summary>
        /// <param name="a">The first number</param>
        /// <param name="b">The second number</param>
        [MethodImpl(Inline), Op]
        public static ulong dist(double a, double b)
            => a >= b ? (ulong)(a - b) : (ulong)(b - a);

    }    
}