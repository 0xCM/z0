//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

using Z0;

partial class zfunc
{

    [MethodImpl(Inline)]   
    public static HashSet<T> set<T>(params T[] src)
        => new HashSet<T>(src);

    [MethodImpl(Inline)]   
    public static HashSet<T> set<T>(ReadOnlySpan<T> src)
    {
        var dst = new HashSet<T>(src.Length);
        iter(src, item => dst.Add(item));
        return dst;
    }

    [MethodImpl(Inline)]   
    public static HashSet<T> set<T>(ReadOnlySpan<T> a, ReadOnlySpan<T> b)
    {
        var s1 = set(a);
        var s2 = set(b);
        return s1.SetUnion(s2);        
    }

}