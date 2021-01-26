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
        [MethodImpl(Inline), Lt, Closures(Closure)]
        public static Bit32 lt<T>(T lhs, T rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                 return fmath.lt(float32(lhs), float32(rhs));
            else if(typeof(T) == typeof(double))
                 return fmath.lt(float64(lhs), float64(rhs));
            else
                throw no<T>();
        }

        [MethodImpl(Inline), LtEq, Closures(Closure)]
        public static Bit32 lteq<T>(T lhs, T rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                 return fmath.lteq(float32(lhs), float32(rhs));
            else if(typeof(T) == typeof(double))
                 return fmath.lteq(float64(lhs), float64(rhs));
            else
                throw no<T>();
        }
    }
}