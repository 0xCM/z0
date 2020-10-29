//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;


    [Free]
    public interface ICmdHost : ICmdRunner
    {

        CmdResult Run(IWfShell wf, CmdData spec);
    }

    [Free]
    public interface ICmdHost<H> : ICmdHost
        where H : ICmdHost, new()
    {

    }

    [Free]
    public interface ICmdHost<H,C> : ICmdHost<H>, ICmdRunner<C>
        where H : ICmdHost, new()
        where C : struct, ICmdSpec<C>
    {

    }

    [Free]
    public interface ICmdHost<H,C,P> : ICmdHost<H,C>
        where H : ICmdHost, new()
        where C : struct, ICmdSpec<C>
        where P : struct

    {
        CmdResult Run(IWfShell wf, in C spec, out P payload);

        CmdResult ICmdRunner<C>.Run(IWfShell wf, in C spec)
            => Run(wf, spec, out var _);
    }
}