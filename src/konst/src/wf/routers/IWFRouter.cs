//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IWfRouter : IDisposable
    {
        WfRouterId RouterId {get;}

        Type RouterType {get;}
    }

    [Free]
    public interface IWfRouter<S> : IWfRouter
    {
        Outcome Route(S src);
    }

    [Free]
    public interface IWfRouter<S,T> : IWfRouter
    {
        Outcome Route(S src, out T dst);
    }
}