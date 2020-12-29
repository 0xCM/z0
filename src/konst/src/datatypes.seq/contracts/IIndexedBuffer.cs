//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IIndexedBuffer<T> : INullity, IMeasured
    {
        T[] Storage {get;}

        ref T this[long index]
            => ref Storage[index];

        ref T this[ulong index]
            => ref Storage[index];

        int IMeasured.Length
            => Storage?.Length ?? 0;

        bool INullity.IsEmpty
            => Length == 0;

        bool INullity.IsNonEmpty
            => Length != 0;
    }
}