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
    public interface IDataEntity
    {
        Type EntityType {get;}
    }

    [Free]
    public interface IDataEntity<T> : IDataEntity
        where T : struct, IDataEntity<T>
    {
        Type IDataEntity.EntityType => typeof(T);
    }
}