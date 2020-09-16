//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;

    public interface ISpanBuffer
    {
        /// <summary>
        /// The number of elements covered
        /// </summary>
        Count Count {get;}

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

    [SuppressUnmanagedCodeSecurity]
    public interface ISpanBuffer<T> : ISpanBuffer
    {
        T[] Storage {get;}

        int ISpanBuffer.Length
            => Storage?.Length ?? 0;

        Count ISpanBuffer.Count
            => Storage?.Length ?? 0;

        Span<T> Edit
            => Storage;

        ReadOnlySpan<T> View
            => Storage;

        ref T this[long index]
            => ref Storage[index];

        ref T this[ulong index]
            => ref Storage[index];

        bool ISpanBuffer.IsEmpty
            => Length == 0;

        bool ISpanBuffer.IsNonEmpty
            => Length != 0;
    }

    [SuppressUnmanagedCodeSecurity]
    public interface ISpanBuffer<H,T> : ISpanBuffer<T>
        where H : struct, ISpanBuffer<H,T>
    {
        H Refresh(T[] src);
    }
}