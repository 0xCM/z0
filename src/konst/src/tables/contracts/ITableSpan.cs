//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;

    /// <summary>
    /// Characterizes an in-memory table store
    /// </summary>
    [SuppressUnmanagedCodeSecurity]
    public interface ITableSpan : ISpanBuffer
    {

    }

    /// <summary>
    /// Characterizes a parametric <see cref='ITableSpan' />
    /// </summary>
    /// <typeparam name="T">The table type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ITableSpan<T> : ITableSpan, ISpanBuffer<T>
        where T : struct
    {
    }

    [SuppressUnmanagedCodeSecurity]
    public interface ITableSpan<H,T> : ITableSpan<T>, ISpanBuffer<H,T>
        where H : struct, ITableSpan<H,T>
        where T : struct
    {

    }
}