//-------------------------------------------------------------------------------------------
// MetaCore
// Author: Chris Moore, 0xCM@gmail.com
// License: MIT
//-------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Linq;

using Meta.Core;
using Meta.Core.Modules;

using M = Meta.Core.Modules;
using C = Meta.Core;

partial class metacore
{
    /// <summary>
    /// Constructs an IndexImmutable from a sequence
    /// </summary>
    /// <typeparam name="T">The item type</typeparam>
    /// <param name="s">The sequence from which to construct the IndexImmutable</param>
    /// <returns></returns>
    [DebuggerStepThrough, MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IndexImmutable<T> IndexImmutable<T>(Seq<T> s)
        => M.IndexImmutable.make(s);

    /// <summary>
    /// Constructs an IndexImmutable from a stream
    /// </summary>
    /// <typeparam name="T">The item type</typeparam>
    /// <param name="items">The items from which to construct the IndexImmutable</param>
    /// <returns></returns>
    [DebuggerStepThrough, MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static C.IndexImmutable<T> IndexImmutable<T>(IEnumerable<T> items)
        => Seq.make(items);

    /// <summary>
    /// Creates an array from the supplied items
    /// </summary>
    /// <typeparam name="T">The item type</typeparam>
    /// <param name="items">The items from which to construct the array</param>
    /// <returns></returns>
    [DebuggerStepThrough, MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IndexImmutable<T> IndexImmutable<T>(params T[] items)
        => M.IndexImmutable.items(items);
                                                                           
    /// <summary>
    /// Maps a function over an IndexImmutable
    /// </summary>
    /// <typeparam name="X">The input item type</typeparam>
    /// <typeparam name="Y">The outpout item type</typeparam>
    /// <param name="IndexImmutable">The source IndexImmutable</param>
    /// <param name="f">The function to apply</param>
    /// <returns></returns>
    [DebuggerStepThrough, MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IndexImmutable<Y> map<X, Y>(IndexImmutable<X> IndexImmutable, Func<X, Y> f)
        => M.IndexImmutable.map(IndexImmutable, f);

    

}