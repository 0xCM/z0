//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    partial class gfp
    {
        /// <summary>
        /// Computes and returns the result r = x*y + z
        /// </summary>
        /// <param name="x">The first operand</param>
        /// <param name="y">The second operand</param>
        /// <param name="z">The third operand</param>
        /// <typeparam name="T">The floating point operand type</typeparam>
        [MethodImpl(Inline), Fma, Closures(Closure)]
        public static T fma<T>(T x, T y, T z)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(fmath.fma(float32(x), float32(y), float32(z)));
            else if(typeof(T) == typeof(double))
                return generic<T>(fmath.fma(float64(x), float64(y), float64(z)));
            else
                throw no<T>();
        }
   }
}