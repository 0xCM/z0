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
    public static ISet<T> union<T>(ISet<T> s1, ISet<T> s2)
        => new HashSet<T>(s1).AddRange(s2);

    [MethodImpl(Inline)]   
    public static ISet<T> intersect<T>(ISet<T> s1, ISet<T> s2)
        => s1.Intersection(s2);

    [MethodImpl(Inline)]   
    public static ISet<T> set<T>(IEnumerable<T> src)
        => src.ToHashSet();

    [MethodImpl(Inline)]   
    public static ISet<T> set<T>(params T[] src)
        => src.ToHashSet();

    [MethodImpl(Inline)]   
    public static ISet<T> set<T>(ReadOnlySpan<T> src)
    {
        var dst = new HashSet<T>(src.Length);
        iter(src, item => dst.Add(item));
        return dst;
    }

    [MethodImpl(Inline)]   
    public static ISet<T> set<T>(ReadOnlySpan<T> a, ReadOnlySpan<T> b)
    {
        var dst = new HashSet<T>(a.Length + b.Length);
        iter(a, item => dst.Add(item));
        iter(b, item => dst.Add(item));
        return dst;     
    }
}