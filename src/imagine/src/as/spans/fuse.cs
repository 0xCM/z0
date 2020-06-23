//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static AsInternal;

    partial struct As
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> fuse<T>(Span<T> xs, Span<T> ys, Func<T,T,T> f)
        {        
            var len = xs.Length;
            ref var xh = ref first(xs);
            ref var yh = ref first(ys);        
            for(var i = 0; i < len ; i++)
                seek(ref xh, i) = f(skip(in xh,i), skip(in yh, i));
            return xs;
        }     
    }
}