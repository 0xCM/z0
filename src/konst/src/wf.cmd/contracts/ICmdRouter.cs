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
        ReadOnlySpan<CmdId> SupportedCommands {get;}

        void Enlist(Index<ICmdReactor> reactors);

        CmdResult Dispatch(ICmdExecSpec cmd);
    }

    [Free]
    public interface ICmdRouter<H> : ICmdRouter, IWfService<H,ICmdRouter>
        where H : ICmdRouter<H>, new()
    {

    }

}