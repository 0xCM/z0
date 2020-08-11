//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Security;

    [SuppressUnmanagedCodeSecurity]
    public interface IDataModel
    {   
        string Name {get;}
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IDataModel<M> : IDataModel
        where M : IDataModel<M>, new()
    {
        string IDataModel.Name 
            => typeof(M).Name;
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IDataModel<M,K> : IDataModel<M>
        where M : struct, IDataModel<M,K>
        where K : unmanaged, Enum
    {
        K Kind {get;}        
    }
}