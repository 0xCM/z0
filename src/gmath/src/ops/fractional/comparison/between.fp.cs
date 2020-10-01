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
        [MethodImpl(Inline), Between, Closures(Closure)]
        public static Bit32 between<T>(T x, T a, T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return fmath.between(float32(x),float32(a), float32(b));
            else if(typeof(T) == typeof(double))
                return fmath.between(float64(x), float64(a), float64(b));
            else
                throw Unsupported.define<T>();
        }
    }
}