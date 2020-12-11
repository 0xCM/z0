//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IDataRelation<S,T> : ILink<S,T>
        where S : struct
        where T : struct
    {

    }

    [Free]
    public interface IDataRelation<T> : IDataRelation<T,T>
        where T : struct
    {

    }
}