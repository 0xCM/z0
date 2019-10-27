//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Diagnostics;

using Z0;

partial class zfunc
{

    /// <summary>
    /// Constructs the closed interval [left,right]
    /// </summary>
    /// <param name="left">The left end point</param>
    /// <param name="right">The right endpoint</param>
    /// <typeparam name="T">The underlying type</typeparam>
    [MethodImpl(Inline)]
    public static Interval<T> closed<T>(T left, T right)
        where T : unmanaged
            => new Interval<T>(left,right, IntervalKind.Closed);

    /// <summary>
    /// Constructs the left-open(or right-closed interval) interval (left,right]
    /// </summary>
    /// <param name="left">The left end point</param>
    /// <param name="right">The right endpoint</param>
    /// <typeparam name="T">The underlying type</typeparam>
    [MethodImpl(Inline)]
    public static Interval<T> leftopen<T>(T left, T right)
        where T : unmanaged
            => new Interval<T>(left,right, IntervalKind.LeftOpen);

    /// <summary>
    /// Constructs the left-closed (or right-open interval) interval [left,right)
    /// </summary>
    /// <param name="left">The left end point</param>
    /// <param name="right">The right endpoint</param>
    /// <typeparam name="T">The underlying type</typeparam>
    [MethodImpl(Inline)]
    public static Interval<T> leftclosed<T>(T left, T right)
        where T : unmanaged
            => new Interval<T>(left,right, IntervalKind.LeftClosed);

    /// <summary>
    /// Constructs the left-closed (or right-open interval) interval [left,right)
    /// </summary>
    /// <param name="left">The left end point</param>
    /// <param name="right">The right endpoint</param>
    /// <typeparam name="T">The underlying type</typeparam>
    [MethodImpl(Inline)]
    public static Interval<T> rightclosed<T>(T left, T right)
        where T : unmanaged
            => new Interval<T>(left,right, IntervalKind.RightClosed);

    /// <summary>
    /// Constructs the open interval (left,right)
    /// </summary>
    /// <param name="left">The left end point</param>
    /// <param name="right">The right endpoint</param>
    /// <typeparam name="T">The underlying type</typeparam>
    [MethodImpl(Inline)]
    public static Interval<T> open<T>(T left, T right)
        where T : unmanaged
            => new Interval<T>(left,right, IntervalKind.Open);
}