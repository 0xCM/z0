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
        [MethodImpl(Inline), Op, Closures(Floats)]
        public static T negate<T>(T lhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(fmath.negate(float32(lhs)));
            else if(typeof(T) == typeof(double))
                return generic<T>(fmath.negate(float64(lhs)));
            else
                throw no<T>();
        }
    }
}