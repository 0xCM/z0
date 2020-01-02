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
    /// Defines a closed interval [min,max]
    /// </summary>
    /// <param name="min">The inclusive left endpoint</param>
    /// <param name="max">The inclusive right endpoint</param>
    /// <typeparam name="T">The underlying type</typeparam>
    [MethodImpl(Inline)]
    public static Interval<T> domain<T>(T min, T max)
        where T : unmanaged
            => new Interval<T>(min,max, IntervalKind.Closed);

    /// <summary>
    /// Constructs the (left-closed | right-open) interval [min,max)
    /// </summary>
    /// <param name="min">The inclusive left endpoint</param>
    /// <param name="max">The exclusive right endpoint</param>
    /// <typeparam name="T">The underlying type</typeparam>
    [MethodImpl(Inline)]
    public static Interval<T> ldomain<T>(T min, T max)
        where T : unmanaged
            => new Interval<T>(min,max, IntervalKind.LeftClosed);

    /// <summary>
    /// Constructs the (right-closed | left-open) interval (min,max]
    /// </summary>
    /// <param name="min">The exclusive left endpoint</param>
    /// <param name="max">The inclusive right endpoint</param>
    /// <typeparam name="T">The underlying type</typeparam>
    [MethodImpl(Inline)]
    public static Interval<T> rdomain<T>(T min, T max)
        where T : unmanaged
            => new Interval<T>(min,max, IntervalKind.RightClosed);

    /// <summary>
    /// Constructs the open interval (min,max)
    /// </summary>
    /// <param name="min">The exclusive left endpoint</param>
    /// <param name="max">The exclusive right endpoint</param>
    /// <typeparam name="T">The underlying type</typeparam>
    [MethodImpl(Inline)]
    public static Interval<T> open<T>(T min, T max)
        where T : unmanaged
            => new Interval<T>(min,max, IntervalKind.Open);
}