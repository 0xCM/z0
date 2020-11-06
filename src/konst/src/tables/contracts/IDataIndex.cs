//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IDataIndex
    {
        Count Count {get;}

        int Length {get;}
    }

    [Free]
    public interface IDataIndex<T> : IDataIndex
    {
        T[] Data {get;}

        Span<T> Edit
            => Data;

        ReadOnlySpan<T> View
            => Data;

        Count IDataIndex.Count
            => Data.Length;

        int IDataIndex.Length
            => Data.Length;
    }
}