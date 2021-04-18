//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IMemoryStore
    {
        UIntPtr StoreLocation {get;}
    }

    public interface IMemoryStore<T> : IMemoryStore
        where T : struct
    {
        ref T Deposited {get;}
    }
}