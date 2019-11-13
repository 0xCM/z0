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
                throw unsupported<T>();
        }

        /// <summary>
        /// Computes the modulus of the left and right operand and overwrites the left operand with the result
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        /// <typeparam name="T">The primal floating-point type</typeparam>
        [MethodImpl(Inline)]
        public static ref T mod<T>(ref T a, T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                 fmath.mod(ref float32(ref a), float32(b));
            else if(typeof(T) == typeof(double))
                 fmath.mod(ref float64(ref a), float64(b));
            else            
                throw unsupported<T>();
            return ref a;
        }
    }
}