//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IEntity
    {

    }

    [Free]
    public interface IEntity<T> : IEntity
        where T : struct, IEntity<T>
    {

    }
}