//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IDataStore  : IWfService
    {

    }

    public interface IDataStore<T> : IWfService<T>
        where T : IDataStore<T>, IWfService<T>, new()
    {

    }

}