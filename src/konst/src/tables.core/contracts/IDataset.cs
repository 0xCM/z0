//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;

    public interface IDataset<K,T>
        where T : struct
        where K : unmanaged
    {
        TableSpan<T> Data {get;}

    }

    public interface IDataset<F,K,T> : IDataset<K,T>
        where T : struct
        where F : struct, IDataset<F,K,T>
        where K : unmanaged
    {
    }

}