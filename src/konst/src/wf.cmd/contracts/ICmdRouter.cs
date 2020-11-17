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

        CmdResult Process(ICmdSpec cmd);

        CmdResult<T> Process<S,T>(S cmd)
            where S : struct, ICmdSpec<S>
            where T : struct;

        ReadOnlySpan<CmdResult<T>> Process<S,T>(ReadOnlySpan<S> src, bool pll)
            where S : struct, ICmdSpec<S>
            where T : struct;
    }

    [Free]
    public interface ICmdRouter<H> : ICmdRouter, IWfService<H>
        where H : ICmdRouter<H>, new()
    {

    }

}