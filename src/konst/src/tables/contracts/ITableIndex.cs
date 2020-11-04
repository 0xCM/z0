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
    /// Characterizes an index-parametric <see cref='ITableSpan{T}' />
    /// /// </summary>
    /// <typeparam name="T">The table type</typeparam>
    /// <typeparam name="I">The index type</typeparam>
    [Free]
    public interface ITableIndex<T,I> : ITableSpan<T>
        where T : struct
        where I : unmanaged
    {
        ref T this[I index] {get;}
    }

    /// <summary>
    /// Characterizes a field-parametric <see cref='ITableIndex{T,I}'/>
    /// </summary>
    /// <typeparam name="F">The field specification</typeparam>
    /// <typeparam name="T">The table type</typeparam>
    /// <typeparam name="I">The index type</typeparam>
    [Free]
    public interface ITableIndex<F,T,I> : ITableIndex<T,I>
        where F : unmanaged, Enum
        where T : struct, ITableIndex<F,T,I>
        where I : unmanaged
    {

    }
}