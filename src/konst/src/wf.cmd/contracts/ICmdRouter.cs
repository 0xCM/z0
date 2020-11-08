//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface ICmdRouter : IWfService
    {
        CmdResult Dispatch(ICmdSpec cmd);

        IndexedView<CmdId> SupportedCommands {get;}
    }

    [Free]
    public interface ICmdRouter<H> : ICmdRouter, IWfService<H>
        where H : ICmdRouter<H>, new()
    {

    }
}