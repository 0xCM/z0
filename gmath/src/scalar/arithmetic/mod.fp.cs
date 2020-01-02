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
    }

    partial class fmath
    {
        /// <summary>
        /// Computes the remainder of the quotient of the operands
        /// </summary>
        /// <param name="a">The dividend</param>
        /// <param name="b">The divisor</param>
        [MethodImpl(Inline)]
        public static float fmod(float a, float b)
            => MathF.IEEERemainder(a,b);

        /// <summary>
        /// Computes the remainder of the quotient of the operands
        /// </summary>
        /// <param name="a">The dividend</param>
        /// <param name="b">The divisor</param>
        [MethodImpl(Inline)]
        public static double fmod(double a, double b)
            => Math.IEEERemainder(a,b);

        [MethodImpl(Inline)]
        public static float mod(float a, float b)
            => a % b;

        [MethodImpl(Inline)]
        public static double mod(double a, double b)
            => a % b;
    }    
}