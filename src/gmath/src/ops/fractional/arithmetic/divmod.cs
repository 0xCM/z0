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
        /// Computes dst = (div(a,b), mod(a,b)) for floating-point numeric types
        /// </summary>
        /// <param name="a">The dividend</param>
        /// <param name="b">The divisor</param>
        [MethodImpl(Inline), DivMod, Closures(Floats)]
        public static ConstPair<T> divmod<T>(T a, T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return Tuples.generic<T>(fmath.RefOps.divmod(float32(a), float32(b)));
            else if(typeof(T) == typeof(float))
                return Tuples.generic<T>(fmath.RefOps.divmod(float64(a), float64(b)));
            else
                throw no<T>();
        }
    }
}