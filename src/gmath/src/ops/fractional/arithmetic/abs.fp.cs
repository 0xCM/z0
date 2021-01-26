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
        /// Computes the absolute value of a primal FP scalar
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The FP type</typeparam>
        [MethodImpl(Inline), Abs, Closures(Closure)]
        public static T abs<T>(T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(fmath.abs(float32(src)));
            else if(typeof(T) == typeof(double))
                return generic<T>(fmath.abs(float64(src)));
            else
                throw no<T>();
        }
    }
}