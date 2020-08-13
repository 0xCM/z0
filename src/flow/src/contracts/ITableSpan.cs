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
    public interface ITableSpan
    {
        /// <summary>
        /// The number of elements covered
        /// </summary>
        CellCount Count {get;}

        /// <summary>
        /// A bow to the ubiquitous and unreasonable devotion to *signed* 32-bit integers
        /// </summary>
        int Length {get;}
    }

    /// <summary>
    /// Characterizes a parametric <see cref='ITableSpan' />
    /// </summary>
    /// <typeparam name="T">The table type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ITableSpan<T> : ITableSpan
        where T : struct, ITable
    {
        Span<T> Edit {get;}        

        ReadOnlySpan<T> View {get;}

        ref T this[long index] {get;}

        ref T this[ulong index] {get;}
    }

    /// <summary>
    /// Characterizes an index-parametric <see cref='ITableSpan{T}' />
    /// /// </summary>
    /// <typeparam name="T">The table type</typeparam>
    /// <typeparam name="I">The index type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ITableSpan<T,I> : ITableSpan<T>
        where T : struct, ITable
        where I : unmanaged
    {
        ref T this[I index] {get;}
    }

    /// <summary>
    /// Characterizes a field-parametric <see cref='ITableSpan{T,I}'/>
    /// </summary>
    /// <typeparam name="F">The field specification</typeparam>
    /// <typeparam name="T">The table type</typeparam>
    /// <typeparam name="I">The index type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ITableSpan<F,T,I> : ITableSpan<T,I>
        where T : struct, ITable
        where I : unmanaged
        where F : unmanaged, Enum
    {
        
    }

    /// <summary>
    /// Characterizes a reified <see cref='ITableSpan{F,T,I}'/>
    /// </summary>
    /// <typeparam name="H">The host type</typeparam>
    /// <typeparam name="F">The field specification</typeparam>
    /// <typeparam name="T">The table type</typeparam>
    /// <typeparam name="I">The index type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ITableSpan<H,F,T,I> : ITableSpan<F,T,I>
        where H : struct, ITableSpan<H,F,T,I>
        where T : struct, ITable
        where I : unmanaged
        where F : unmanaged, Enum
    {
        
    }
}