//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface ICmdRouter
    {
        CmdResult Dispatch(CmdSpec cmd);
    }

    [Free]
    public interface ICmdRouter<H> : ICmdRouter
        where H : ICmdRouter<H>
    {

    }
}