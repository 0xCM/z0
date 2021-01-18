//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public interface IMemoryStore : IDataStore
    {
        UIntPtr StoreLocation {get;}
    }

    public interface IMemoryStore<T> : IMemoryStore, IDataStore<T>
        where T : struct
    {
        ref T Deposited {get;}
    }
}