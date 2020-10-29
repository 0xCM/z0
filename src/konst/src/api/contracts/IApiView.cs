//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IApiView<S>
    {
        S Source {get;}
    }

    [Free]
    public interface IApiView<H,S> : IApiView<S>
        where H : IApiView<H,S>, new()
    {

    }
}