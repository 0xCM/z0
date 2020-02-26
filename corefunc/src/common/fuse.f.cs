//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Runtime.CompilerServices;

using Z0;
using static Z0.refs;

partial class zfunc
{ 
    public static Span<T> Fuse<T>(this Span<T> xs, Span<T> ys, Func<T,T,T> f)
    {        
        var len = length(xs,ys);
        ref var xh = ref head(xs);
        ref var yh = ref head(ys);        
        for(var i = 0; i < len ; i++)
            seek(ref xh, i) = f(skip(in xh,i), skip(in yh, i));
        return xs;
    }
}