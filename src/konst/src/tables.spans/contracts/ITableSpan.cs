//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    /// <summary>
    /// Characterizes an in-memory table store
    /// </summary>
    [Free]
    public interface ITableSpan : ISpanBuffer
    {

    }

    /// <summary>
    /// Characterizes a parametric <see cref='ITableSpan' />
    /// </summary>
    /// <typeparam name="T">The table type</typeparam>
    [Free]
    public interface ITableSpan<T> : ITableSpan, ISpanBuffer<T>
        where T : struct
    {
    }

    [Free]
    public interface ITableSpan<H,T> : ITableSpan<T>, ISpanBuffer<H,T>
        where H : struct, ITableSpan<H,T>
        where T : struct
    {

    }
}