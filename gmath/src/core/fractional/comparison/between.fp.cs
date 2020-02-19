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
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Floats)]
        public static bit between<T>(T x, T a, T b)    
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return fmath.between(float32(x),float32(a), float32(b));
            else if(typeof(T) == typeof(double))
                return fmath.between(float64(x), float64(a), float64(b));
            else            
                throw unsupported<T>();
        }        

    }

    partial class fmath
    {
        /// <summary>
        /// Returns true if the the test value lies in the closed interval formed by lower and upper bounds
        /// </summary>
        /// <param name="x">The test value</param>
        /// <param name="a">The lower bound</param>
        /// <param name="b">The uppper bound</param>
        [MethodImpl(Inline), Op]
        public static bit between(float x, float a, float b)    
            => x >= a && x <= b;

        /// <summary>
        /// Returns true if the the test value lies in the closed interval formed by lower and upper bounds
        /// </summary>
        /// <param name="x">The test value</param>
        /// <param name="a">The lower bound</param>
        /// <param name="b">The uppper bound</param>
        [MethodImpl(Inline), Op]
        public static bit between(double x, double a, double b)    
            => x >= a && x <= b;
    }
}