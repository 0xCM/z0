//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IDataModel
    {
        string Name {get;}
    }

    [Free]
    public interface IDataModel<M> : IDataModel
        where M : IDataModel<M>, new()
    {
        string IDataModel.Name
            => typeof(M).Name;
    }

    [Free]
    public interface IDataModel<M,K> : IDataModel<M>
        where M : struct, IDataModel<M,K>
        where K : unmanaged, Enum
    {
        K Kind {get;}
    }
}