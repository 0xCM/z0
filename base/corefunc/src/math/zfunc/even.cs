//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Linq;
using System.Runtime.CompilerServices;

using Z0;

partial class zfunc
{

    /// <summary>
    /// Returns true if the test value is even by examining the least significant bit
    /// </summary>
    /// <param name="test">The value to test</param>
    [MethodImpl(Inline)]
    public static bit even(sbyte test)
        => (test & 1) == 0;

    /// <summary>
    /// Returns true if the test value is even by examining the least significant bit
    /// </summary>
    /// <param name="test">The value to test</param>
    [MethodImpl(Inline)]
    public static bit even(byte test)
        => (test & 1) == 0;

    /// <summary>
    /// Returns true if the test value is even by examining the least significant bit
    /// </summary>
    /// <param name="test">The value to test</param>
    [MethodImpl(Inline)]
    public static bit even(short test)
        => (test & 1) == 0;

    /// <summary>
    /// Returns true if the test value is even by examining the least significant bit
    /// </summary>
    /// <param name="test">The value to test</param>
    [MethodImpl(Inline)]
    public static bit even(int test)
        => (test & 1) == 0;

    /// <summary>
    /// Returns true if the test value is even by examining the least significant bit
    /// </summary>
    /// <param name="test">The value to test</param>
    [MethodImpl(Inline)]
    public static bit even(ushort test)
        => (test & 1) == 0;

    /// <summary>
    /// Returns true if the test value is even by examining the least significant bit
    /// </summary>
    /// <param name="test">The value to test</param>
    [MethodImpl(Inline)]
    public static bit even(uint test)
        => (test & 1) == 0;

    /// <summary>
    /// Returns true if the test value is even by examining the least significant bit
    /// </summary>
    /// <param name="test">The value to test</param>
    [MethodImpl(Inline)]
    public static bit even(long test)
        => (test & 1) == 0;

    /// <summary>
    /// Returns true if the test value is even by examining the least significant bit
    /// </summary>
    /// <param name="test">The value to test</param>
    [MethodImpl(Inline)]
    public static bit even(ulong test)
        => (test & 1) == 0;

}