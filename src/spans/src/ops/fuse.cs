//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class Spans
    {
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Span<T> Fuse<T>(Span<T> xs, Span<T> ys, Func<T,T,T> f)
        {        
            var len = xs.Length;
            ref var xh = ref head(xs);
            ref var yh = ref head(ys);        
            for(var i = 0; i < len ; i++)
                seek(ref xh, i) = f(skip(in xh,i), skip(in yh, i));
            return xs;
        }     
    }
}