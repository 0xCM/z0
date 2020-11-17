//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IEntityLink<S,T> : IDataRelation<S,T>
        where S : struct, IEntity<S>
        where T : struct, IEntity<T>
    {

    }

    [Free]
    public interface IEntityLink<T> : IEntityLink<T,T>, ILink<T>
        where T : struct, IEntity<T>
    {

    }
}