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
        [MethodImpl(Inline), Eq, Closures(Closure)]
        public static bit eq<T>(T a, T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                 return fmath.eq(float32(a), float32(b));
            else if(typeof(T) == typeof(double))
                 return fmath.eq(float64(a), float64(b));
            else
                throw no<T>();
        }


        [MethodImpl(Inline), Neq, Closures(Closure)]
        public static bit neq<T>(T a, T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                 return fmath.neq(float32(a), float32(b));
            else if(typeof(T) == typeof(double))
                 return fmath.neq(float64(a), float64(b));
            else
                throw no<T>();
        }
    }
}