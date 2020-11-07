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

        IndexedView<CmdId> SupportedCommands {get;}
    }

    [Free]
    public interface ICmdRouter<H> : ICmdRouter
        where H : ICmdRouter<H>
    {

    }
}