//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IMemoryStore : IDataStore
    {
        UIntPtr StoreLocation {get;}
    }

    public interface IMemoryStore<T> : IMemoryStore, IDataStore<T>
        where T : struct
    {
        ref T StoredData {get;}
    }
}