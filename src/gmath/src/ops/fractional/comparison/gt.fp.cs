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
        [MethodImpl(Inline), Gt, Closures(Closure)]
        public static bit gt<T>(T a, T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                 return fmath.gt(float32(a), float32(b));
            else if(typeof(T) == typeof(double))
                 return fmath.gt(float64(a), float64(b));
            else
                throw no<T>();
        }

        [MethodImpl(Inline), GtEq, Closures(Closure)]
        public static bit gteq<T>(T a, T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                 return fmath.gteq(float32(a), float32(b));
            else if(typeof(T) == typeof(double))
                 return fmath.gteq(float64(a), float64(b));
            else
                throw no<T>();
        }
    }
}