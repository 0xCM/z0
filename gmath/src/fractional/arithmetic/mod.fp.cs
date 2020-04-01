//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static Core;
    using static As;

    partial class gfp
    {
        /// <summary>
        /// Computes the modulus of floating-point operands
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        /// <typeparam name="T">The primal floating-point type</typeparam>
        [MethodImpl(Inline)]
        public static T mod<T>(T a, T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                 return generic<T>(fmath.mod(float32(a), float32(b)));
            else if(typeof(T) == typeof(double))
                 return generic<T>(fmath.mod(float64(a), float64(b)));
            else            
                throw Unsupported.define<T>();
        }

        [MethodImpl(Inline)]
        public static T modmul<T>(T a, T b, T m)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(math.modmul(float32(a), float32(b), float32(m)));
            else if(typeof(T) == typeof(double))
                return generic<T>(math.modmul(float64(a), float64(b), float64(m)));
            else
                throw Unsupported.define<T>();
        }
    }
}