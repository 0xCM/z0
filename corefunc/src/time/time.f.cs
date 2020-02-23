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
    /// Allocates, but does not start, a system counter
    /// </summary>
    [MethodImpl(Inline)]   
    public static SystemCounter counter() 
        => default;

    /// <summary>
    /// Allocates and optionally starts a system counter
    /// </summary>
    [MethodImpl(Inline)]   
    public static SystemCounter counter(bool start) 
    {
        var clock = counter();
        if(start)
            clock.Start();
        return clock;
    }

    /// <summary>
    /// Creates a new stopwatch and optionally start it
    /// </summary>
    /// <param name="start">Whether to start the new stopwatch</param>
    [MethodImpl(Inline)]   
    public static Stopwatch stopwatch(bool start = true) 
        => start ? Stopwatch.StartNew() : new Stopwatch();

    /// <summary>
    /// Captures a stopwatch duration
    /// </summary>
    /// <param name="sw">A running/stopped stopwatch</param>
    [MethodImpl(Inline)]   
    public static Duration snapshot(Stopwatch sw)     
        => Duration.Define(sw.ElapsedTicks);        

    /// <summary>
    /// Captures a stopwatch duration and the number of operations executed within the duration period
    /// </summary>
    /// <param name="sw">The running/stopped stopwatch</param>
    /// <param name="opcount">The operation count</param>
    /// <param name="label">The label associated with the measure, if specified</param>
    [MethodImpl(Inline)]   
    public static BenchmarkRecord optime(long opcount, Stopwatch sw, [CallerMemberName] string label = null)
        => BenchmarkRecord.Define(opcount, snapshot(sw), label);

    /// <summary>
    /// Captures a duration and the number of operations executed within the period
    /// </summary>
    /// <param name="time">The running time</param>
    /// <param name="opcount">The operation count</param>
    /// <param name="label">The label associated with the measure, if specified</param>
    [MethodImpl(Inline)]   
    public static BenchmarkRecord optime(long opcount, Duration time, [CallerMemberName] string label = null)
        => BenchmarkRecord.Define(opcount, time, label);

    public static DateTime now()
        => DateTime.Now;

    public static Date today()
        => DateTime.Today;

    /// <summary>
    /// Measures the respective times required to execute a pair of functions, each of which 
    /// iterate a computational block a specified number of times
    /// </summary>
    /// <param name="n">The number of computational block iterations</param>
    /// <param name="left">The first function</param>
    /// <param name="right">THe second function</param>
    public static OpTimePair measure(long n, string leftLabel, string rightLabel, Action<long> left, Action<long> right)
    {
        var lclock = counter(true);
        left(n);
        var lTime = BenchmarkRecord.Define(n, lclock.Stop(),leftLabel);
        
        var rclock = counter(true);
        right(n);
        var rTime = BenchmarkRecord.Define(n, rclock.Stop(),rightLabel);
        
        return (lTime, rTime);
    }
}