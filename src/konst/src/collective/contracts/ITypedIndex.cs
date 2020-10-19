//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface ITypedIndex<T,K> : IMeasured
        where K : unmanaged
    {

        ref T this[ulong index] {get;}

        ref T this[K index]
            => ref this[z.uint64(index)];
    }
}