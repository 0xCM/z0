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
        IndexedView<CmdId> SupportedCommands {get;}

        void Enlist(params ICmdReactor[] reactors);

        CmdResult Dispatch(ICmdSpec cmd);
    }

    [Free]
    public interface ICmdRouter<H> : ICmdRouter, IWfService<H>
        where H : ICmdRouter<H>, new()
    {

    }

}