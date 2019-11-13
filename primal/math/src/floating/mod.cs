//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Diagnostics;
    
    using static zfunc;    
    
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

        [MethodImpl(Inline)]
        public static ref float mod(ref float a, in float b)
        {
            a = a % b;
            return ref a;
        }

        [MethodImpl(Inline)]
        public static ref double mod(ref double a, in double b)
        {
            a = a % b;
            return ref a;
        }
    }
}