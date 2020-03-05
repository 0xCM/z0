//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Runtime.CompilerServices;

using Z0;

partial class zfunc
{
    /// <summary>
    /// Constructs the (left-closed | right-open) interval [min,max)
    /// </summary>
    /// <param name="min">The inclusive left endpoint</param>
    /// <param name="max">The exclusive right endpoint</param>
    /// <typeparam name="T">The underlying type</typeparam>
    [MethodImpl(Inline)]
    public static Interval<T> ldomain<T>(T min, T max)
        where T : unmanaged
            => Interval.define(min,max,IntervalKind.LeftClosed);

}