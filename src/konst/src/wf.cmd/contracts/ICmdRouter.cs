//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface ICmdRouter : IWfShellService
    {
        IndexedView<CmdId> SupportedCommands {get;}

        void Enlist(params ICmdReactor[] reactors);

        CmdResult Dispatch(ICmdSpec cmd);

        CmdResult<T> Dispatch<S,T>(S cmd)
            where S : struct, ICmdSpec<S>
            where T : struct;

        ReadOnlySpan<CmdResult<T>> Dispatch<S,T>(ReadOnlySpan<S> src, bool pll)
            where S : struct, ICmdSpec<S>
            where T : struct;
    }

    [Free]
    public interface ICmdRouter<H> : ICmdRouter, IWfShellService<H>
        where H : ICmdRouter<H>, new()
    {

    }

}