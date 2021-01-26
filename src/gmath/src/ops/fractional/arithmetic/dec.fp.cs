//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial class gfp
    {
        /// <summary>
        /// Decrements the source value
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline), Dec, Closures(Closure)]
        public static T dec<T>(T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return(generic<T>(math.dec(float32(src))));
            else if(typeof(T) == typeof(double))
                return(generic<T>(math.dec(float64(src))));
            else
                throw no<T>();
        }
    }
}