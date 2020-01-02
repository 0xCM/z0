//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Linq;
using System.Runtime.CompilerServices;

using Z0;

partial class zfunc
{
    /// <summary>
    /// Returns true if the test value is odd by examining the least significant bit
    /// </summary>
    /// <param name="test">The value to test</param>
    [MethodImpl(Inline)]
    public static bit odd(sbyte test)
        => (test & 1) != 0;

    /// <summary>
    /// Returns true if the test value is odd by examining the least significant bit
    /// </summary>
    /// <param name="test">The value to test</param>
    [MethodImpl(Inline)]
    public static bit odd(byte test)
        => (test & 1) != 0;

    /// <summary>
    /// Returns true if the test value is odd by examining the least significant bit
    /// </summary>
    /// <param name="test">The value to test</param>
    [MethodImpl(Inline)]
    public static bit odd(short test)
        => (test & 1) != 0;

    /// <summary>
    /// Returns true if the test value is odd by examining the least significant bit
    /// </summary>
    /// <param name="test">The value to test</param>
    [MethodImpl(Inline)]
    public static bit odd(ushort test)
        => (test & 1) != 0;

    /// <summary>
    /// Returns true if the test value is odd by examining the least significant bit
    /// </summary>
    /// <param name="test">The value to test</param>
    [MethodImpl(Inline)]
    public static bit odd(int test)
        => (test & 1) != 0;

    /// <summary>
    /// Returns true if the test value is odd by examining the least significant bit
    /// </summary>
    /// <param name="test">The value to test</param>
    [MethodImpl(Inline)]
    public static bit odd(uint test)
        => (test & 1) != 0;

    /// <summary>
    /// Returns true if the test value is odd by examining the least significant bit
    /// </summary>
    /// <param name="test">The value to test</param>
    [MethodImpl(Inline)]
    public static bit odd(long test)
        => (test & 1) != 0;

    /// <summary>
    /// Returns true if the test value is odd by examining the least significant bit
    /// </summary>
    /// <param name="test">The value to test</param>
    [MethodImpl(Inline)]
    public static bit odd(ulong test)
        => (test & 1) != 0;
}

