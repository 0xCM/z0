//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IStorageService : IWfService
    {

    }

    public interface IStorageService<T> : IWfService<T>
        where T : IStorageService<T>, IWfService<T>, new()
    {

    }
}