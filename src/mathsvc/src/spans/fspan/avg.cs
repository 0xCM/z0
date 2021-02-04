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

    partial class fspan
    {
        [MethodImpl(Inline), Avg, Closures(Floats)]
        public static T avg<T>(ReadOnlySpan<T> src, bool @checked)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(mspan.avg(memory.float32(src), @checked));
            else if(typeof(T) == typeof(double))
                return generic<T>(mspan.avg(memory.float64(src), @checked));
            else
                throw no<T>();
        }

        [MethodImpl(Inline), Avg, Closures(Floats)]
        public static T avg<T>(ReadOnlySpan<T> src)
            where T : unmanaged
                => avg(src,true);
    }
}