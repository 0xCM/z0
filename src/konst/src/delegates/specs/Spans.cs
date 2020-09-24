//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    /// <summary>
    /// Defines the signature of an operator that accepts a primal value and
    /// partitions the value, or portion thereof, into segments of common length
    /// </summary>
    /// <param name="src">The source value</param>
    /// <param name="dst">The target span of sufficent length to receive the partition segments</param>
    /// <typeparam name="S">The primal source type</typeparam>
    /// <typeparam name="T">The primal target type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public delegate void SpanPartitioner<S,T>(S src, Span<T> dst)
        where T : unmanaged;

    [SuppressUnmanagedCodeSecurity]
    public delegate Span<T> Imm8ShiftSpanOp<T>(ReadOnlySpan<T> src, byte imm8, Span<T> dst);

    /// <summary>
    /// Characterizes a function that produces spans values
    /// </summary>
    /// <typeparam name="T">The emission type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public delegate Span<T> SpanEmitter<T>();

    /// <summary>
    /// Characterizes a receiver that accepts a span
    /// </summary>
    /// <typeparam name="T">The stream element type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public delegate void SpanReceiver<T>(Span<T> src);
}