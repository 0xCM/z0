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
        CmdResult Run(IWfShell wf, CmdSpec spec);
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
}