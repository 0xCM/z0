// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IMutableIndex<T> : IMeasured
    {
        ref T this[ulong index] {get;}

        ref readonly T Lookup(ulong index)
            => ref this[index];
    }
}