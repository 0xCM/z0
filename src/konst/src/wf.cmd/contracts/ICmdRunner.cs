//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface ICmdRunner
    {
        CmdId CmdId {get;}
    }

    [Free]
    public interface ICmdRunner<C> : ICmdRunner
        where C : struct, ICmdSpec<C>
    {
        CmdResult Run(IWfShell wf, in C spec);
    }

}