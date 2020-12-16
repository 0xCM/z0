//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface ITableProjector
    {

    }


    [Free]
    public interface ITableProjector<S,T> : ITableProjector
        where S : struct
    {
        T Project(in S src);
    }
}