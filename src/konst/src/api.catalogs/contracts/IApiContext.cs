//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IApiContext
    {

    }

    [Free]
    public interface IApiContext<H,C> : IApiContext, IStateful<C>
        where H : struct, IApiContext<H,C>
    {

    }
}