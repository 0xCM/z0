//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public interface ICmdHost
    {
        CmdId CmdId {get;}
    }

    public interface ICmdHost<H> : ICmdHost
        where H : ICmdHost, new()
    {

    }

    public interface ICmdHost<H,C> : ICmdHost<H>
        where H : ICmdHost, new()
        where C : struct, ICmdSpec<C>
    {
        CmdResult Run(IWfShell wf, in C spec);
    }

    public interface ICmdHost<H,C,P> : ICmdHost<H,C>
        where H : ICmdHost, new()
        where C : struct, ICmdSpec<C>
        where P : struct

    {
        CmdResult Run(IWfShell wf, in C spec, out P payload);

        CmdResult ICmdHost<H,C>.Run(IWfShell wf, in C spec)
            => Run(wf, spec, out var _);
    }
}