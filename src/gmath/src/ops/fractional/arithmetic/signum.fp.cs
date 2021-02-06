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
        public static SignKind signum<T>(T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return math.signum(float32(src));
            else if(typeof(T) == typeof(double))
                return math.signum(float64(src));
            else
                throw no<T>();
        }
    }
}