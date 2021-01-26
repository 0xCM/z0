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
        /// Increments the source value
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline), Inc, Closures(NumericKind.Floats)]
        public static T inc<T>(T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(math.inc(float32(src)));
            else if(typeof(T) == typeof(double))
                return generic<T>(math.inc(float64(src)));
            else
                throw no<T>();
        }
    }
}