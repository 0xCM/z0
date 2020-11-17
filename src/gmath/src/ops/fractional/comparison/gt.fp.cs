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
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Bit32 gt<T>(T a, T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                 return fmath.gt(float32(a), float32(b));
            else if(typeof(T) == typeof(double))
                 return fmath.gt(float64(a), float64(b));
            else
                throw no<T>();
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Bit32 gteq<T>(T a, T b)
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