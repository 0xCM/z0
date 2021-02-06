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
        [MethodImpl(Inline), Add, Closures(Closure)]
        public static T add<T>(T a, T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(math.add(float32(a), float32(b)));
            else if(typeof(T) == typeof(double))
                return generic<T>(math.add(float64(a), float64(b)));
            else
                throw no<T>();
        }
    }
}