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
        /// Computes the quotient of floating-point operands
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        /// <typeparam name="T">The primal floating-point type</typeparam>
        [MethodImpl(Inline), Op, PrimalClosures(NumericKind.Floats)]
        public static T div<T>(T a, T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                 return generic<T>(fmath.div(float32(a), float32(b)));
            else if(typeof(T) == typeof(double))
                 return generic<T>(fmath.div(float64(a), float64(b)));
            else            
                throw unsupported<T>();
        }

        [MethodImpl(Inline), PrimalClosures(NumericKind.Floats)]
        public static bool divides<T>(T a, T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                 return fmath.divides(float32(a), float32(b));
            else if(typeof(T) == typeof(double))
                 return fmath.divides(float64(a), float64(b));
            else            
                throw unsupported<T>();
        }
    }

    partial class fmath
    {
        [MethodImpl(Inline), Op]
        public static float div(float a, float b)
            => a / b;

        [MethodImpl(Inline), Op]
        public static double div(double a, double b)
            => a / b;

        [MethodImpl(Inline), Op]
        public static bit divides(float a, float b)
            => b % a == 0;

        [MethodImpl(Inline), Op]
        public static bit divides(double a, double b)
            => b % a == 0;
    }    
}