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
        Count32 Count {get;}

        /// <summary>
        /// A bow to the ubiquitous and unreasonable devotion to *signed* 32-bit integers
        /// </summary>
        int Length {get;}

        /// <summary>
        /// Specifies whether the data is missing
        /// </summary>
        bool IsEmpty {get;}

        /// <summary>
        /// Specifies whether at least one cell is populated
        /// </summary>
        bool IsNonEmpty {get;}
    }

    /// <summary>
    /// Characterizes a parametric <see cref='ITableSpan' />
    /// </summary>
    /// <typeparam name="T">The table type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ITableSpan<T> : ITableSpan
        where T : struct
    {
        T[] Storage {get;}

        int ITableSpan.Length
            => Storage?.Length ?? 0;

        Count32 ITableSpan.Count
            => Storage?.Length ?? 0;

        Span<T> Edit
            => Storage;

        ReadOnlySpan<T> View
            => Storage;

        ref T this[long index]
            => ref Storage[index];

        ref T this[ulong index]
            => ref Storage[index];

        bool ITableSpan.IsEmpty
            => Length == 0;

        bool ITableSpan.IsNonEmpty
            => Length != 0;
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