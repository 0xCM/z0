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

}