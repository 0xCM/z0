//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Runtime.CompilerServices;
using System.Diagnostics;

using Z0;

partial class zfunc
{
    /// <summary>
    /// Creates a new stopwatch and optionally start it
    /// </summary>
    /// <param name="start">Whether to start the new stopwatch</param>
    [MethodImpl(Inline)]   
    public static Stopwatch stopwatch(bool start = true) 
        => start ? Stopwatch.StartNew() : new Stopwatch();

    [MethodImpl(Inline)]   
    public static DateTime now()
        => DateTime.Now;

    [MethodImpl(Inline)]   
    public static Date today()
        => DateTime.Today;
}