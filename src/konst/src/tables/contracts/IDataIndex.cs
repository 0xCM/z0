//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;

    [SuppressUnmanagedCodeSecurity]
    public interface IDataIndex
    {
        Count32 Count {get;}

        int Length {get;}
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IDataIndex<T> : IDataIndex
    {
        T[] Data {get;}

        Span<T> Edit
            => Data;

        ReadOnlySpan<T> View
            => Data;

        Count32 IDataIndex.Count
            => Data.Length;

        int IDataIndex.Length
            => Data.Length;
    }
}