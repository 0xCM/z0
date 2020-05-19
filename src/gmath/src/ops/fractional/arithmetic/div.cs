//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static Seed; 
    using static Memories;

    partial class gfp
    {
        /// <summary>
        /// Computes the quotient of floating-point operands
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        /// <typeparam name="T">The primal floating-point type</typeparam>
        [MethodImpl(Inline), Div, Closures(Floats)]
        public static T div<T>(T a, T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                 return generic<T>(fmath.div(float32(a), float32(b)));
            else if(typeof(T) == typeof(double))
                 return generic<T>(fmath.div(float64(a), float64(b)));
            else            
                throw Unsupported.define<T>();
        }

        [MethodImpl(Inline), Divides, Closures(NumericKind.Floats)]
        public static bool divides<T>(T a, T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                 return fmath.divides(float32(a), float32(b));
            else if(typeof(T) == typeof(double))
                 return fmath.divides(float64(a), float64(b));
            else            
                throw Unsupported.define<T>();
        }
    }
}