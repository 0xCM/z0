//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface ICmdHost
    {
        CmdId CmdId {get;}
    }

    [Free]
    public interface ICmdHost<H> : ICmdHost
        where H : ICmdHost, new()
    {

    }

    [Free]
    public interface ICmdHost<H,C> : ICmdHost<H>
        where H : ICmdHost, new()
        where C : struct, ICmdSpec<C>
    {
        CmdResult Run(IWfShell wf, in C spec);
    }

    [Free]
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