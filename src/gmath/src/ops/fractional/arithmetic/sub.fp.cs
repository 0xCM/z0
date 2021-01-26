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
        [MethodImpl(Inline), Sub, Closures(Closure)]
        public static T sub<T>(T a, T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(fmath.sub(float32(a), float32(b)));
            else if(typeof(T) == typeof(double))
                return generic<T>(fmath.sub(float64(a), float64(b)));
            else
                throw no<T>();
        }
    }
}