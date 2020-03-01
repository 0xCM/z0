//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

using Z0;

partial class zfunc
{
    /// <summary>
    /// Iterates over the supplied items, invoking a receiver for each
    /// </summary>
    /// <param name="src">The source items</param>
    /// <param name="f">The receiver</param>
    /// <typeparam name="T">The item type</typeparam>
    public static void iter<T>(IEnumerable<T> items, Action<T> action, bool pll = false)
        => Root.iter(items,action,pll);

    /// <summary>
    /// Inovkes an action for each element in a source span
    /// </summary>
    /// <param name="src">The source span</param>
    /// <param name="f">The receiver</param>
    /// <typeparam name="T">The element type</typeparam>
    [MethodImpl(Inline)]
    public static void iter<T>(ReadOnlySpan<T> src, Action<T> f)
    {
        ref readonly var input = ref head(src);
        int count = src.Length;

        for(var i=0; i<count; i++)
            f(skip(input,i));
    }

    /// <summary>
    /// Inovkes an action for each pair of elements in source spans of equal length
    /// </summary>
    /// <param name="src">The source span</param>
    /// <param name="f">The receiver</param>
    /// <typeparam name="T">The element type</typeparam>
    [MethodImpl(Inline)]
    public static void iter<T>(ReadOnlySpan<T> first, ReadOnlySpan<T> second, Action<T,T> f)
    {
        var count = length(first,second);
        ref readonly var x = ref head(first);
        ref readonly var y = ref head(second);
        
        for(var i=0; i<count; i++)
            f(skip(x,i),skip(y,i));
    }

    /// <summary>
    /// Inovkes an action for each pair of elements in source spans of equal length
    /// </summary>
    /// <param name="src">The source span</param>
    /// <param name="f">The receiver</param>
    /// <typeparam name="T">The element type</typeparam>
    [MethodImpl(Inline)]
    public static void iter<T>(Span<T> first, Span<T> second, Action<T,T> f)
        => iter(first.ReadOnly(), second.ReadOnly(),f);

    /// <summary>
    /// Inovkes an action for each element in a source span
    /// </summary>
    /// <param name="src">The source span</param>
    /// <param name="f">The receiver</param>
    /// <typeparam name="T">The element type</typeparam>
    [MethodImpl(Inline)]
    public static void iteri<T>(ReadOnlySpan<T> src, Action<int,T> f)
    {
        ref readonly var input = ref head(src);
        int count = src.Length;

        for(var i=0; i<count; i++)
            f(i,skip(input,i));
    }


    /// <summary>
    /// Aplies an action to the sequence of integers min,min+1,...,max - 1
    /// </summary>
    /// <param name="min">The inclusive lower bound of the sequence</param>
    /// <param name="max">The non-inclusive upper bound of the sequence
    /// over intergers over which iteration will occur</param>
    /// <param name="f">The action to be applied to each  value</param>
    public static void iteri(int min, int max, Action<int> f)
    {
       for(var i = min; i< max; i++) 
            f(i);
    }


    /// <summary>
    /// Applies an action to the increasing sequence of integers 0,1,2,...,count - 1
    /// </summary>
    /// <param name="count">The number of times the action will be invoked
    /// <param name="f">The action to be applied to each value</param>
    public static void iteri(int count, Action<int> f)
    {
       for(var i = 0; i< count; i++) 
            f(i);
    }

    /// <summary>
    /// Attaches a 0-based integer sequence to the input value sequence and
    /// yield the paired sequence elements
    /// </summary>
    /// <param name="i">The index of the paired value</param>
    /// <param name="value">The indexed value</param>
    /// <typeparam name="T">The item type</typeparam>
    public static IEnumerable<Pair<int, T>> iteri<T>(IEnumerable<T> items)
    {
        var idx = 0;
        foreach(var item in items)
            yield return (idx++, item);
    }

}